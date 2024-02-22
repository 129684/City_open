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
    public partial class Findpwd : Form
    {
        public Findpwd()
        {
            InitializeComponent();
        }
        //窗口关闭
        private void Findpwd_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
       //确认按钮
        private void ent_b_Click(object sender, EventArgs e)
        {
            //姓名
            string name = this.Name_text.Text;
            //证件号
            string  Zid = this.ID_text.Text;
            //密码
            string pwd = this.pwd_text.Text;
            //确认密码
            string qpwd = this.tpwd_text.Text;
            //非空验证
            if (name == "" || Zid == "")
            {
                MessageBox.Show("请填入你的账号信息！");
            }
            else
            {
                //两次密码验证
                if (pwd != qpwd)
                {
                    MessageBox.Show("两次输入密码不一致，请重新输入！");
                }
                else
                {
                    //用户信息查询
                    string sql = string.Format("select * from Users where [ID number]='{0}' and UserName='{1}'", Zid, name);
                    DataTable dt = DBHelper.GetTable(sql);
                    if (dt.Rows.Count > 0)
                    {
                        string sqlty = string.Format("update Users set Userpwd='{0}'where [ID number]='{1}'", pwd, Zid);
                        if (DBHelper.ExecuteNonQuery(sqlty) > 0)
                        {
                            MessageBox.Show("密码修改成功！");
                            UserLogin d = new UserLogin();
                            d.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("查无此用户！");
                    }
                }
            }
        }
        //取消按钮
        private void esc_b_Click(object sender, EventArgs e)
        {
            UserLogin s = new UserLogin();
            s.Show();
            this.Hide();
        }
    }
}
