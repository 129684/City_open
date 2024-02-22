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
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }
        //窗口关闭
        private void UserLogin_FormClosing(object sender, FormClosingEventArgs e)
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
        //注册按钮
        private void regbut_Click(object sender, EventArgs e)
        {
            Register s = new Register();
            s.Show();
            this.Hide();
        }
        //找回密码
        private void zhbut_Click(object sender, EventArgs e)
        {
            Findpwd s = new Findpwd();
            s.Show();
            this.Hide();
        }
        //返回按钮
        private void esc_p_Click(object sender, EventArgs e)
        {
            Channel s = new Channel();
            s.Show();
            this.Hide();
        }
        //登录按钮
        private void Loginbot_Click(object sender, EventArgs e)
        {
            //账号输入
            string ID = this.ID_text.Text;
           
            //密码输入
            string userpwd = this.pwd_text.Text;
            //判断是否为空
            if (ID== "" && userpwd == "")
            {
                MessageBox.Show("请输入您的账号或密码！");
            }
            else
            {
                int userID = int.Parse(ID);
                //执行查询
                string sql = string.Format("select * from Users where UserID={0} and Userpwd='{1}'", userID, userpwd);
                DataTable dt = DBHelper.GetTable(sql);
                //返回结果
                //int i = dt.Rows.Count;
                if (dt.Rows.Count > 0)
                {
                    //把登陆ID保存到类变量中
                    DBHelper.UserID = userID;
                    //登录成功
                    MessageBox.Show("登录成功！");
                    //转窗体
                    Main t = new Main();
                    t.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("账号密码有误！", "登录失败：", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
