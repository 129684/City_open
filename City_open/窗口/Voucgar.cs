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
    public partial class Voucgar : Form
    {
        public Voucgar()
        {
            InitializeComponent();
        }

        private void Voucgar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        //输入数字
        private void CID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')//允许输入退格键
            {
                if (e.KeyChar < '0' || e.KeyChar > '9')//允许输入0-9数字
                {
                    e.Handled = true;
                }
            }
        }
        //输入数字
        private void cMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')//允许输入退格键
            {
                if (e.KeyChar < '0' || e.KeyChar > '9')//允许输入0-9数字
                {
                    e.Handled = true;
                }
            }
        }
        //取消键
        private void EscB_Click(object sender, EventArgs e)
        {
            MessageBox.Show("您取消充值！");
            Main z = new Main();
            this.Hide();
            z.Show();
        }
        //确认键
        private void entB_Click(object sender, EventArgs e)
        {
            string n = CID.Text;
            double m =double.Parse( cMoney.Text+".00");
            if (n == "" || m == 0)
            {
                MessageBox.Show("请输入所要充值的帐户或金额！");
            }
            else
            {
                //查询帐户是否存在
                string sql = string.Format("select * from Users u join Recharge r on u.UserID=r.ReID where u.UserID={0}",n);
                DataTable dt = DBHelper.GetTable(sql);
                if (dt.Rows.Count > 0)
                {
                    //查询金额的值
                    string cup = string.Format("select top 1 r.ReMoney from Users u join Recharge r on u.UserID=r.ReID where u.UserID={0} order by r.ReMoney desc",n);
                    DataTable da = DBHelper.GetTable(cup);
                    if(da.Rows.Count>0)
                    {
                        //提取金额的值
                        double zhuan = m +double.Parse( da.Rows[0][0].ToString());
                        //添加新的充值信息
                        string up = string.Format("insert into Recharge(ReID,ReMoney,money) values({0},{1},{2})",n,zhuan,m);
                        if(DBHelper.ExecuteNonQuery(up)>0)
                        {
                            //删除一起余额信息
                            string de = string.Format("delete from Recharge where ReMoney=(select top 1  ReMoney from  Recharge order by ReMoney) and ReID={0}",n);
                            if(DBHelper.ExecuteNonQuery(de)>0)
                            {
                        MessageBox.Show("充值成功！\n您的现余额为："+zhuan+"元");
                        Main z = new Main();
                        this.Hide();
                        z.Show();
                            }
                        }
                    }
                       
                }
                else
                {
                    MessageBox.Show("不存在此用户！");
                }
            }
        }
        //30
        private void button1_Click(object sender, EventArgs e)
        {
            string t1 = this.button1.Text;
            cMoney.Text = t1;
        }
        //50
        private void button2_Click(object sender, EventArgs e)
        {
            string t1 = this.button2.Text;
            cMoney.Text = t1;
        }
        //100
        private void button3_Click(object sender, EventArgs e)
        {
            string t1 = this.button3.Text;
            cMoney.Text = t1;
        }
        //150
        private void button4_Click(object sender, EventArgs e)
        {
            string t1 = this.button4.Text;
            cMoney.Text = t1;
        }
        //200
        private void button5_Click(object sender, EventArgs e)
        {
            string t1 = this.button5.Text;
            cMoney.Text = t1;
        }
        //300
        private void button6_Click(object sender, EventArgs e)
        {
            string t1 = this.button6.Text;
            cMoney.Text = t1;
        }
        //400
        private void button7_Click(object sender, EventArgs e)
        {
            string t1 = this.button7.Text;
            cMoney.Text = t1;
        }
        //500
        private void button8_Click(object sender, EventArgs e)
        {
            string t1 = this.button8.Text;
            cMoney.Text = t1;
        }
    }
}
