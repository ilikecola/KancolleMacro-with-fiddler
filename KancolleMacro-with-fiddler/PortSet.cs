using System;
using System.Configuration;
using System.Windows.Forms;

namespace KancolleMacro_with_fiddler
{
    public partial class PortSet : Form
    {
        private int listenport = 0;
        private int upstreamport = 0;

        public PortSet()
        {
            InitializeComponent();
            this.listenportbox.Text= ConfigurationManager.AppSettings["listenPort"].ToString();
            this.upstreamportbox.Text = ConfigurationManager.AppSettings["upstreamPort"].ToString();
        }

        private void PortChange(object sender, System.EventArgs e)
        {
            var textbox = sender as TextBox;
            textbox.ReadOnly = false;
        }

        private void PortSet_FormClosed(object sender, FormClosedEventArgs e)
        {
            listenport = Int32.Parse(this.listenportbox.Text);
            upstreamport = Int32.Parse(this.upstreamportbox.Text);
        }

        public int[] check()
        {
            int[] check = new int[2];
            check[0] = listenport;
            check[1] = upstreamport;
            return check;
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

        private void LimitedTextRange(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox != null)
            {
                if (textBox.Name.Length > 6 && textBox.Name.Remove(6, 7).Equals("listen"))
                {
                    int value;
                    if (int.TryParse(textBox.Text, out value))
                    {
                        if (value > 65535 || value < 0)
                        {
                            textBox.Text = ConfigurationManager.AppSettings["listenPort"].ToString();
                        }
                    }
                }else
                {
                    int value;
                    if (int.TryParse(textBox.Text, out value))
                    {
                        if (value > 65535 || value < 0)
                        {
                            textBox.Text = ConfigurationManager.AppSettings["upstreamPort"].ToString();
                        }
                    }
                }
            }

            }
    }
}
