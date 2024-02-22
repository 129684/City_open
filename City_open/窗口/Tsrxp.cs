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
    public partial class Tsrxp : Form
    {
        public Tsrxp()
        {
            InitializeComponent();
        }

        private void Tsrxp_Load(object sender, EventArgs e)
        {
            de();
        }
        public void de()
        {
            string sql = string.Format("select c.UserID,a.ClassName,c.ComText from Complain c join Calss a on c.ComClass=a.ClassID");
            DataTable dt = DBHelper.GetTable(sql);
            this.dataGridView1.DataSource = dt;
            string y = string.Format("select count(*) from Complain");
            int h = int.Parse( DBHelper.ExecuteScalar(y).ToString());
            this.label1.Text = "一共有" + h + "条用户投诉内容";
        }
        //返回
        private void button4_Click(object sender, EventArgs e)
        {
            Management z = new Management();
            this.Hide();
            z.Show();
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = int.Parse(this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            string sql = string.Format("delete from Complain where UserID='{0}'", i);
            if (DBHelper.ExecuteNonQuery(sql) > 0)
            {
                MessageBox.Show("删除成功！");
                de();
            }
        }

        private void Tsrxp_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
