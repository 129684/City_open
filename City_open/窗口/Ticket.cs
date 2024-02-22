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
    public partial class Ticket : Form
    {
        public Ticket()
        {
            InitializeComponent();
        }

        private void Ticket_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        //取消
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("您的行程有变！");
            BRT b = new BRT();
            this.Hide();
            b.Show();
            
        }
        //确认
        private void button1_Click(object sender, EventArgs e)
        {
            string n = "购票人：" + this.T_Name.Text;
            string m = "票额：" + this.T_Money.Text;
            string t = "购票时间：" + this.T_Time.Text;
            string S = label4.Text + this.T_Staer.Text;
            string s = label5.Text + this.T_Stop.Text;
            string csql = string.Format("select * from Recharge where ReID='{0}'", DBHelper.UserID);
            DataTable dt = DBHelper.GetTable(csql);
            double ye = double.Parse(dt.Rows[0]["ReMoney"].ToString());
            double mi = double.Parse(DBHelper.m);
            if (ye > mi)
            {
                DialogResult di = MessageBox.Show(string.Format("票据\n{0}\n{1}\n{2}\n{3}\n{4}", n, m, t, S, s));
                string sqlk = string.Format("insert into Expense (UserID,Spend,ClassID) values ({0},'{1}','101')", DBHelper.UserID, DBHelper.m);
                if (DBHelper.ExecuteNonQuery(sqlk) > 0)
                {
                    string up = string.Format("update  Recharge set ReMoney-={0} where ReID={1}", DBHelper.m, DBHelper.UserID);
                    if (DBHelper.ExecuteNonQuery(up) > 0)
                    {
                        MessageBox.Show("购票成功！\n祝您旅途愉快！");

                        Main z = new Main();

                        z.Show();
                        this.Hide();
                    }
                }

            }
            else
            {
                MessageBox.Show("余额不足，请充值后购买！");
            }
        }
        //加载事件
        private void Ticket_Load(object sender, EventArgs e)
        {
            this.T_Name.Text = DBHelper.UserID.ToString();
            this.T_Time.Text = DateTime.Now.ToString();
            this.T_Staer.Text = DBHelper.Start;
            this.T_Stop.Text = DBHelper.Stop;
            this.T_Money.Text = DBHelper.m;
        }
    }
}
