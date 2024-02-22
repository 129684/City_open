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
    public partial class Complain : Form
    {
        public Complain()
        {
            InitializeComponent();
        }
        //关闭
        private void Complain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main z = new Main();
            this.Hide();
            z.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.comboBox1.Text=="交通消费")
            {
                string sql = string.Format("insert Complain values('{0}','101','{1}')",this.textBox1.Text,this.wate1.Text);
                if (DBHelper.ExecuteNonQuery(sql) > 0)
                {
                    MessageBox.Show("感谢你的投诉，我们会多加改进！");
                    Main z = new Main();
                    this.Hide();
                    z.Show();
                }

            }
            if (this.comboBox1.Text == "购物消费")
            {
            string sql = string.Format("insert Complain values('{0}','102','{1}')",this.textBox1.Text,this.wate1.Text);
            if (DBHelper.ExecuteNonQuery(sql) > 0)
            {
                MessageBox.Show("感谢你的投诉，我们会多加改进！");
                Main z = new Main();
                this.Hide();
                z.Show();
            }
            }

        }
        //加载
        private void Complain_Load(object sender, EventArgs e)
        {
            this.textBox1.Text = DBHelper.UserID.ToString();
        }
    }
}
