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
    public partial class upUser : Form
    {
        public upUser()
        {
            InitializeComponent();
        }
        //窗口关闭
        private void UserMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void upUser_Load(object sender, EventArgs e)
        {
            string sql = string.Format("select * from Users where UserID={0}",DBHelper.UserID);
            DataTable dt = DBHelper.GetTable(sql);
            this.miz.Text = dt.Rows[0]["UserName"].ToString();
            this.imetID.Text = dt.Rows[0]["ID number"].ToString();
            this.call.Text = dt.Rows[0]["Cell"].ToString();
            if (dt.Rows[0]["Six"].ToString() == "男")
            {
                this.man.Checked = true;
            }
            if (dt.Rows[0]["Six"].ToString() == "女")
            {
                this.nv.Checked = true;
            }
            this.Time.Value = DateTime.Parse(dt.Rows[0]["Birthday"].ToString());
            this.add.Text = dt.Rows[0]["address"].ToString();
        }
        //确认修改
        private void button1_Click(object sender, EventArgs e)
        {
            DBHelper.name = this.miz.Text;
            DBHelper.zid = this.imetID.Text;
            DBHelper.call = this.call.Text;
            if(this.man.Checked)
            {
                DBHelper.six = this.man.Text;
            }
            if(this.nv.Checked)
            {
                DBHelper.six = this.nv.Text;
            }
            DBHelper.yaer = this.Time.Value.ToString();
            DBHelper.add = this.add.Text;
            Userpwd z = new Userpwd();
            this.Hide();
            z.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main z = new Main();
            this.Hide();
            z.Show();
        }
    }
}
