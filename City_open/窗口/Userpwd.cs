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
    public partial class Userpwd : Form
    {
        public Userpwd()
        {
            InitializeComponent();
        }
        //关闭窗口
        private void Userpwd_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = string.Format("select * from Users where UserID={0} and Userpwd='{1}'",DBHelper.UserID,this.textBox1.Text);
            DataTable da = DBHelper.GetTable(sql);
            if (da.Rows.Count > 0)
            {
                string sqlu = string.Format("update Users set UserName='{0}',Six='{1}',Birthday='{2}',Cell='{3}',[ID number]='{4}',address='{5}' where UserID='{6}'", DBHelper.name, DBHelper.six, DBHelper.yaer, DBHelper.call, DBHelper.zid, DBHelper.add, DBHelper.UserID);
                if (DBHelper.ExecuteNonQuery(sqlu) > 0)
                {
                    MessageBox.Show("修改成功！");
                    Main z = new Main();
                    this.Hide();
                    z.Show();
                }
            }
            else
            {
                MessageBox.Show("密码验证失败！");
                upUser u = new upUser();
                this.Hide();
                u.Show();
            }
        }
    }
}
