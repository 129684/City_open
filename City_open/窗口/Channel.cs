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
    public partial class Channel : Form
    {
        public Channel()
        {
            InitializeComponent();
        }
        //窗口关闭
        private void Channel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void User_b_Click(object sender, EventArgs e)
        {
            UserLogin u = new UserLogin();
            u.Show();
            this.Hide();
        }

        private void Admin_b_Click(object sender, EventArgs e)
        {
            AdminLogin s = new AdminLogin();
            s.Show();
            this.Hide();
        }
    }
}
