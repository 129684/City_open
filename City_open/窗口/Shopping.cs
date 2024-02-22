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
    public partial class Shopping : Form
    {
        public Shopping()
        {
            InitializeComponent();
        }
        //comboBox加载事件
        public void com()
        {
            string sql = "select * from MClass";
            DataTable dt = DBHelper.GetTable(sql);
            int x = dt.Rows.Count;
            for (int i = 0; i < x; i++)
            {
                this.comboBox1.Items.Add(dt.Rows[i]["MCalssName"].ToString());
            }
        }
        //datagridview加载
        public void GridView()
        {
            string sql = string.Format("select m.MerID,m.MerName,s.MCalssName,m.MerMoney from MClass s  join Merchandise m on s.MCalssID=m.ClassID");
            DataTable da = DBHelper.GetTable(sql);
            this.dataGridView1.DataSource = da;
        }
        private void Shopping_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Shopping_Load(object sender, EventArgs e)
        {
            com();
            GridView();
        }
        //搜索
        private void button1_Click(object sender, EventArgs e)
        {
             string c = this.comboBox1.Text;
            string sql = string.Format("select m.MerID,m.MerName,s.MCalssName,m.MerMoney from MClass s  join Merchandise m on s.MCalssID=m.ClassID where s.MCalssName='{0}'", c);
            DataTable da = DBHelper.GetTable(sql);
            if (this.comboBox1.Text == "全部商品")
            {
                GridView();
            }
            if (da.Rows.Count > 0)
            {
               
                    if (this.comboBox1.Text == da.Rows[0]["MCalssName"].ToString())
                    {
                        this.dataGridView1.DataSource = da;
                    }
            }
        }
        
        private void 加入选购列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
                int j = int.Parse(this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                string sql = string.Format("select m.MerName,s.MCalssName,m.MerMoney from MClass s  join Merchandise m on s.MCalssID=m.ClassID where m.MerID='{0}'", j);
                DataTable da = DBHelper.GetTable(sql);
                string mname = da.Rows[0]["MerName"].ToString();
                string mcname = da.Rows[0]["MCalssName"].ToString();
                string mmnoy = da.Rows[0]["MerMoney"].ToString();
                string ssql = string.Format("insert into XGlist values('{0}','{1}','{2}')",mname,mcname,mmnoy);
                if (DBHelper.ExecuteNonQuery(ssql) > 0)
                {
                    string csql = "select * from XGlist";
                    DataTable dt = DBHelper.GetTable(csql);
                    this.dataGridView2.DataSource = dt;
                    int sum = this.dataGridView2.RowCount;
                    this.textBox1.Text = sum.ToString();
                    string jsql = "select SUM(MerMoney) from XGlist";
                    //DBHelper.ExecuteScalar(jsql);
                    //double money = double.Parse(DBHelper.ExecuteScalar(jsql).ToString());
                    this.textBox2.Text = DBHelper.ExecuteScalar(jsql).ToString();
                }
                else
                {
                    MessageBox.Show("添加未成功！");
                }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string l = this.textBox1.Text;
            double  m =double.Parse( this.textBox2.Text);
                string csql =string.Format( "select * from Recharge where ReID='{0}'",DBHelper.UserID);
                DataTable dt = DBHelper.GetTable(csql);
                double ye =double.Parse( dt.Rows[0]["ReMoney"].ToString());
                if (ye > m)
                {
                    string sql = string.Format("insert Expense(UserID,Spend,ClassID) values ({0},{1},102)", DBHelper.UserID, m);
                    if (DBHelper.ExecuteNonQuery(sql) > 0)
                    {
                    MessageBox.Show("购买详情\n购买账号：" + DBHelper.UserID + "\n购买件数：" + l + "\n花费金额：" + m);
                    string up = string.Format("update  Recharge set ReMoney-={0} where ReID={1}", m, DBHelper.UserID);
                    if (DBHelper.ExecuteNonQuery(up) > 0)
                    {
                        string ssql = "delete from XGlist";
                        if(DBHelper.ExecuteNonQuery(ssql)>0)
                        {
                        MessageBox.Show("购买成功!");
                        Main z = new Main();
                        z.Show();
                        this.Hide();
                        }
                    }
                    }
                }
                else
                {
                    MessageBox.Show("余额不足，请充值后购买！");
                }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string ssql = "delete from XGlist";
            if (DBHelper.ExecuteNonQuery(ssql) > 0)
            {
                Main z = new Main();
                this.Hide();
                z.Show();
            }
        }
        //移除商品
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string sname = this.dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            string de = string.Format("delete from XGlist where MerName='{0}'",sname);
            if (DBHelper.ExecuteNonQuery(de) > 0)
            {
                string csql = "select * from XGlist";
                DataTable dt = DBHelper.GetTable(csql);
                this.dataGridView2.DataSource = dt;
                int sum = this.dataGridView2.RowCount;
                if (sum > 0)
                {
                    this.textBox1.Text = sum.ToString();
                    string jsql = "select SUM(MerMoney) from XGlist";
                    double money = double.Parse(DBHelper.ExecuteScalar(jsql).ToString());
                    this.textBox2.Text = money.ToString();
                }
                else
                {
                    MessageBox.Show("再删可就没有了呦！");
                    this.textBox1.Text = "0";
                    this.textBox2.Text = "0";

                }
            }
            else
            {
                MessageBox.Show("移除失败！");
            }
        }
        }
    }
