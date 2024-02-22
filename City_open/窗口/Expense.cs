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
    public partial class Expense : Form
    {
        public Expense()
        {
            InitializeComponent();
        }
        //关闭
        private void Expense_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        public void jiaz()
        {
            string sqlt = string.Format("select e.ExpID,u.UserID,u.UserName,e.ExpTime,e.Spend,c.ClassName from Users u,Expense e,Calss c where u.UserID=e.UserID and e.ClassID=c.ClassID and u.UserID={0}", DBHelper.UserID);
            DataTable dt = DBHelper.GetTable(sqlt);
            this.dataGridView1.DataSource = dt;
        }
        private void Expense_Load(object sender, EventArgs e)
        {
            //类型下拉框
            string sql = "select * from Calss";
            DataTable da = DBHelper.GetTable(sql);
            int n = da.Rows.Count;
            for (int i=0; i < n;i++ )
            {
                this.comboBox1.Items.Add(da.Rows[i]["ClassName"].ToString());
            }
            jiaz();
        }
        //删除所有消费记录
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("您确定要删除所有消费记录吗？", "提示：", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                string sql = "delete from Expense where UserID=" + DBHelper.UserID;

                if (DBHelper.ExecuteNonQuery(sql) > 0)
                {
                    MessageBox.Show("删除成功！");
                    jiaz();
                }
            }
        }
        //返回主页面
        private void button4_Click(object sender, EventArgs e)
        {
            Main z = new Main();
            this.Hide();
            z.Show();
        }
        //按类型查询
        private void button1_Click(object sender, EventArgs e)
        {
            string c = this.comboBox1.Text;
            string sqlt = string.Format("select e.ExpID,u.UserID,u.UserName,e.ExpTime,e.Spend,c.ClassName from Users u,Expense e,Calss c where u.UserID=e.UserID and e.ClassID=c.ClassID and u.UserID={0} and c.ClassName='{1}'", DBHelper.UserID,c);
            DataTable dt = DBHelper.GetTable(sqlt);
            if (dt.Rows.Count > 0)
            {
                if (this.comboBox1.Text == "")
                {
                    jiaz();
                }
                else
                {
                    this.dataGridView1.DataSource = dt;
                }
            }
            else
            {
                MessageBox.Show("此类型暂时没有消费记录！");
            }
        }
        //删除所查记录
        private void button2_Click(object sender, EventArgs e)
        {
             DialogResult re = MessageBox.Show("您确定要删除此类型消费记录吗？", "提示：", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
             if (re == DialogResult.Yes)
             {
                 string c = this.comboBox1.Text;
                 string de = string.Format("delete from Expense where ClassID=(select ClassID from Calss where ClassName='{0}')", c);
                 if (DBHelper.ExecuteNonQuery(de) > 0)
                 {
                     MessageBox.Show("删除此类型成功！");
                     jiaz();
                 }
             }
        }
        //一条记录删除
        private void 删除此条记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int s =int.Parse( this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            string c = string.Format("select * from Expense where ExpID={0}",s);
            DataTable dt = DBHelper.GetTable(c);
            if (dt.Rows.Count == 1)
            {
                string d = string.Format("delete Expense where ExpID={0}",s);
                if (DBHelper.ExecuteNonQuery(d) == 1)
                {
                    MessageBox.Show("删除成功！");
                    jiaz();
                }
            }
            else
            {
                MessageBox.Show("删除有误！");
            }
        }
    }
}
