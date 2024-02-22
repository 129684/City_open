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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }
        //返回登录通道窗口
        private void esc_p_Click(object sender, EventArgs e)
        {
            Channel s = new Channel();
            s.Show();
            this.Hide();
        }
        //窗口关闭
        private void AdminLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Loginbot_Click(object sender, EventArgs e)
        {
            //账号输入
           string userID = this.ID_text.Text;
            //密码输入
            string userpwd = this.pwd_text.Text;
            //判断是否为空
            if (userID == "" && userpwd == "")
            {
                MessageBox.Show("请输入您的账号或密码！");
            }
            else
            {
                //执行查询
                string sql = string.Format("select * from [Admin] where AdminID='{0}' and Adminpwd='{1}'", userID, userpwd);
                DataTable dt = DBHelper.GetTable(sql);
                //返回结果
                //int i = dt.Rows.Count;
                if (dt.Rows.Count > 0)
                {
                    //登录成功
                    MessageBox.Show("登录成功！");
                    //转窗体
                    Management d = new Management();
                    d.Show();
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
