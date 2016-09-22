using System;
using System.IO;
using System.Windows.Forms;

namespace KancolleMacro_with_fiddler
{
    partial class MainFrame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrame));
            this.tabcontrol = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Fleet4ExNO = new System.Windows.Forms.TextBox();
            this.Fleet3ExNO = new System.Windows.Forms.TextBox();
            this.Fleet2ExNO = new System.Windows.Forms.TextBox();
            this.Sec3 = new System.Windows.Forms.TextBox();
            this.Min3 = new System.Windows.Forms.TextBox();
            this.Hour3 = new System.Windows.Forms.TextBox();
            this.Sec2 = new System.Windows.Forms.TextBox();
            this.Min2 = new System.Windows.Forms.TextBox();
            this.Hour2 = new System.Windows.Forms.TextBox();
            this.Sec1 = new System.Windows.Forms.TextBox();
            this.Min1 = new System.Windows.Forms.TextBox();
            this.Hour1 = new System.Windows.Forms.TextBox();
            this.RestoreWindow = new System.Windows.Forms.Button();
            this.HideWindow = new System.Windows.Forms.Button();
            this.label70 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.Stop = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.label62 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label57 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label55 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label56 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label59 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label60 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label61 = new System.Windows.Forms.Label();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.label51 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.label50 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.label47 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.logbox1 = new KancolleMacro_with_fiddler.logbox();
            this.fleet2timer = new System.Windows.Forms.Timer(this.components);
            this.fleet3timer = new System.Windows.Forms.Timer(this.components);
            this.fleet4timer = new System.Windows.Forms.Timer(this.components);
            this.manual = new System.Windows.Forms.Timer(this.components);
            this.SysTime = new System.Windows.Forms.Timer(this.components);
            this.Overtimer = new System.Windows.Forms.Timer(this.components);
            this.delaytimer = new System.Windows.Forms.Timer(this.components);
            this.autostop = new System.Windows.Forms.Timer(this.components);
            this.tabcontrol.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabcontrol
            // 
            this.tabcontrol.Controls.Add(this.tabPage1);
            this.tabcontrol.Controls.Add(this.tabPage2);
            this.tabcontrol.Controls.Add(this.tabPage4);
            this.tabcontrol.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabcontrol.Location = new System.Drawing.Point(0, 0);
            this.tabcontrol.Margin = new System.Windows.Forms.Padding(6);
            this.tabcontrol.Name = "tabcontrol";
            this.tabcontrol.SelectedIndex = 0;
            this.tabcontrol.Size = new System.Drawing.Size(1467, 385);
            this.tabcontrol.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Fleet4ExNO);
            this.tabPage1.Controls.Add(this.Fleet3ExNO);
            this.tabPage1.Controls.Add(this.Fleet2ExNO);
            this.tabPage1.Controls.Add(this.Sec3);
            this.tabPage1.Controls.Add(this.Min3);
            this.tabPage1.Controls.Add(this.Hour3);
            this.tabPage1.Controls.Add(this.Sec2);
            this.tabPage1.Controls.Add(this.Min2);
            this.tabPage1.Controls.Add(this.Hour2);
            this.tabPage1.Controls.Add(this.Sec1);
            this.tabPage1.Controls.Add(this.Min1);
            this.tabPage1.Controls.Add(this.Hour1);
            this.tabPage1.Controls.Add(this.RestoreWindow);
            this.tabPage1.Controls.Add(this.HideWindow);
            this.tabPage1.Controls.Add(this.label70);
            this.tabPage1.Controls.Add(this.label71);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label65);
            this.tabPage1.Controls.Add(this.label66);
            this.tabPage1.Controls.Add(this.label67);
            this.tabPage1.Controls.Add(this.label68);
            this.tabPage1.Controls.Add(this.label69);
            this.tabPage1.Controls.Add(this.label58);
            this.tabPage1.Controls.Add(this.label45);
            this.tabPage1.Controls.Add(this.label46);
            this.tabPage1.Controls.Add(this.label44);
            this.tabPage1.Controls.Add(this.label27);
            this.tabPage1.Controls.Add(this.Stop);
            this.tabPage1.Controls.Add(this.Start);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.label23);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.checkBox3);
            this.tabPage1.Controls.Add(this.checkBox2);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(8, 49);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1451, 328);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "自动远征";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Fleet4ExNO
            // 
            this.Fleet4ExNO.Location = new System.Drawing.Point(268, 164);
            this.Fleet4ExNO.MaxLength = 2;
            this.Fleet4ExNO.Name = "Fleet4ExNO";
            this.Fleet4ExNO.Size = new System.Drawing.Size(100, 42);
            this.Fleet4ExNO.TabIndex = 194;
            this.Fleet4ExNO.Text = "38";
            this.Fleet4ExNO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Fleet4ExNO.TextChanged += new System.EventHandler(this.LimitedTextRange);
            this.Fleet4ExNO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LimitedTextBox);
            // 
            // Fleet3ExNO
            // 
            this.Fleet3ExNO.Location = new System.Drawing.Point(268, 114);
            this.Fleet3ExNO.MaxLength = 2;
            this.Fleet3ExNO.Name = "Fleet3ExNO";
            this.Fleet3ExNO.Size = new System.Drawing.Size(100, 42);
            this.Fleet3ExNO.TabIndex = 193;
            this.Fleet3ExNO.Text = "6";
            this.Fleet3ExNO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Fleet3ExNO.TextChanged += new System.EventHandler(this.LimitedTextRange);
            this.Fleet3ExNO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LimitedTextBox);
            // 
            // Fleet2ExNO
            // 
            this.Fleet2ExNO.Location = new System.Drawing.Point(268, 64);
            this.Fleet2ExNO.MaxLength = 2;
            this.Fleet2ExNO.Name = "Fleet2ExNO";
            this.Fleet2ExNO.Size = new System.Drawing.Size(100, 42);
            this.Fleet2ExNO.TabIndex = 192;
            this.Fleet2ExNO.Text = "5";
            this.Fleet2ExNO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Fleet2ExNO.TextChanged += new System.EventHandler(this.LimitedTextRange);
            this.Fleet2ExNO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LimitedTextBox);
            // 
            // Sec3
            // 
            this.Sec3.Location = new System.Drawing.Point(931, 163);
            this.Sec3.MaxLength = 2;
            this.Sec3.Name = "Sec3";
            this.Sec3.ReadOnly = true;
            this.Sec3.Size = new System.Drawing.Size(59, 42);
            this.Sec3.TabIndex = 191;
            this.Sec3.Text = "0";
            this.Sec3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Sec3.TextChanged += new System.EventHandler(this.LimitedTextRange);
            this.Sec3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LimitedTextBox);
            // 
            // Min3
            // 
            this.Min3.Location = new System.Drawing.Point(787, 163);
            this.Min3.MaxLength = 2;
            this.Min3.Name = "Min3";
            this.Min3.ReadOnly = true;
            this.Min3.Size = new System.Drawing.Size(59, 42);
            this.Min3.TabIndex = 190;
            this.Min3.Text = "0";
            this.Min3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Min3.TextChanged += new System.EventHandler(this.LimitedTextRange);
            this.Min3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LimitedTextBox);
            // 
            // Hour3
            // 
            this.Hour3.Location = new System.Drawing.Point(643, 163);
            this.Hour3.MaxLength = 2;
            this.Hour3.Name = "Hour3";
            this.Hour3.ReadOnly = true;
            this.Hour3.Size = new System.Drawing.Size(59, 42);
            this.Hour3.TabIndex = 189;
            this.Hour3.Text = "0";
            this.Hour3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Hour3.TextChanged += new System.EventHandler(this.LimitedTextRange);
            this.Hour3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LimitedTextBox);
            // 
            // Sec2
            // 
            this.Sec2.Location = new System.Drawing.Point(931, 114);
            this.Sec2.MaxLength = 2;
            this.Sec2.Name = "Sec2";
            this.Sec2.ReadOnly = true;
            this.Sec2.Size = new System.Drawing.Size(59, 42);
            this.Sec2.TabIndex = 188;
            this.Sec2.Text = "0";
            this.Sec2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Sec2.TextChanged += new System.EventHandler(this.LimitedTextRange);
            this.Sec2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LimitedTextBox);
            // 
            // Min2
            // 
            this.Min2.Location = new System.Drawing.Point(787, 114);
            this.Min2.MaxLength = 2;
            this.Min2.Name = "Min2";
            this.Min2.ReadOnly = true;
            this.Min2.Size = new System.Drawing.Size(59, 42);
            this.Min2.TabIndex = 187;
            this.Min2.Text = "0";
            this.Min2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Min2.TextChanged += new System.EventHandler(this.LimitedTextRange);
            this.Min2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LimitedTextBox);
            // 
            // Hour2
            // 
            this.Hour2.Location = new System.Drawing.Point(643, 114);
            this.Hour2.MaxLength = 2;
            this.Hour2.Name = "Hour2";
            this.Hour2.ReadOnly = true;
            this.Hour2.Size = new System.Drawing.Size(59, 42);
            this.Hour2.TabIndex = 186;
            this.Hour2.Text = "0";
            this.Hour2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Hour2.TextChanged += new System.EventHandler(this.LimitedTextRange);
            this.Hour2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LimitedTextBox);
            // 
            // Sec1
            // 
            this.Sec1.Location = new System.Drawing.Point(931, 64);
            this.Sec1.MaxLength = 2;
            this.Sec1.Name = "Sec1";
            this.Sec1.ReadOnly = true;
            this.Sec1.Size = new System.Drawing.Size(59, 42);
            this.Sec1.TabIndex = 185;
            this.Sec1.Text = "0";
            this.Sec1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Sec1.TextChanged += new System.EventHandler(this.LimitedTextRange);
            this.Sec1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LimitedTextBox);
            // 
            // Min1
            // 
            this.Min1.Location = new System.Drawing.Point(787, 64);
            this.Min1.MaxLength = 2;
            this.Min1.Name = "Min1";
            this.Min1.ReadOnly = true;
            this.Min1.Size = new System.Drawing.Size(59, 42);
            this.Min1.TabIndex = 184;
            this.Min1.Text = "0";
            this.Min1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Min1.TextChanged += new System.EventHandler(this.LimitedTextRange);
            this.Min1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LimitedTextBox);
            // 
            // Hour1
            // 
            this.Hour1.Location = new System.Drawing.Point(643, 64);
            this.Hour1.MaxLength = 2;
            this.Hour1.Name = "Hour1";
            this.Hour1.ReadOnly = true;
            this.Hour1.Size = new System.Drawing.Size(59, 42);
            this.Hour1.TabIndex = 183;
            this.Hour1.Text = "0";
            this.Hour1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Hour1.TextChanged += new System.EventHandler(this.LimitedTextRange);
            this.Hour1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LimitedTextBox);
            // 
            // RestoreWindow
            // 
            this.RestoreWindow.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RestoreWindow.Location = new System.Drawing.Point(1139, 176);
            this.RestoreWindow.Margin = new System.Windows.Forms.Padding(6);
            this.RestoreWindow.Name = "RestoreWindow";
            this.RestoreWindow.Size = new System.Drawing.Size(230, 48);
            this.RestoreWindow.TabIndex = 181;
            this.RestoreWindow.Text = "恢复窗口";
            this.RestoreWindow.UseVisualStyleBackColor = true;
            this.RestoreWindow.Click += new System.EventHandler(this.RestoreWindow_Click);
            // 
            // HideWindow
            // 
            this.HideWindow.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HideWindow.Location = new System.Drawing.Point(1139, 116);
            this.HideWindow.Margin = new System.Windows.Forms.Padding(6);
            this.HideWindow.Name = "HideWindow";
            this.HideWindow.Size = new System.Drawing.Size(230, 48);
            this.HideWindow.TabIndex = 180;
            this.HideWindow.Text = "隐藏窗口";
            this.HideWindow.UseVisualStyleBackColor = true;
            this.HideWindow.Click += new System.EventHandler(this.HideWindow_Click);
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label70.Location = new System.Drawing.Point(652, 225);
            this.label70.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(93, 35);
            this.label70.TabIndex = 179;
            this.label70.Text = "未获取";
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label71.Location = new System.Drawing.Point(400, 225);
            this.label71.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(171, 35);
            this.label71.TabIndex = 178;
            this.label71.Text = "脚本开始时间";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(1014, 167);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 35);
            this.label12.TabIndex = 168;
            this.label12.Text = "秒";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(855, 167);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 35);
            this.label13.TabIndex = 167;
            this.label13.Text = "分钟";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(711, 167);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 35);
            this.label14.TabIndex = 166;
            this.label14.Text = "小时";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(1014, 117);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 35);
            this.label15.TabIndex = 165;
            this.label15.Text = "秒";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label65.Location = new System.Drawing.Point(855, 117);
            this.label65.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(67, 35);
            this.label65.TabIndex = 164;
            this.label65.Text = "分钟";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label66.Location = new System.Drawing.Point(711, 117);
            this.label66.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(67, 35);
            this.label66.TabIndex = 163;
            this.label66.Text = "小时";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label67.Location = new System.Drawing.Point(1014, 67);
            this.label67.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(41, 35);
            this.label67.TabIndex = 162;
            this.label67.Text = "秒";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label68.Location = new System.Drawing.Point(855, 67);
            this.label68.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(67, 35);
            this.label68.TabIndex = 161;
            this.label68.Text = "分钟";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label69.Location = new System.Drawing.Point(711, 67);
            this.label69.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(67, 35);
            this.label69.TabIndex = 160;
            this.label69.Text = "小时";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label58.Location = new System.Drawing.Point(262, 21);
            this.label58.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(119, 35);
            this.label58.TabIndex = 156;
            this.label58.Text = "远征编号";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label45.Location = new System.Drawing.Point(652, 275);
            this.label45.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(93, 35);
            this.label45.TabIndex = 155;
            this.label45.Text = "未获取";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label46.Location = new System.Drawing.Point(400, 275);
            this.label46.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(223, 35);
            this.label46.TabIndex = 154;
            this.label46.Text = "自动结束剩余时间";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label44.Location = new System.Drawing.Point(16, 275);
            this.label44.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(171, 35);
            this.label44.TabIndex = 152;
            this.label44.Text = "进行中的动作";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label27.Location = new System.Drawing.Point(637, 21);
            this.label27.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(119, 35);
            this.label27.TabIndex = 131;
            this.label27.Text = "剩余时间";
            // 
            // Stop
            // 
            this.Stop.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Stop.Location = new System.Drawing.Point(1257, 60);
            this.Stop.Margin = new System.Windows.Forms.Padding(6);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(112, 48);
            this.Stop.TabIndex = 129;
            this.Stop.Text = "停止";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Start.Location = new System.Drawing.Point(1139, 60);
            this.Start.Margin = new System.Windows.Forms.Padding(6);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(112, 48);
            this.Start.TabIndex = 128;
            this.Start.Text = "开始";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label22.Location = new System.Drawing.Point(212, 225);
            this.label22.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(93, 35);
            this.label22.TabIndex = 127;
            this.label22.Text = "未获取";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label23.Location = new System.Drawing.Point(16, 225);
            this.label23.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(119, 35);
            this.label23.TabIndex = 126;
            this.label23.Text = "游戏句柄";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label21.Location = new System.Drawing.Point(212, 275);
            this.label21.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(93, 35);
            this.label21.TabIndex = 125;
            this.label21.Text = "未获取";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(531, 167);
            this.label16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(30, 35);
            this.label16.TabIndex = 123;
            this.label16.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(531, 117);
            this.label17.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(30, 35);
            this.label17.TabIndex = 122;
            this.label17.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(531, 67);
            this.label18.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(30, 35);
            this.label18.TabIndex = 121;
            this.label18.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.Location = new System.Drawing.Point(531, 21);
            this.label19.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 35);
            this.label19.TabIndex = 120;
            this.label19.Text = "统计";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(400, 167);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 35);
            this.label7.TabIndex = 111;
            this.label7.Text = "未设定";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(400, 117);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 35);
            this.label6.TabIndex = 110;
            this.label6.Text = "未设定";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(400, 67);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 35);
            this.label5.TabIndex = 109;
            this.label5.Text = "未设定";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(400, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 35);
            this.label4.TabIndex = 108;
            this.label4.Text = "舰队状态";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox3.Location = new System.Drawing.Point(22, 165);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(6);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(99, 39);
            this.checkBox3.TabIndex = 107;
            this.checkBox3.Text = "启用";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox2.Location = new System.Drawing.Point(22, 115);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(6);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(99, 39);
            this.checkBox2.TabIndex = 106;
            this.checkBox2.Text = "启用";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox1.Location = new System.Drawing.Point(22, 65);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(6);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(99, 39);
            this.checkBox1.TabIndex = 105;
            this.checkBox1.Text = "启用";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(128, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 35);
            this.label3.TabIndex = 104;
            this.label3.Text = "第四舰队";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(128, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 35);
            this.label2.TabIndex = 103;
            this.label2.Text = "第三舰队";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(128, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 35);
            this.label1.TabIndex = 102;
            this.label1.Text = "第二舰队";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(8, 49);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage2.Size = new System.Drawing.Size(1451, 328);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "启动前设置";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button8);
            this.groupBox3.Controls.Add(this.textBox10);
            this.groupBox3.Controls.Add(this.label28);
            this.groupBox3.Controls.Add(this.checkBox8);
            this.groupBox3.Controls.Add(this.label62);
            this.groupBox3.Controls.Add(this.label63);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.label57);
            this.groupBox3.Controls.Add(this.textBox6);
            this.groupBox3.Controls.Add(this.label55);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(901, 12);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox3.Size = new System.Drawing.Size(524, 287);
            this.groupBox3.TabIndex = 139;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "其他设置";
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button8.Location = new System.Drawing.Point(291, 158);
            this.button8.Margin = new System.Windows.Forms.Padding(6);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(127, 48);
            this.button8.TabIndex = 145;
            this.button8.Text = "端口设置";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.PortSet_Click);
            // 
            // textBox10
            // 
            this.textBox10.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox10.Location = new System.Drawing.Point(445, 49);
            this.textBox10.Margin = new System.Windows.Forms.Padding(6);
            this.textBox10.MaxLength = 1;
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(28, 42);
            this.textBox10.TabIndex = 144;
            this.textBox10.Text = "2";
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(265, 49);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(171, 35);
            this.label28.TabIndex = 143;
            this.label28.Text = "高分辨率设置";
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Enabled = false;
            this.checkBox8.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox8.Location = new System.Drawing.Point(18, 102);
            this.checkBox8.Margin = new System.Windows.Forms.Padding(6);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(203, 39);
            this.checkBox8.TabIndex = 142;
            this.checkBox8.Text = "自动完成任务";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label62.Location = new System.Drawing.Point(163, 212);
            this.label62.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(93, 35);
            this.label62.TabIndex = 141;
            this.label62.Text = "未获取";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label63.Location = new System.Drawing.Point(12, 212);
            this.label63.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(119, 35);
            this.label63.TabIndex = 140;
            this.label63.Text = "游戏句柄";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button5.Location = new System.Drawing.Point(152, 158);
            this.button5.Margin = new System.Windows.Forms.Padding(6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(127, 48);
            this.button5.TabIndex = 139;
            this.button5.Text = "手动获取";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ManualSet_MouseDown);
            this.button5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ManualSet_MouseUp);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.Location = new System.Drawing.Point(12, 158);
            this.button4.Margin = new System.Windows.Forms.Padding(6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 48);
            this.button4.TabIndex = 138;
            this.button4.Text = "自动获取";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.AutoSet_Click);
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label57.Location = new System.Drawing.Point(215, 53);
            this.label57.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(41, 35);
            this.label57.TabIndex = 137;
            this.label57.Text = "秒";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox6.Location = new System.Drawing.Point(143, 46);
            this.textBox6.Margin = new System.Windows.Forms.Padding(6);
            this.textBox6.MaxLength = 3;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(60, 42);
            this.textBox6.TabIndex = 136;
            this.textBox6.Text = "200";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label55.Location = new System.Drawing.Point(12, 52);
            this.label55.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(119, 35);
            this.label55.TabIndex = 136;
            this.label55.Text = "超时时间";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.textBox9);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.label53);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.label54);
            this.groupBox2.Controls.Add(this.label52);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.label56);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(491, 12);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(398, 287);
            this.groupBox2.TabIndex = 136;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "随机因子设置";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.Location = new System.Drawing.Point(324, 151);
            this.label20.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 35);
            this.label20.TabIndex = 143;
            this.label20.Text = "秒";
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox9.Location = new System.Drawing.Point(268, 145);
            this.textBox9.Margin = new System.Windows.Forms.Padding(6);
            this.textBox9.MaxLength = 2;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(40, 42);
            this.textBox9.TabIndex = 142;
            this.textBox9.Text = "30";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label24.Location = new System.Drawing.Point(12, 158);
            this.label24.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(171, 35);
            this.label24.TabIndex = 141;
            this.label24.Text = "等待随机时间";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label53.Location = new System.Drawing.Point(324, 95);
            this.label53.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(67, 35);
            this.label53.TabIndex = 138;
            this.label53.Text = "毫秒";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox5.Location = new System.Drawing.Point(268, 89);
            this.textBox5.Margin = new System.Windows.Forms.Padding(6);
            this.textBox5.MaxLength = 2;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(40, 42);
            this.textBox5.TabIndex = 137;
            this.textBox5.Text = "50";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label54.Location = new System.Drawing.Point(12, 102);
            this.label54.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(254, 35);
            this.label54.TabIndex = 136;
            this.label54.Text = "操作随机时间<=100";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label52.Location = new System.Drawing.Point(324, 45);
            this.label52.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(67, 35);
            this.label52.TabIndex = 135;
            this.label52.Text = "像素";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox4.Location = new System.Drawing.Point(268, 39);
            this.textBox4.Margin = new System.Windows.Forms.Padding(6);
            this.textBox4.MaxLength = 1;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(40, 42);
            this.textBox4.TabIndex = 134;
            this.textBox4.Text = "5";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label56.Location = new System.Drawing.Point(12, 46);
            this.label56.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(187, 35);
            this.label56.TabIndex = 125;
            this.label56.Text = "偏移像素<=10";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label59);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.label60);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.label61);
            this.groupBox1.Controls.Add(this.checkBox7);
            this.groupBox1.Controls.Add(this.label51);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.checkBox5);
            this.groupBox1.Controls.Add(this.label50);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label49);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label48);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.label47);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(461, 287);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "自动控制";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label59.Location = new System.Drawing.Point(422, 145);
            this.label59.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(41, 35);
            this.label59.TabIndex = 141;
            this.label59.Text = "分";
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox7.Location = new System.Drawing.Point(377, 144);
            this.textBox7.Margin = new System.Windows.Forms.Padding(6);
            this.textBox7.MaxLength = 2;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(42, 42);
            this.textBox7.TabIndex = 140;
            this.textBox7.Text = "0";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label60.Location = new System.Drawing.Point(315, 146);
            this.label60.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(41, 35);
            this.label60.TabIndex = 139;
            this.label60.Text = "时";
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox8.Location = new System.Drawing.Point(255, 144);
            this.textBox8.Margin = new System.Windows.Forms.Padding(6);
            this.textBox8.MaxLength = 2;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(48, 42);
            this.textBox8.TabIndex = 138;
            this.textBox8.Text = "0";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label61.Location = new System.Drawing.Point(106, 148);
            this.label61.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(119, 35);
            this.label61.TabIndex = 137;
            this.label61.Text = "结束时间";
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox7.Location = new System.Drawing.Point(12, 146);
            this.checkBox7.Margin = new System.Windows.Forms.Padding(6);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(99, 39);
            this.checkBox7.TabIndex = 136;
            this.checkBox7.Text = "启用";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label51.Location = new System.Drawing.Point(262, 52);
            this.label51.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(41, 35);
            this.label51.TabIndex = 135;
            this.label51.Text = "分";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(208, 46);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6);
            this.textBox1.MaxLength = 2;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(40, 42);
            this.textBox1.TabIndex = 134;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox5.Location = new System.Drawing.Point(12, 190);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(6);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(229, 39);
            this.checkBox5.TabIndex = 133;
            this.checkBox5.Text = "停止后自动关机";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label50.Location = new System.Drawing.Point(422, 99);
            this.label50.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(41, 35);
            this.label50.TabIndex = 132;
            this.label50.Text = "分";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox3.Location = new System.Drawing.Point(377, 98);
            this.textBox3.Margin = new System.Windows.Forms.Padding(6);
            this.textBox3.MaxLength = 2;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(42, 42);
            this.textBox3.TabIndex = 131;
            this.textBox3.Text = "0";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label49.Location = new System.Drawing.Point(315, 100);
            this.label49.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(67, 35);
            this.label49.TabIndex = 130;
            this.label49.Text = "小时";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Location = new System.Drawing.Point(255, 98);
            this.textBox2.Margin = new System.Windows.Forms.Padding(6);
            this.textBox2.MaxLength = 2;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(48, 42);
            this.textBox2.TabIndex = 129;
            this.textBox2.Text = "0";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label48.Location = new System.Drawing.Point(106, 102);
            this.label48.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(145, 35);
            this.label48.TabIndex = 128;
            this.label48.Text = "结束倒计时";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox4.Location = new System.Drawing.Point(12, 100);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(6);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(99, 39);
            this.checkBox4.TabIndex = 127;
            this.checkBox4.Text = "启用";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label47.Location = new System.Drawing.Point(6, 52);
            this.label47.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(119, 35);
            this.label47.TabIndex = 125;
            this.label47.Text = "延迟启动";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.pictureBox1);
            this.tabPage4.Controls.Add(this.label26);
            this.tabPage4.Controls.Add(this.label25);
            this.tabPage4.Controls.Add(this.logbox1);
            this.tabPage4.Location = new System.Drawing.Point(8, 49);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage4.Size = new System.Drawing.Size(1451, 328);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "日志";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KancolleMacro_with_fiddler.Properties.Resources.pg001;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(952, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(476, 241);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(1158, 17);
            this.label26.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(281, 35);
            this.label26.TabIndex = 2;
            this.label26.Text = "制作者:闲着无聊的可乐";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(946, 17);
            this.label25.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(147, 35);
            this.label25.TabIndex = 1;
            this.label25.Text = "测试版V1.0";
            // 
            // logbox1
            // 
            this.logbox1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.logbox1.FormattingEnabled = true;
            this.logbox1.ItemHeight = 35;
            this.logbox1.Location = new System.Drawing.Point(6, 12);
            this.logbox1.Margin = new System.Windows.Forms.Padding(6);
            this.logbox1.Name = "logbox1";
            this.logbox1.Size = new System.Drawing.Size(918, 284);
            this.logbox1.TabIndex = 0;
            // 
            // fleet2timer
            // 
            this.fleet2timer.Tick += new System.EventHandler(this.fleet2timer_Tick);
            // 
            // fleet3timer
            // 
            this.fleet3timer.Tick += new System.EventHandler(this.fleet3timer_Tick);
            // 
            // fleet4timer
            // 
            this.fleet4timer.Tick += new System.EventHandler(this.fleet4timer_Tick);
            // 
            // manual
            // 
            this.manual.Tick += new System.EventHandler(this.manual_Tick);
            // 
            // SysTime
            // 
            this.SysTime.Tick += new System.EventHandler(this.SysTime_Tick);
            // 
            // Overtimer
            // 
            this.Overtimer.Tick += new System.EventHandler(this.Overtimer_Tick);
            // 
            // delaytimer
            // 
            this.delaytimer.Tick += new System.EventHandler(this.delaytimer_Tick);
            // 
            // autostop
            // 
            this.autostop.Tick += new System.EventHandler(this.autostop_Tick);
            // 
            // MainFrame
            // 
            this.ClientSize = new System.Drawing.Size(1448, 363);
            this.Controls.Add(this.tabcontrol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1474, 434);
            this.MinimumSize = new System.Drawing.Size(1474, 434);
            this.Name = "MainFrame";
            this.Text = "Kancolle";
            this.Load += new System.EventHandler(this.MainFrame_Load);
            this.tabcontrol.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label[] fleetstate;
        private System.Windows.Forms.TextBox[] Hours;
        private System.Windows.Forms.TextBox[] Mins;
        private System.Windows.Forms.TextBox[] Secs;
        private System.Windows.Forms.TextBox[] FleetExNos;
        private System.Windows.Forms.Timer[] FleetTimers;
        private System.Windows.Forms.TabControl tabcontrol;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label58;
        private Button button5;
        private Button button4;
        private Timer fleet2timer;
        private Timer fleet3timer;
        private Timer fleet4timer;
        private Timer manual;
        protected logbox logbox1;
        private Timer SysTime;
        private Label label62;
        private Label label63;
        private Label label59;
        private TextBox textBox7;
        private Label label60;
        private TextBox textBox8;
        private Label label61;
        private CheckBox checkBox7;
        private Timer Overtimer;
        private CheckBox checkBox8;
        private Timer delaytimer;
        private Timer autostop;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label65;
        private Label label66;
        private Label label67;
        private Label label68;
        private Label label69;
        private Label label70;
        private Label label71;
        private Label label20;
        private TextBox textBox9;
        private Label label24;
        private Button RestoreWindow;
        private Button HideWindow;
        private Label label26;
        private Label label25;
        private PictureBox pictureBox1;
        private TextBox textBox10;
        private Label label28;
        private TabPage tabPage4;
        private Button button8;
        private TextBox Sec3;
        private TextBox Min3;
        private TextBox Hour3;
        private TextBox Sec2;
        private TextBox Min2;
        private TextBox Hour2;
        private TextBox Sec1;
        private TextBox Min1;
        private TextBox Hour1;
        private TextBox Fleet4ExNO;
        private TextBox Fleet3ExNO;
        private TextBox Fleet2ExNO;
    }

    public class logbox : ListBox
    {
        public logbox()
        {
            this.Items = new ObjectCollection_(this);
        }

        //复写Items使其可以write
        public new ObjectCollection_ Items
        {
            get;
            set;
        }

        public class ObjectCollection_ : ObjectCollection
        {
            private ListBox listBox_ = null;

            public ObjectCollection_(ListBox listbox) : base(listbox)
            {
                this.listBox_ = listbox;
            }
            public void Insert(object item)
            {
                listBox_.Items.Insert(0, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ") + item.ToString());
                string dir = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
                File.AppendAllText(dir + "Log.txt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ") + item.ToString() + Environment.NewLine);
            }
        }
    }

}