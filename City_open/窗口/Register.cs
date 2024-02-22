using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace City_open
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        //窗口关闭
        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        //账号框只能输入数字
        private void ID_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')//允许输入退格键
            {
                if (e.KeyChar < '0' || e.KeyChar > '9')//允许输入0-9数字
                {
                    e.Handled = true;
                }
            }
        }
        //账号框只能输入数字
        private void Call_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')//允许输入退格键
            {
                if (e.KeyChar < '0' || e.KeyChar > '9')//允许输入0-9数字
                {
                    e.Handled = true;
                }
            }
        }
        //取消
        private void esc_b_Click(object sender, EventArgs e)
        {
            UserLogin s = new UserLogin();
            s.Show();
            this.Hide();
        }
        //确认按钮
        private void Re_b_Click(object sender, EventArgs e)
        {
            //账号生成随机9位数账号
            int userID = int.Parse(new Random().Next(111111111, 999999999).ToString());
            //实例化姓名文本框
            string UserName = this.Name_text.Text;
            //实例化证件号文本框
            string IDText = this.ID_text.Text;
            //实例化电话文本框
            string Call = this.Call_text.Text;
            //密码文本框
            string Userpwd = this.pws_text.Text;
            //确认密码文本框
            string Rpwe = this.tpwd_text.Text;
            //地址文本框
            string add = this.add_text.Text;
            //性别判断
            string Gender = "";
            if (this.man.Checked)
                Gender = this.man.Text;
            if (this.nv.Checked)
                Gender = this.nv.Text;
            //生日
           string Bri= this.Time.Value.ToString();
            //非空验证
            string sql = string.Format("select * from Users where UserID={0}",userID);
             DataTable dt=DBHelper.GetTable(sql);
            if (dt.Rows.Count>0)
            {
                MessageBox.Show("系统繁忙！请重试！");
            }
            else
            {
                if (UserName == "" || IDText == "" || Userpwd == "" || Rpwe == "")
                {
                    MessageBox.Show("必填信息不允许为空！");
                }
                else
                {
                    //密码判断
                    if (Userpwd == Rpwe)
                    {
                        string sqlty = string.Format("insert into Users(UserID,UserName,Six,Userpwd,Birthday,Cell,[ID number],[address]) values ({0},'{1}','{2}','{3}','{4}','{5}','{6}','{7}')", userID, UserName, Gender, Userpwd, Bri, Call, IDText, add);
                        if (DBHelper.ExecuteNonQuery(sqlty) > 0)
                        {
                            string s = string.Format("insert into Recharge(ReID,ReMoney) values({0},100)", userID);
                            if(DBHelper.ExecuteNonQuery(s)>0)
                            {
                            MessageBox.Show("注册成功！\n您的账号为：" + userID);
                            UserLogin d = new UserLogin();
                            d.Show();
                            this.Hide();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("两次输入密码不一致，请检查！");
                    }
                }
            }
        }

    }
}
