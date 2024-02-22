using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace City_open
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Hide();
            this.timer1.Enabled = false;
            Channel s = new Channel();
            s.Show();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Opacity < 1)
            {
                Opacity += 0.01;
            }
            else
            {
                this.timer2.Enabled = false;
            }
        }
    }
}
