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
    public partial class Management : Form
    {
        public Management()
        {
            InitializeComponent();
        }
        public static int R;
        public static int i;
        //关闭
        private void Management_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        //地铁一号线单击事件
        private void line1_Click(object sender, EventArgs e)
        {
            R = 1;
            string sql = string.Format("select * from LineOne");
            DataTable da = DBHelper.GetTable(sql);
            this.t1.Text = da.Rows[0]["lineNmae"].ToString();
            this.t2.Text = da.Rows[1]["lineNmae"].ToString();
            this.t3.Text = da.Rows[2]["lineNmae"].ToString();
            this.t4.Text = da.Rows[3]["lineNmae"].ToString();
            this.t5.Text = da.Rows[4]["lineNmae"].ToString();
            this.t6.Text = da.Rows[5]["lineNmae"].ToString();
            this.t7.Text = da.Rows[6]["lineNmae"].ToString();
            this.t8.Text = da.Rows[7]["lineNmae"].ToString();
            this.t9.Text = da.Rows[8]["lineNmae"].ToString();
            this.t10.Text = da.Rows[9]["lineNmae"].ToString();
            this.t11.Text = da.Rows[10]["lineNmae"].ToString();
            this.t12.Text = da.Rows[11]["lineNmae"].ToString();
        }
        //地铁二号线单击事件
        private void line2_Click(object sender, EventArgs e)
        {
            R = 2;
            string sql = string.Format("select * from LineTwo");
            DataTable da = DBHelper.GetTable(sql);
            this.t1.Text = da.Rows[0]["lineNmae"].ToString();
            this.t2.Text = da.Rows[1]["lineNmae"].ToString();
            this.t3.Text = da.Rows[2]["lineNmae"].ToString();
            this.t4.Text = da.Rows[3]["lineNmae"].ToString();
            this.t5.Text = da.Rows[4]["lineNmae"].ToString();
            this.t6.Text = da.Rows[5]["lineNmae"].ToString();
            this.t7.Text = da.Rows[6]["lineNmae"].ToString();
            this.t8.Text = da.Rows[7]["lineNmae"].ToString();
            this.t9.Text = da.Rows[8]["lineNmae"].ToString();
            this.t10.Text = da.Rows[9]["lineNmae"].ToString();
            this.t11.Text = da.Rows[10]["lineNmae"].ToString();
            this.t12.Text = da.Rows[11]["lineNmae"].ToString();
        }
        //地铁三号线单击事件
        private void line3_Click(object sender, EventArgs e)
        {
            R = 3;
            string sql = string.Format("select * from LineThree");
            DataTable da = DBHelper.GetTable(sql);
            this.t1.Text = da.Rows[0]["lineNmae"].ToString();
            this.t2.Text = da.Rows[1]["lineNmae"].ToString();
            this.t3.Text = da.Rows[2]["lineNmae"].ToString();
            this.t4.Text = da.Rows[3]["lineNmae"].ToString();
            this.t5.Text = da.Rows[4]["lineNmae"].ToString();
            this.t6.Text = da.Rows[5]["lineNmae"].ToString();
            this.t7.Text = da.Rows[6]["lineNmae"].ToString();
            this.t8.Text = da.Rows[7]["lineNmae"].ToString();
            this.t9.Text = da.Rows[8]["lineNmae"].ToString();
            this.t10.Text = da.Rows[9]["lineNmae"].ToString();
            this.t11.Text = da.Rows[10]["lineNmae"].ToString();
            this.t12.Text = da.Rows[11]["lineNmae"].ToString();
        }
        //三号线
        private void ent_b_Click(object sender, EventArgs e)
        {
            if(R==1)
            {
                string y1 = this.t1.Text;
                string y2 = this.t2.Text;
                string y3 = this.t3.Text;
                string y4 = this.t4.Text;
                string y5 = this.t5.Text;
                string y6 = this.t6.Text;
                string y7 = this.t7.Text;
                string y8 = this.t8.Text;
                string y9 = this.t9.Text;
                string y10 = this.t10.Text;
                string y11 = this.t11.Text;
                string y12 = this.t12.Text;
                string sql1 = string.Format("update LineOne set lineNmae='{0}'where lineID=1", y1);
                string sql2 = string.Format("update LineOne set lineNmae='{0}'where lineID=2", y2);
                string sql3 = string.Format("update LineOne set lineNmae='{0}'where lineID=3", y3);
                string sql4 = string.Format("update LineOne set lineNmae='{0}'where lineID=4", y4);
                string sql5 = string.Format("update LineOne set lineNmae='{0}'where lineID=5", y5);
                string sql6 = string.Format("update LineOne set lineNmae='{0}'where lineID=6", y6);
                string sql7 = string.Format("update LineOne set lineNmae='{0}'where lineID=7", y7);
                string sql8 = string.Format("update LineOne set lineNmae='{0}'where lineID=8", y8);
                string sql9 = string.Format("update LineOne set lineNmae='{0}'where lineID=9", y9);
                string sql10 = string.Format("update LineOne set lineNmae='{0}'where lineID=10", y10);
                string sql11 = string.Format("update LineOne set lineNmae='{0}'where lineID=11", y11);
                string sql12 = string.Format("update LineOne set lineNmae='{0}'where lineID=12", y12);
                if (DBHelper.ExecuteNonQuery(sql1) > 0 && DBHelper.ExecuteNonQuery(sql2) > 0 && DBHelper.ExecuteNonQuery(sql3) > 0 && DBHelper.ExecuteNonQuery(sql4) > 0 && DBHelper.ExecuteNonQuery(sql5) > 0 && DBHelper.ExecuteNonQuery(sql6) > 0 && DBHelper.ExecuteNonQuery(sql7) > 0 && DBHelper.ExecuteNonQuery(sql8) > 0 && DBHelper.ExecuteNonQuery(sql9) > 0 && DBHelper.ExecuteNonQuery(sql10) > 0 && DBHelper.ExecuteNonQuery(sql11) > 0 && DBHelper.ExecuteNonQuery(sql12) > 0)
                {
                    MessageBox.Show("一号线更改成功！");
                }
            }
            if (R == 2)
            {
                string y1 = this.t1.Text;
                string y2 = this.t2.Text;
                string y3 = this.t3.Text;
                string y4 = this.t4.Text;
                string y5 = this.t5.Text;
                string y6 = this.t6.Text;
                string y7 = this.t7.Text;
                string y8 = this.t8.Text;
                string y9 = this.t9.Text;
                string y10 = this.t10.Text;
                string y11 = this.t11.Text;
                string y12 = this.t12.Text;
                string sql1 = string.Format("update LineTwo set lineNmae='{0}'where lineID=1", y1);
                string sql2 = string.Format("update LineTwo set lineNmae='{0}'where lineID=2", y2);
                string sql3 = string.Format("update LineTwo set lineNmae='{0}'where lineID=3", y3);
                string sql4 = string.Format("update LineTwo set lineNmae='{0}'where lineID=4", y4);
                string sql5 = string.Format("update LineTwo set lineNmae='{0}'where lineID=5", y5);
                string sql6 = string.Format("update LineTwo set lineNmae='{0}'where lineID=6", y6);
                string sql7 = string.Format("update LineTwo set lineNmae='{0}'where lineID=7", y7);
                string sql8 = string.Format("update LineTwo set lineNmae='{0}'where lineID=8", y8);
                string sql9 = string.Format("update LineTwo set lineNmae='{0}'where lineID=9", y9);
                string sql10 = string.Format("update LineTwo set lineNmae='{0}'where lineID=10", y10);
                string sql11 = string.Format("update LineTwo set lineNmae='{0}'where lineID=11", y11);
                string sql12 = string.Format("update LineTwo set lineNmae='{0}'where lineID=12", y12);
                if (DBHelper.ExecuteNonQuery(sql1) > 0 && DBHelper.ExecuteNonQuery(sql2) > 0 && DBHelper.ExecuteNonQuery(sql3) > 0 && DBHelper.ExecuteNonQuery(sql4) > 0 && DBHelper.ExecuteNonQuery(sql5) > 0 && DBHelper.ExecuteNonQuery(sql6) > 0 && DBHelper.ExecuteNonQuery(sql7) > 0 && DBHelper.ExecuteNonQuery(sql8) > 0 && DBHelper.ExecuteNonQuery(sql9) > 0 && DBHelper.ExecuteNonQuery(sql10) > 0 && DBHelper.ExecuteNonQuery(sql11) > 0 && DBHelper.ExecuteNonQuery(sql12) > 0)
                {
                    MessageBox.Show("二号线更改成功！");
                } 
            }
            if (R == 3)
            {
                string y1 = this.t1.Text;
                string y2 = this.t2.Text;
                string y3 = this.t3.Text;
                string y4 = this.t4.Text;
                string y5 = this.t5.Text;
                string y6 = this.t6.Text;
                string y7 = this.t7.Text;
                string y8 = this.t8.Text;
                string y9 = this.t9.Text;
                string y10 = this.t10.Text;
                string y11 = this.t11.Text;
                string y12 = this.t12.Text;
                string sql1 = string.Format("update LineThree set lineNmae='{0}'where lineID=1", y1);
                string sql2 = string.Format("update LineThree set lineNmae='{0}'where lineID=2", y2);
                string sql3 = string.Format("update LineThree set lineNmae='{0}'where lineID=3", y3);
                string sql4 = string.Format("update LineThree set lineNmae='{0}'where lineID=4", y4);
                string sql5 = string.Format("update LineThree set lineNmae='{0}'where lineID=5", y5);
                string sql6 = string.Format("update LineThree set lineNmae='{0}'where lineID=6", y6);
                string sql7 = string.Format("update LineThree set lineNmae='{0}'where lineID=7", y7);
                string sql8 = string.Format("update LineThree set lineNmae='{0}'where lineID=8", y8);
                string sql9 = string.Format("update LineThree set lineNmae='{0}'where lineID=9", y9);
                string sql10 = string.Format("update LineThree set lineNmae='{0}'where lineID=10", y10);
                string sql11 = string.Format("update LineThree set lineNmae='{0}'where lineID=11", y11);
                string sql12 = string.Format("update LineThree set lineNmae='{0}'where lineID=12", y12);
                if (DBHelper.ExecuteNonQuery(sql1) > 0 && DBHelper.ExecuteNonQuery(sql2) > 0 && DBHelper.ExecuteNonQuery(sql3) > 0 && DBHelper.ExecuteNonQuery(sql4) > 0 && DBHelper.ExecuteNonQuery(sql5) > 0 && DBHelper.ExecuteNonQuery(sql6) > 0 && DBHelper.ExecuteNonQuery(sql7) > 0 && DBHelper.ExecuteNonQuery(sql8) > 0 && DBHelper.ExecuteNonQuery(sql9) > 0 && DBHelper.ExecuteNonQuery(sql10) > 0 && DBHelper.ExecuteNonQuery(sql11) > 0 && DBHelper.ExecuteNonQuery(sql12) > 0)
                {
                    MessageBox.Show("三号线更改成功！");
                } 
            }
        }
        //comboBox加载事件
        public void com()
        {
            string sql = "select * from MClass";
            DataTable dt = DBHelper.GetTable(sql);
            int x=dt.Rows.Count;
            for (int i=0; i < x;i++ )
            {
                this.comboBox1.Items.Add(dt.Rows[i]["MCalssName"].ToString());
            }
        }
        public void GridView()
        {
            string sql = string.Format("select m.MerID,m.MerName,m.ClassID,s.MCalssName,m.MerMoney from MClass s  join Merchandise m on s.MCalssID=m.ClassID");
            DataTable da =DBHelper.GetTable(sql);
            this.dataGridView1.DataSource = da;
        }
        //窗口加载事件
        private void Management_Load(object sender, EventArgs e)
        {
            com();
            GridView();
        }
        //添加类型
        private void tc_b_Click(object sender, EventArgs e)
        {
            TianjiaClass t = new TianjiaClass();
            t.Show();
        }
        //添加商品
        private void tm_b_Click(object sender, EventArgs e)
        {
            TianjiaM t = new TianjiaM();
            t.Show();
        }
        //删除商品
        private void d_b_Click(object sender, EventArgs e)
        {
            i = int.Parse(this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            string sql = string.Format("delete from Merchandise where MerID={0} ",i);
            if (DBHelper.ExecuteNonQuery(sql) > 0)
            {
                MessageBox.Show("删除成功！");
                GridView();
            }
            else
            {
                MessageBox.Show("删除有误！");
            }
        }
        //搜索
        private void button1_Click(object sender, EventArgs e)
        {
            string c = this.comboBox1.Text;
            string sql = string.Format("select m.MerID,m.MerName,m.ClassID,s.MCalssName,m.MerMoney from MClass s  join Merchandise m on s.MCalssID=m.ClassID where s.MCalssName='{0}'", c);
            DataTable da = DBHelper.GetTable(sql);

            if (da.Rows.Count > 0)
            {
                if (this.comboBox1.Text == "")
                {
                    GridView();
                }
                if (this.comboBox1.Text == da.Rows[0]["MCalssName"].ToString())
                {
                    this.dataGridView1.DataSource = da;
                }
            }
            else
            {
                MessageBox.Show("暂时没有此类型商品！");
            }
        }

        private void x_b_Click(object sender, EventArgs e)
        {
            i = int.Parse(this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            UpdatM up = new UpdatM();
            up.Show();
        }
        private void label15_Click(object sender, EventArgs e)
        {
            Channel xiao = new Channel();
            this.Hide();
            xiao.Show();
        }
        //用户投诉
        private void button2_Click(object sender, EventArgs e)
        {
            Tsrxp z = new Tsrxp();
            this.Hide();
            z.Show();
        }
    }
}
