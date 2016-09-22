using System.Configuration;

namespace KancolleMacro_with_fiddler
{
    partial class PortSet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PortSet));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listenportbox = new System.Windows.Forms.TextBox();
            this.upstreamportbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "监听端口";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "上流端口";
            // 
            // listenportbox
            // 
            this.listenportbox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.listenportbox.Location = new System.Drawing.Point(137, 21);
            this.listenportbox.Name = "listenportbox";
            this.listenportbox.ReadOnly = true;
            this.listenportbox.Size = new System.Drawing.Size(84, 42);
            this.listenportbox.TabIndex = 7;
            this.listenportbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.listenportbox.TextChanged += new System.EventHandler(this.LimitedTextRange);
            this.listenportbox.DoubleClick += new System.EventHandler(this.PortChange);
            this.listenportbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LimitedTextBox);
            // 
            // upstreamportbox
            // 
            this.upstreamportbox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.upstreamportbox.Location = new System.Drawing.Point(137, 74);
            this.upstreamportbox.Name = "upstreamportbox";
            this.upstreamportbox.ReadOnly = true;
            this.upstreamportbox.Size = new System.Drawing.Size(84, 42);
            this.upstreamportbox.TabIndex = 8;
            this.upstreamportbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.upstreamportbox.TextChanged += new System.EventHandler(this.LimitedTextRange);
            this.upstreamportbox.DoubleClick += new System.EventHandler(this.PortChange);
            this.upstreamportbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LimitedTextBox);
            // 
            // PortSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 137);
            this.Controls.Add(this.upstreamportbox);
            this.Controls.Add(this.listenportbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PortSet";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "端口设置";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PortSet_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox listenportbox;
        private System.Windows.Forms.TextBox upstreamportbox;
    }
}