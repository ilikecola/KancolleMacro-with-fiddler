using System;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using static KancolleMacro_with_fiddler.FiddlerSetting;

namespace KancolleMacro_with_fiddler
{
    public partial class MainFrame : Form
    {
        //定义Fiddler变量
        private FiddlerSetting Fiddler_setting = new FiddlerSetting();

        //调用DLL
        [DllImport("user32.dll", EntryPoint = "FindWindow")]
        private extern static IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll", EntryPoint = "FindWindowEx")]
        private static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);
        [DllImport("user32.dll", EntryPoint = "GetWindowText")]
        public static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);
        [DllImport("user32.dll", EntryPoint = "GetClassName")]
        public static extern int GetClassName(IntPtr hWnd, StringBuilder lpString, int nMaxCount);
        [DllImport("user32.dll", EntryPoint = "WindowFromPoint")]
        public static extern IntPtr WindowFromPoint(Point point);
        [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
        private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndlnsertAfter, int X, int Y, int cx, int cy, uint Flags);
        [DllImport("user32.dll", EntryPoint = "GetWindowRect")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetWindowRect(IntPtr hWnd, ref RECT lpRect);
        [StructLayout(LayoutKind.Sequential)]

        //设置变量
        private struct RECT
        {
            public int Left; //最左坐标
            public int Top; //最上坐标
            public int Right; //最右坐标
            public int Bottom; //最下坐标
        }
        //窗口相关
        IntPtr ParentGamehWnd = new IntPtr(0);
        IntPtr GamehWnd = new IntPtr(0);
        IntPtr KCVhWnd = new IntPtr(0);
        IntPtr POIhWnd = new IntPtr(0);
        IntPtr _74hWnd = new IntPtr(0);
        int Gamewidth = 0; //窗口的宽度
        int Gameheight = 0; //窗口的高度
        int ParentGamehWndposX;
        int ParentGamehWndposY;
        //启动开关
        int _switch = 0;
        //时间设置
        int DelayStart;
        int StopTime;
        int OverTime = 20;
        int[] fleet = new int[3] { 0,0,0};        
        //统计信息
        int fleet2count = 0;
        int fleet3count = 0;
        int fleet4count = 0;

        //定义线程管理和委托
        private delegate void MessageHandler(MessageEventArgs e);
        public ThreadManager[] threadmanager = new ThreadManager[3];
        private delegate void AutoSetTimeCallback(int time);

        //
        //主程序
        //
        public MainFrame()
        {
            InitializeComponent();
            logbox1.Items.Insert("界面启动完成");
            this.RegisterEvent();
            Fiddler_setting.initialization();          
            logbox1.Items.Insert("代理启动完成");
            

        }

        private void AutoSetTime(int index)
        {
            index--;
            if (fleet[index] > 0)
            {
                Hours[index].Text = (((fleet[index] - fleet[index] % 60) / 60 - ((fleet[index] - fleet[index] % 60) / 60) % 60) / 60).ToString();
                Mins[index].Text = (((fleet[index] - fleet[index] % 60) / 60) % 60).ToString();
                Secs[index].Text = (fleet[index] % 60).ToString();
                
            }
            FleetTimers[index].Enabled = true;
        }

        private void RegisterEvent()
        {
            Fiddler_setting.log2Box += new LogControlThread(log2box);
            Fiddler_setting.autotimer += new TimeControlThread(getExTime);
            for (int i = 0; i < 3; i++)
            {
                threadmanager[i] = new ThreadManager();
                threadmanager[i].logboxMessageSend += new ThreadManager.MessageEventHandler(_logbox_MessageSend);//log
                threadmanager[i].labelMessageSend += new ThreadManager.MessageEventHandler(_label_MessageSend);//即时log
                threadmanager[i].timeMessageSend += new ThreadManager.MessageEventHandler(_time_MessageSend);//timer交互
            }

        }

        private void getExTime(int index, long time)
        {
            if (index > 0)
            {
                DateTime UnixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                long now_UNIX = (long)(DateTime.UtcNow - UnixEpoch).TotalMilliseconds;
                if (convarible.api_mission_time[index] - now_UNIX < 0)
                    fleet[index - 1] = 0;
                else
                    fleet[index - 1] = (int)((convarible.api_mission_time[index] - now_UNIX) / 1000);
                AutoSetTimeCallback d = new AutoSetTimeCallback(AutoSetTime);
                this.Invoke(d, new object[] { index });
            }
        }

        private void _time_MessageSend(object sender, MessageEventArgs e)
        {
            //实例化代理
            MessageHandler handler = new MessageHandler(timehandle);
            //调用Invoke
            this.Invoke(handler, new object[] { e });
        }

        private void timehandle(MessageEventArgs e)
        {
            if (e.Message.ToString() == "overstart")
            {
                OverTime = int.Parse(textBox6.Text);
                Overtimer.Enabled = true;
            }
            if (e.Message.ToString() == "overstop")
            {
                OverTime = int.Parse(textBox6.Text);
                Overtimer.Enabled = false;
            }

            if (char.IsDigit(e.Message.ToString(),5))
            {
                int fleetNo = Int32.Parse(e.Message.ToString().Substring(5, 1)) - 2;
                fleet[fleetNo] = convarible.Expeditiontime[Int32.Parse(FleetExNos[fleetNo].Text.ToString())] * 60 + this.RndTime();
                Hours[fleetNo].Text = (((fleet[fleetNo] - fleet[fleetNo] % 60) / 60 - ((fleet[fleetNo] - fleet[fleetNo] % 60) / 60) % 60) / 60).ToString();
                Mins[fleetNo].Text = (((fleet[fleetNo] - fleet[fleetNo] % 60) / 60) % 60).ToString();
                Secs[fleetNo].Text = (fleet[fleetNo] % 60).ToString();
                FleetTimers[fleetNo].Enabled = true;
            }
        }

        private void _label_MessageSend(object sender, MessageEventArgs e)
        {
            //实例化代理
            MessageHandler handler = new MessageHandler(updatelabel);
            //调用Invoke
            this.Invoke(handler, new object[] { e });
        }

        private void updatelabel(MessageEventArgs e)
        {
            label21.Text = e.Message.ToString();
            if (char.IsDigit(e.Message.ToString(), 1))
            {
                fleetstate[Int32.Parse(e.Message.ToString().Substring(1, 1)) - 2].Text = "正在远征";
            }
        }

        private void _logbox_MessageSend(object sender, MessageEventArgs e)
        {
            //实例化代理
            MessageHandler handler = new MessageHandler(updatelistbox);
            //调用Invoke
            this.Invoke(handler, new object[] { e });
        }

        private void updatelistbox(MessageEventArgs e)
        {
            log2box(e.Message.ToString());
        }

        private void Start_Click(object sender, System.EventArgs e)
        {
            if (_switch == 0)
            {
                DelayStart = int.Parse(textBox1.Text) * 60;
                if (DelayStart > 0)
                {
                    delaytimer.Enabled = true;
                }
                else
                {
                    before_start();
                }

            }
        }

        private void before_start()
        {
            if (GamehWnd != IntPtr.Zero)
            {
                logbox1.Items.Insert("开始启用");
                label21.Text = "已启动";
                Startinital();
            }
            else
            {
                askbrowser();
                if (GamehWnd != IntPtr.Zero)
                {
                    logbox1.Items.Insert("开始启用");
                    label21.Text = "已启动";
                    Startinital();
                }
                else
                {
                    MessageBox.Show("句柄未找到，请手动设置");
                    logbox1.Items.Insert("句柄未找到，请手动设置");
                }
            }
        }

        private void Startinital()
        {
            if (checkBox1.Checked == true || checkBox2.Checked == true || checkBox3.Checked == true)
            {
                if ((checkBox4.Checked == true && int.Parse(textBox2.Text) * 60 * 60 + int.Parse(textBox3.Text) * 60 >= DelayStart)
                    ||(checkBox4.Checked == false))
                {
                    convarible.RndTimeRange = int.Parse(textBox5.Text);
                    convarible.RndPixelRange = int.Parse(textBox4.Text);
                    convarible.RndWaitTimeRange = int.Parse(textBox9.Text);
                    convarible.rndTimeModification();
                    convarible.rndPixelModification();
                    convarible.Team_index[0] = int.Parse(Fleet2ExNO.Text.ToString());
                    convarible.Team_index[1] = int.Parse(Fleet3ExNO.Text.ToString());
                    convarible.Team_index[2] = int.Parse(Fleet4ExNO.Text.ToString());
                    convarible.Team_GO[0] = checkBox1.Checked;
                    convarible.Team_GO[1] = checkBox2.Checked;
                    convarible.Team_GO[2] = checkBox3.Checked;
                    textBox5.Text = convarible.RndTimeRange.ToString();
                    textBox4.Text = convarible.RndPixelRange.ToString();
                    OverTime = int.Parse(textBox6.Text);
                    StopTime = int.Parse(textBox2.Text) * 60 * 60 + int.Parse(textBox3.Text) * 60;//转换成秒
                    logbox1.Items.Insert("读取设置完成");
                    logbox1.Items.Insert("开始倒计时");

                    groupBox1.Enabled = false;
                    groupBox2.Enabled = false;
                    groupBox3.Enabled = false;
                    checkBox1.Enabled = false;
                    checkBox2.Enabled = false;
                    checkBox3.Enabled = false;
                    Fleet2ExNO.ReadOnly = true;
                    Fleet3ExNO.ReadOnly = true;
                    Fleet4ExNO.ReadOnly = true;
                    Hour1.ReadOnly = true;
                    Hour2.ReadOnly = true;
                    Hour3.ReadOnly = true;
                    Min1.ReadOnly = true;
                    Min2.ReadOnly = true;
                    Min3.ReadOnly = true;
                    Sec1.ReadOnly = true;
                    Sec2.ReadOnly = true;
                    Sec3.ReadOnly = true;
                    fleet4count = 0;
                    fleet3count = 0;
                    fleet2count = 0;
                    label16.Text = fleet4count.ToString();
                    label17.Text = fleet3count.ToString();
                    label18.Text = fleet2count.ToString();

                    
                    for(int i = 0; i < 3; i++)
                    {
                        threadmanager[i].initalThread(GamehWnd, threadmanager, i + 2);
                    }


                    _switch = 1;


                    if (checkBox7.Checked == true)
                    {
                        DateTime currentTime = new DateTime();
                        int all;
                        if ((int.Parse(textBox8.Text) < currentTime.Hour) || (int.Parse(textBox8.Text) == currentTime.Hour && int.Parse(textBox7.Text) <= currentTime.Minute))
                        {
                            //先计算到当天0点的剩余时间
                            int Day1Hour = 24 - (currentTime.Hour + 1);
                            int Day1min = 60 - (currentTime.Minute + 1);
                            int Day1sec = 60 - currentTime.Second;
                            int Day1alltosec = Day1Hour * 60 * 60 + Day1min * 60 + Day1sec;
                            //计算第二天的剩余时间
                            int Day2hour = int.Parse(textBox8.Text);
                            int Day2min = int.Parse(textBox7.Text);
                            int Day2alltosec = Day2hour * 60 * 60 + Day2min * 60;
                            //计算综合
                            all = Day1alltosec + Day2alltosec;
                        }
                        else
                        {
                            int lefthour = int.Parse(textBox8.Text) - (currentTime.Hour + 1);
                            int leftmin = 60 - (currentTime.Minute + 1);
                            int leftsec = 60 - currentTime.Second;
                            all = int.Parse(textBox7.Text) * 60 + lefthour * 60 * 60 + leftmin * 60 + leftsec;
                        }
                        StopTime = all;
                        autostop.Enabled = true;
                    }


                    label70.Text = "脚本开始";
                    logbox1.Items.Insert("脚本开始");
                    fleetJudge();
                }
                else
                {
                    MessageBox.Show("自动结束时间早于延迟时间或者时间太短", "发生错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("请至少选择一支舰队", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void fleetJudge()
        {
            for (int i=0;i<3;i++)
            {
                if (fleet[i]>0)
                {
                    fleetstate[i].Text = "正在远征";
                }
            }

            if (checkBox4.Checked == true)
            {
                if (int.Parse(textBox2.Text) + int.Parse(textBox3.Text) > 0)
                {
                    autostop.Enabled = true;
                }
                else
                {
                    checkBox4.Checked = false;
                }

            }

            if (convarible.Team_GO[0] == true && fleet2timer.Enabled == false)
            {
                fleet2timer.Enabled = true;
            }

            Thread.Sleep(1);

            if (convarible.Team_GO[1] == true && fleet3timer.Enabled == false)
            {
                fleet3timer.Enabled = true;
            }

            Thread.Sleep(1);

            if (convarible.Team_GO[2] == true && fleet4timer.Enabled == false)
            {
                fleet4timer.Enabled = true;
            }
        }

        private void PortSet_Click(object sender, System.EventArgs e)
        {
            PortSet PortSet = new PortSet();
            PortSet.ShowDialog();
            int[] check = PortSet.check();
            if (check[0] != Int32.Parse(ConfigurationManager.AppSettings["listenPort"]) && check[1] != 0)
            {
                Fiddler_setting.listenportchange(check[0]);
            }
            if (check[1] != Int32.Parse(ConfigurationManager.AppSettings["upstreamPort"]) && check[1] != 0)
            {
                Fiddler_setting.listenportchange(check[1]);
            }
        }

        //限制只能输入数字
        private void LimitedTextBox(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        //分别限制最大值
        private void LimitedTextRange(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox != null)
            {
                if (textBox.Name.Length > 4 && textBox.Name.Remove(4, 1).Equals("Hour"))
                {
                    int value;
                    if (int.TryParse(textBox.Text, out value))
                    {
                        if (value > 24 || value < 0)
                        {
                            textBox.Text = "0";
                        }
                    }
                }
                else if (textBox.Name.Length > 3 && textBox.Name.Remove(3, 1).Equals("Min"))
                {
                    int value;
                    if (int.TryParse(textBox.Text, out value))
                    {
                        if (value > 60 || value < 0)
                        {
                            textBox.Text = "0";
                        }
                    }
                }
                else if (textBox.Name.Length > 3 && textBox.Name.Remove(3, 1).Equals("Sec"))
                {
                    int value;
                    if (int.TryParse(textBox.Text, out value))
                    {
                        if (value > 60 || value < 0)
                        {
                            textBox.Text = "0";
                        }
                    }
                }
                else if (textBox.Name.Length > 5 && textBox.Name.Remove(5, 5).Equals("Fleet"))
                {
                    int value;
                    if (int.TryParse(textBox.Text, out value))
                    {
                        if (value > 40 || value < 1)
                        {
                            textBox.Text = "0";
                        }
                    }
                }
            }
        }

        public void log2box(string message)
        {
            this.logbox1.Items.Insert(message);
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            //停止计时器
            fleet2timer.Enabled = false;
            fleet3timer.Enabled = false;
            fleet4timer.Enabled = false;
            manual.Enabled = false;
            SysTime.Enabled = true;
            Overtimer.Enabled = false;
            delaytimer.Enabled = false;
            autostop.Enabled = false;
            //计时器时间设定
            fleet2timer.Interval = 1000;//1s
            fleet3timer.Interval = 1000;//1s
            fleet4timer.Interval = 1000;//1s
            manual.Interval = 500;//手动找句柄
            SysTime.Interval = 1000;//       
            Overtimer.Interval = 1000;//
            delaytimer.Interval = 1000;//1s
            autostop.Interval = 1000;//1s
            logbox1.SelectionMode = SelectionMode.One;
            checkBox1.Checked = true;
            checkBox2.Checked = true;
            checkBox3.Checked = true;
            fleetstate = new Label[3] { this.label5, this.label6, this.label7 };
            Hours = new TextBox[3] { this.Hour1, this.Hour2, this.Hour3 };
            Mins = new TextBox[3] { this.Min1, this.Min2, this.Min3 };
            Secs = new TextBox[3] { this.Sec1, this.Sec2, this.Sec3 };
            FleetExNos = new TextBox[3] { this.Fleet2ExNO, this.Fleet3ExNO, this.Fleet4ExNO };
            FleetTimers = new System.Windows.Forms.Timer[3] { this.fleet2timer, this.fleet3timer, this.fleet4timer };
            convarible.inital();

            logbox1.Items.Insert("组件初始化完成");
        }

        private void AutoSet_Click(object sender, EventArgs e)
        {
            this.askbrowser();
        }

        private void askbrowser()
        {
            askwhichbrowser askwhichbrowser = new askwhichbrowser();
            askwhichbrowser.InitializeComponent();
            askwhichbrowser.StartPosition = FormStartPosition.CenterParent;
            askwhichbrowser.ShowDialog();
            int broswer = askwhichbrowser.Getbrowser();
            askwhichbrowser.Dispose();
            convarible.DPIscale = int.Parse(textBox10.Text.ToString());
            switch (broswer)
            {
                case 0:
                    FindPOI();
                    break;
                case 1:
                    //FindKCV();
                    break;
                default: break;
            }
        }

        private void FindPOI()
        {
            IntPtr ParenthWnd = new IntPtr(0);
            IntPtr childHwnd = new IntPtr(0);
            ParenthWnd = FindWindow(null, "poi");
            //判断这个窗体是否有效 
            if (ParenthWnd != IntPtr.Zero)
            {
                POIhWnd = ParenthWnd;
                childHwnd = FindWindowEx(ParenthWnd, IntPtr.Zero, "Chrome_RenderWidgetHostHWND", null);
                ActionHandle getsize = new ActionHandle();
                Gamewidth = getsize.Getwidth_height(childHwnd)[0];
                Gameheight = getsize.Getwidth_height(childHwnd)[1];
                if (Gamewidth == 0 || Gameheight == 0)
                {
                    childHwnd = FindWindowEx(ParenthWnd, childHwnd, "Chrome_RenderWidgetHostHWND", null);
                }
                ParentGamehWnd = POIhWnd;
                GamehWnd = childHwnd;
                label22.Text = GamehWnd.ToString();
                label62.Text = GamehWnd.ToString();
                logbox1.Items.Insert("自动动设置句柄成功 句柄为:" + GamehWnd.ToString());
                MessageBox.Show("已自动找到POI窗口");
            }
            else
            {
                MessageBox.Show("未找到POI窗口请检查");
                logbox1.Items.Insert("未找到POI窗口请检查");
            }
        }

        private void ManualSet_MouseDown(object sender, MouseEventArgs e)
        {
            manual.Enabled = true;
        }

        private void ManualSet_MouseUp(object sender, MouseEventArgs e)
        {
            manual.Enabled = false;
            ActionHandle getsize = new ActionHandle();
            Gamewidth = getsize.Getwidth_height(GamehWnd)[0];//窗口的宽度
            Gameheight = getsize.Getwidth_height(GamehWnd)[1]; //窗口的高度
            MessageBox.Show("句柄为" + GamehWnd + " " + "窗口大小为" + Gamewidth + "x" + Gameheight);
            if (Gamewidth != 800 || Gameheight != 480)
            {
                MessageBox.Show("窗口大小不正确 请重新自动/手动获取句柄 POI请使用自动模式");
                GamehWnd = IntPtr.Zero;
                Gamewidth = 0;
                Gameheight = 0;
                label22.Text = "未设定";
                label62.Text = "未设定";
                logbox1.Items.Insert("窗口大小不正确 请重新自动/手动获取句柄");
            }
            else
            {
                label22.Text = GamehWnd.ToString();
                label62.Text = GamehWnd.ToString();
                logbox1.Items.Insert("手动设置句柄成功 句柄为:");
            }
        }

        private void manual_Tick(object sender, EventArgs e)
        {
            int x = Cursor.Position.X;
            int y = Cursor.Position.Y;
            Point p = new Point(x, y);
            GamehWnd = WindowFromPoint(p);
            label62.Text = GamehWnd.ToString();
        }

        private void fleet2timer_Tick(object sender, EventArgs e)
        {
            fleet[0]--;
            if (fleet[0] > -1)
            {
                Hour1.Text = (((fleet[0] - fleet[0] % 60) / 60 - ((fleet[0] - fleet[0] % 60) / 60) % 60) / 60).ToString();
                Min1.Text = (((fleet[0] - fleet[0] % 60) / 60) % 60).ToString();
                Sec1.Text = (fleet[0] % 60).ToString();
            }
            if (fleet[0] <= 0)
            {
                fleet2timer.Enabled = false;
                fleet2count++;
                label18.Text = fleet2count.ToString();
                if (_switch == 1) threadmanager[0].StartThread();
            }
        }

        private void fleet3timer_Tick(object sender, EventArgs e)
        {
            fleet[1]--;
            if (fleet[1] > -1)
            {
                Hour2.Text = (((fleet[1] - fleet[1] % 60) / 60 - ((fleet[1] - fleet[1] % 60) / 60) % 60) / 60).ToString();
                Min2.Text = (((fleet[1] - fleet[1] % 60) / 60) % 60).ToString();
                Sec2.Text = (fleet[1] % 60).ToString();
            }
            if (fleet[1] <= 0)
            {
                fleet3timer.Enabled = false;
                fleet3count++;
                label17.Text = fleet3count.ToString();
                if (_switch == 1) threadmanager[1].StartThread();
            }
        }

        private void fleet4timer_Tick(object sender, EventArgs e)
        {
            fleet[2]--;
            if (fleet[2] > -1)
            {
                Hour3.Text = (((fleet[2] - fleet[2] % 60) / 60 - ((fleet[2] - fleet[2] % 60) / 60) % 60) / 60).ToString();
                Min3.Text = (((fleet[2] - fleet[2] % 60) / 60) % 60).ToString();
                Sec3.Text = (fleet[2] % 60).ToString();
            }
            if (fleet[2] <= 0)
            {
                fleet4timer.Enabled = false;
                fleet4count++;
                label16.Text = fleet4count.ToString();
                if (_switch == 1) threadmanager[2].StartThread();
            }
        }

        private void SysTime_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = System.DateTime.Now;
            string currentTimestr = currentTime.ToString("MM-dd HH:mm:ss");
            if (_switch == 1 && checkBox7.Checked == true && currentTime.Hour == int.Parse(textBox8.Text) && currentTime.Minute == int.Parse(textBox7.Text))
            {
                label21.Text = "自动停止";
                logbox1.Items.Insert("到达自动停止时间");
                StopThread();
            }
        }

        private void Overtimer_Tick(object sender, EventArgs e)
        {
            OverTime--;
            if (OverTime <= 0)
            {
                _switch = 0;
                label21.Text = "已停止";
                logbox1.Items.Insert("超时停止");
                //StopThread();

            }
        }

        private void delaytimer_Tick(object sender, EventArgs e)
        {
            DelayStart--;
            label70.Text = ((DelayStart - DelayStart % 60) / 60).ToString() + "分钟" + DelayStart % 60 + "秒";
            if (DelayStart <= 0)
            {
                label21.Text = "延迟脚本自动开始";
                logbox1.Items.Insert("延迟脚本自动开始");
                before_start();
                delaytimer.Enabled = false;
            }
        }

        private void autostop_Tick(object sender, EventArgs e)
        {
            StopTime--;
            label45.Text = (((StopTime - StopTime % 60) / 60) - ((StopTime - StopTime % 60) / 60) % 60) / 60 + "小时"
                + ((StopTime - StopTime % 60) / 60) % 60 + "分钟"
                + StopTime % 60 + "秒";
            if (StopTime <= 0)
            {
                label21.Text = "自动停止";
                logbox1.Items.Insert("到达自动停止时间");
                autostop.Enabled = false;
                StopThread();
                this.Enabled = false;
            }
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            if (_switch == 1)
            {
                checkBox5.Checked = false;
                StopThread();
                label21.Text = "已停止";
                logbox1.Items.Insert("手动停止");
            }
        }

        private void HideWindow_Click(object sender, EventArgs e)
        {
            RECT rc = new RECT();
            GetWindowRect(ParentGamehWnd, ref rc);
            ParentGamehWndposX = rc.Left;
            ParentGamehWndposY = rc.Top;
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;
            const int SWP_NOSIZE = 0x0001;
            SetWindowPos(ParentGamehWnd, (IntPtr)(0), screenHeight, screenWidth, 0, 0, SWP_NOSIZE);
        }

        private void RestoreWindow_Click(object sender, EventArgs e)
        {
            const int SWP_NOSIZE = 0x0001;
            SetWindowPos(ParentGamehWnd, (IntPtr)(0), ParentGamehWndposX, ParentGamehWndposY, 0, 0, SWP_NOSIZE);
        }

        private void StopThread()
        {

            threadmanager[0].EndThread();
            threadmanager[1].EndThread();
            threadmanager[2].EndThread();
            fleet2timer.Enabled = false;
            fleet3timer.Enabled = false;
            fleet4timer.Enabled = false;
            delaytimer.Enabled = false;
            Overtimer.Enabled = false;
            autostop.Enabled = false;

            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            checkBox3.Enabled = true;
            Fleet2ExNO.ReadOnly = false;
            Fleet3ExNO.ReadOnly = false;
            Fleet4ExNO.ReadOnly = false;
            Hour1.ReadOnly = false;
            Hour2.ReadOnly = false;
            Hour3.ReadOnly = false;
            Min1.ReadOnly = false;
            Min2.ReadOnly = false;
            Min3.ReadOnly = false;
            Sec1.ReadOnly = false;
            Sec2.ReadOnly = false;
            Sec3.ReadOnly = false;

            _switch = 0;

            if ((checkBox4.Checked == true || checkBox7.Checked == true) && checkBox5.Checked == true)
            {
                autoshutdown();
            }
        }

        private void autoshutdown()
        {
            Process proc = new Process();
            proc.StartInfo.FileName = "cmd.exe"; // 启动命令行程序
            proc.StartInfo.UseShellExecute = false; // 不使用Shell来执行,用程序来执行
            proc.StartInfo.RedirectStandardError = true; // 重定向标准输入输出
            proc.StartInfo.RedirectStandardInput = true;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.CreateNoWindow = true; // 执行时不创建新窗口
            proc.Start();

            string commandLine = @"shutdown /f /s /t 600";
            proc.StandardInput.WriteLine(commandLine);
            DialogResult cancel = MessageBox.Show("将在10mins后自动关机", "自动关机", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (cancel == DialogResult.OK)
            {
                commandLine = @"shutdown /a";
                proc.StandardInput.WriteLine(commandLine);
            }
        }

        private int RndTime()
        {
            int rnd;
            Random tor = new Random();
            rnd = tor.Next(1, convarible.RndWaitTimeRange);
            return rnd;
        }
    }
}
