﻿using System;
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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }
        //窗口关闭
        private void Reports_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int userID = int.Parse(new Random().Next(111111111, 999999999).ToString());
            string id=this.id.Text;
            string zhang = this.Zid.Text;
            string call = this.call.Text;
            string pwd = this.pwd.Text;
            string sql = string.Format("select * from Users where UserID={0}",id);
            DataTable da=DBHelper.GetTable(sql);
            if (da.Rows.Count > 0)
            {
                string sql1 = string.Format("select * from Users where [ID number]='{0}'",zhang);
                DataTable dt = DBHelper.GetTable(sql1);
                if(dt.Rows.Count>0)
                {
                    string sql2 = string.Format("select * from Users where Userpwd='{0}'",pwd);
                    DataTable ta = DBHelper.GetTable(sql2);
                    if (ta.Rows.Count > 0)
                    {
                        string sqlty = string.Format("update Users set UserID={0} where UserID='{1}'",userID,id);
                        if(DBHelper.ExecuteNonQuery(sqlty)>0)
                        {
                            DBHelper.UserID = userID;
                            MessageBox.Show("操作成功！\n您的新账号为："+userID);
                            Main z = new Main();
                            this.Hide();
                            z.Show();

                        }
                    }
                    else
                    {
                        MessageBox.Show("密码输入错误！");
                    }
                }
                else
                {
                    MessageBox.Show("证件号不匹配！");
                }
            }
            else
            {
                MessageBox.Show("查无此用户！");
            }
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            this.id.Text = DBHelper.UserID.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main z = new Main();
            this.Hide();
            z.Show();

        }
    }
}
  