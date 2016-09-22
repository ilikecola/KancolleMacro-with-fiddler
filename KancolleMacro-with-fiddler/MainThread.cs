using System;
using System.Threading;


namespace KancolleMacro_with_fiddler
{
    class MainThread
    {
        private ActionHandle actioneevent = new ActionHandle();
        private IntPtr GameHwnd;
        private ThreadManager[] threadmanager;
        private ThreadManager thread;
        private int TeamNO;
        public MainThread(IntPtr hWnd, ThreadManager[] threadmanager, int TeamNO)
        {
            this.GameHwnd = hWnd;
            this.threadmanager = threadmanager;
            this.TeamNO = TeamNO;
            this.thread = threadmanager[TeamNO - 2];
        }

        public void ActionThread()
        {
            try
            {
                //线程开始
                thread.Sendlistboxmessage("线程" + TeamNO + "已启动");
                thread.Sendlabelmessage("线程" + TeamNO + "已启动");
                thread.Sendlistboxmessage("线程" + TeamNO + "正等待其他线程");


                Thread.Sleep(1000 + this.RndTime() * TeamNO);
                while (true)
                {
                    lock (convarible.Threadflag)
                    {
                        if (TeamNO == 2 && !convarible.Threadflag[1] && !convarible.Threadflag[2]) break;
                        if (TeamNO == 3 && !convarible.Threadflag[0] && !convarible.Threadflag[2]) break;
                        if (TeamNO == 4 && !convarible.Threadflag[0] && !convarible.Threadflag[1]) break;
                    }
                }
                threadmanager[TeamNO - 2].Sendlistboxmessage("线程" + TeamNO + "开始初始化");
                //初始化
                convarible.Threadflag[TeamNO - 2] = true;
                //返回母港
                thread.Sendlistboxmessage("第" + TeamNO + "舰队准备返回母港");
                Gohome();
                Thread.Sleep(2500 + this.RndTime());
                //进入补给
                thread.Sendlistboxmessage("第" + TeamNO + "舰队准备开始补给");
                GoSupply();
                Thread.Sleep(2500 + this.RndTime());
                //返回母港
                thread.Sendlistboxmessage("第" + TeamNO + "舰队准备返回母港");
                Gohome();
                Thread.Sleep(2500 + this.RndTime());
                //开始远征
                thread.Sendlistboxmessage("第" + TeamNO + "舰队准备开始远征");
                GoExpedition();
                convarible.Threadflag[TeamNO - 2] = false;

                ////线程结束





            }
            catch(ThreadAbortException e)
            {
                thread.Sendlistboxmessage("线程" + (TeamNO - 1) + "被意外中止");
                thread.Sendlabelmessage("线程" + (TeamNO - 1) + "被意外中止");
                thread.Sendlistboxmessage("Exception message:" + e.Message);
                convarible.Threadflag[TeamNO - 2] = false;
            }


        }

        private void GoExpedition()
        {
            thread.Sendlistboxmessage("开始远征");
            thread.Sendlabelmessage("开始远征");

            //点击出击
            thread.Sendlistboxmessage("计划点击出击");
            actioneevent.LeftClick(GameHwnd, 197 + this.RndPixel() * 5, 244 + this.RndPixel() * 5);
            Thread.Sleep(1000 + this.RndTime());

            // 点击远征
            thread.Sendlistboxmessage("计划点击远征");
            actioneevent.LeftClick(GameHwnd, 676 + this.RndPixel() * 5, 249 + this.RndPixel() * 5);//点击远征按钮

            thread.Sendtimemessage("overstart");
            while (true)
            {
                Thread.Sleep(500 + this.RndTime());
                if (convarible.mission_api_result == 1)
                {
                    break;
                }
            }
            thread.Sendtimemessage("overstop");
            convarible.mission_api_result = -1;
            thread.Sendlistboxmessage("点击远征成功");

            TeamGoExpedition(TeamNO);
        }

        private void TeamGoExpedition(int teamNO)
        {
            thread.Sendlistboxmessage("第" + TeamNO + "舰队准备开始远征");
            thread.Sendlabelmessage("第" + TeamNO + "舰队准备开始远征");

            Thread.Sleep(1000 + this.RndTime());

            //选择该海域所去舰队
            thread.Sendlistboxmessage("第" + TeamNO + "舰队尝试移动到指定地图");
            MoveToExpMap(convarible.Team_index[TeamNO - 2]);

            Thread.Sleep(1000 + this.RndTime());

            //点击决定
            actioneevent.LeftClick(GameHwnd, 677 + this.RndPixel(), 444 + this.RndPixel());
            thread.Sendlistboxmessage("正在选择第" + TeamNO.ToString() + "舰队");

            Thread.Sleep(1000 + this.RndTime());
            
            //选择舰队
            //=====如果不是第二舰队需要选择，否则跳过
            if (TeamNO != 2)
            {
                thread.Sendlistboxmessage("选择第" + TeamNO.ToString() + "舰队");
                actioneevent.LeftClick(GameHwnd, 395 + 29 * (TeamNO - 2) + this.RndPixel() / 2, 117 + this.RndPixel() / 2);//=======第TeamNO舰队
                Thread.Sleep(500 + this.RndTime());
            }

            //点击远征开始
            do
            {
                actioneevent.LeftClick(GameHwnd, 624 + this.RndPixel(), 445 + this.RndPixel());//远征开始
                Thread.Sleep(500 + this.RndTime());
            } while (convarible.ExStart_api_result != 1);
            convarible.ExStart_api_result = -1;
            thread.Sendlistboxmessage("第" + TeamNO.ToString() + "舰队开始远征");
            thread.Sendlabelmessage("第" + TeamNO.ToString() + "舰队开始远征");
            thread.Sendtimemessage("fleet" + TeamNO.ToString() + "finish");
            Thread.Sleep(5000 + this.RndTime());
        }

        private void MoveToExpMap(int index)
        {
            thread.Sendlistboxmessage("开始移动到远征地图");
            int Area = 0;
            int Loc = 0;
            //分割海域和地图
            if (index >= 1 && index <= 8)
            {
                Area = 1;
                Loc = index;
            }
            else if (index > 8 && index <= 16)
            {
                Area = 2;
                Loc = index - 8;
            }
            else if (index > 16 && index <= 24)
            {
                Area = 3;
                Loc = index - 16;
            }
            else if (index > 24 && index <= 32)
            {
                Area = 4;
                Loc = index - 23;
            }
            else if (index > 32 && index <= 39)
            {
                Area = 5;
                Loc = index - 32;
            }

            switch (Area)
            {
                case 0:
                    break;
                case 1:
                    //第一海域无需检查
                    actioneevent.LeftClick(GameHwnd, 140 + this.RndPixel(), 440 + this.RndPixel());
                    Thread.Sleep(300 + this.RndTime());
                    actioneevent.LeftClick(GameHwnd, 325 + this.RndPixel(), 175 + (Loc - 1) * 30 + this.RndPixel());
                    break;
                case 2:
                    actioneevent.LeftClick(GameHwnd, 195 + this.RndPixel(), 440 + this.RndPixel());
                    Thread.Sleep(300 + this.RndTime());
                    actioneevent.LeftClick(GameHwnd, 325 + this.RndPixel(), 175 + (Loc - 1) * 30 + this.RndPixel());
                    break;
                case 3:
                    actioneevent.LeftClick(GameHwnd, 260 + this.RndPixel(), 440 + this.RndPixel());
                    Thread.Sleep(300 + this.RndTime());
                    actioneevent.LeftClick(GameHwnd, 325 + this.RndPixel(), 175 + (Loc - 1) * 30 + this.RndPixel());
                    break;
                case 4:
                    actioneevent.LeftClick(GameHwnd, 310 + this.RndPixel(), 440 + this.RndPixel());
                    Thread.Sleep(300 + this.RndTime());
                    actioneevent.LeftClick(GameHwnd, 325 + this.RndPixel(), 175 + (Loc - 1) * 30 + this.RndPixel());
                    break;
                case 5:
                    actioneevent.LeftClick(GameHwnd, 370 + this.RndPixel(), 440 + this.RndPixel());
                    Thread.Sleep(300 + this.RndTime());
                    actioneevent.LeftClick(GameHwnd, 325 + this.RndPixel(), 175 + (Loc - 1) * 30 + this.RndPixel());
                    break;
                default:
                    break;
            }
        }

        private void GoSupply()
        {
            //调用此过程需要先调用GoHome!!!!!
            thread.Sendlistboxmessage("开始补给");
            thread.Sendlabelmessage("开始补给");

            thread.Sendlistboxmessage("尝试进入补给");
            //进入补给
            actioneevent.LeftClick(GameHwnd, 82 + this.RndPixel(), 220 + this.RndPixel());
            Thread.Sleep(1000 + this.RndTime());
            //切换舰队
            actioneevent.LeftClick(GameHwnd, 145 + 30 * (TeamNO - 1) + (this.RndPixel() / 2), 120 + (this.RndPixel() / 2));
            Thread.Sleep(1000 + this.RndTime());
            //全部补给
            int i = 0;
            do
            {
                actioneevent.MOUSEMOVE(GameHwnd, 20 + (this.RndPixel() / 2), 20 + (this.RndPixel() / 2));
                actioneevent.MOUSEMOVE(GameHwnd, 120 + (this.RndPixel() / 2), 120 + (this.RndPixel() / 2));
                Thread.Sleep(200 + this.RndTime());
                actioneevent.LeftClick(GameHwnd, 120 + (this.RndPixel() / 2), 120 + (this.RndPixel() / 2));
                i++;
            } while (convarible.charge_api_result != 1 && i < 5);
            convarible.charge_api_result = -1;
        }

        private void Gohome()
        {
            thread.Sendlistboxmessage("线程" + TeamNO + "计划返回母港");
            thread.Sendlabelmessage("返回母港");
            thread.Sendtimemessage("overstart");
            do
            {
                actioneevent.LeftClick(GameHwnd, 90 + this.RndPixel(), 90 + this.RndPixel());
                Thread.Sleep(500 + this.RndTime());
            } while (convarible.port_api_result != 1);
            convarible.port_api_result = -1;

            checkExpedition();

            thread.Sendtimemessage("overstop");
        }

        private void checkExpedition()
        {
            DateTime UnixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            long now_UNIX = (long)(DateTime.UtcNow - UnixEpoch).TotalMilliseconds;
            for(int i = 0; i < 4; i++)
            {
                if(convarible.api_mission_time[i] != 0 && convarible.api_mission_time[i]- now_UNIX < 0 && convarible.Team_GO[i - 1] == true)
                {
                    thread.Sendlistboxmessage("线程" + TeamNO + "检测到远征归来");
                    GetExpedition();
                }
            }
        }

        private void GetExpedition()
        {
            thread.Sendlistboxmessage("线程" + TeamNO + "准备迎接远征队");
            thread.Sendlabelmessage("准备迎接远征队");

            //点击旗帜
            Thread.Sleep(1000 + this.RndTime());
            do
            {
                actioneevent.LeftClick(GameHwnd, 400 + this.RndPixel() * 10, 240 + this.RndPixel() * 10);
                Thread.Sleep(500 + this.RndTime());
            } while (convarible.result_api_result != 1);
            convarible.result_api_result = -1;

            Thread.Sleep(8000 + this.RndTime());
            //点击齿轮
            actioneevent.LeftClick(GameHwnd, 760 + this.RndPixel(), 441 + this.RndPixel());
            Thread.Sleep(1000 + this.RndTime());
            actioneevent.LeftClick(GameHwnd, 760 + this.RndPixel(), 441 + this.RndPixel());
            Thread.Sleep(500 + this.RndTime());
        }

        private int RndTime()
        {
            Random ra = new Random();
            int rnd;
            rnd = ra.Next(-convarible.RndTimeRange, convarible.RndTimeRange);
            return rnd;
        }

        private int RndPixel()
        {
            Random ra = new Random();
            int rnd;
            rnd = ra.Next(-convarible.RndPixelRange, convarible.RndPixelRange);
            return rnd;
        }
    }
}

