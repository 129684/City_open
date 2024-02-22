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
    public partial class TianjiaM : Form
    {
        public TianjiaM()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = this.wate1.Text;
            string lx = this.comboBox1.Text;
            string money = this.wate3.Text;
            //非空判断
            if (name == "" && lx == "" && money == "")
            {
                MessageBox.Show("请输入正确的值！");

            }
            else
            {
                string sql1 = string.Format("select * from MClass where MCalssName='{0}'",lx);
                DataTable da = DBHelper.GetTable(sql1);
                int cl = int.Parse(da.Rows[0]["MCalssID"].ToString());
                string sql = string.Format("insert into Merchandise(MerName,ClassID,MerMoney) values('{0}',{1},'{2}')", name, cl, money);
                if (DBHelper.ExecuteNonQuery(sql) > 0)
                {
                    MessageBox.Show("添加商品成功！");
                    Management t = new Management();
                    t.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("添加失败！请核对编号是否正确！");
                }

            }
        }
        private void TianjiaM_Load(object sender, EventArgs e)
        {
            string sql = "select * from MClass";
            DataTable dt = DBHelper.GetTable(sql);
            int x = dt.Rows.Count;
            for (int i = 0; i < x; i++)
            {
                this.comboBox1.Items.Add(dt.Rows[i]["MCalssName"].ToString());
            }
        }

        private void wate3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')//允许输入退格键
            {
                if (e.KeyChar < '0' || e.KeyChar > '9')//允许输入0-9数字
                {
                    e.Handled = true;
                }
            }
        }
    }
}
