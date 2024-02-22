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
    public partial class BRT : Form
    {
        public BRT()
        {
            InitializeComponent();
        }
        public static int R = 1;
        public static int T = 0;
        private void BRT_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        //一线金额计算
        public void Monye()
        {
            
            string sqltr = string.Format("select lineID from LineOne where lineNmae='{0}' or lineNmae='{1}'", start.Text, stop.Text);
            DataTable da=DBHelper.GetTable(sqltr);
            if(da.Rows.Count==2)
            {
                int q1 = int.Parse(da.Rows[0]["lineID"].ToString());
                int q2 = int.Parse(da.Rows[1]["lineID"].ToString());
                int q3 = q1 - q2;
                int q = Math.Abs(q3) * 2;
                this.money.Text = q.ToString();
            }
        }
        //二线金额计算
        public void Monye1()
        {
            string sqltr = string.Format("select lineID from LineTwo where lineNmae='{0}' or lineNmae='{1}'", start.Text, stop.Text);
            DataTable da = DBHelper.GetTable(sqltr);
            if (da.Rows.Count == 2)
            {
                int q1 = int.Parse(da.Rows[0]["lineID"].ToString());
                int q2 = int.Parse(da.Rows[1]["lineID"].ToString());
                int q3 = q1 - q2;
                int q = Math.Abs(q3) * 2;
                this.money.Text = q.ToString();
            }
        }
        //三线金额计算
        public void Monye2()
        {
            string sqltr = string.Format("select lineID from LineThree where lineNmae='{0}' or lineNmae='{1}'", start.Text, stop.Text);
            DataTable da = DBHelper.GetTable(sqltr);
            if (da.Rows.Count == 2)
            {
                int q1 = int.Parse(da.Rows[0]["lineID"].ToString());
                int q2 = int.Parse(da.Rows[1]["lineID"].ToString());
                int q3 = q1 - q2;
                int q = Math.Abs(q3) * 2;
                this.money.Text = q.ToString();
            }
        }
        //加载事件
        private void BRT_Load(object sender, EventArgs e)
        {
            R = 1;
            string sql = string.Format("select * from LineOne");
            DataTable da = DBHelper.GetTable(sql);
            this.b1.Text = da.Rows[0]["lineNmae"].ToString();
            this.b2.Text = da.Rows[1]["lineNmae"].ToString();
            this.b3.Text = da.Rows[2]["lineNmae"].ToString();
            this.b4.Text = da.Rows[3]["lineNmae"].ToString();
            this.b5.Text = da.Rows[4]["lineNmae"].ToString();
            this.b6.Text = da.Rows[5]["lineNmae"].ToString();
            this.b7.Text = da.Rows[6]["lineNmae"].ToString();
            this.b8.Text = da.Rows[7]["lineNmae"].ToString();
            this.b9.Text = da.Rows[8]["lineNmae"].ToString();
            this.b10.Text = da.Rows[9]["lineNmae"].ToString();
            this.b11.Text = da.Rows[10]["lineNmae"].ToString();
            this.b12.Text = da.Rows[11]["lineNmae"].ToString();
        }
        //地铁一号线单击事件
        private void button1_Click(object sender, EventArgs e)
        {
            R = 1;
            string sql = string.Format("select * from LineOne");
            DataTable da = DBHelper.GetTable(sql);
            this.b1.Text = da.Rows[0]["lineNmae"].ToString();
            this.b2.Text = da.Rows[1]["lineNmae"].ToString();
            this.b3.Text = da.Rows[2]["lineNmae"].ToString();
            this.b4.Text = da.Rows[3]["lineNmae"].ToString();
            this.b5.Text = da.Rows[4]["lineNmae"].ToString();
            this.b6.Text = da.Rows[5]["lineNmae"].ToString();
            this.b7.Text = da.Rows[6]["lineNmae"].ToString();
            this.b8.Text = da.Rows[7]["lineNmae"].ToString();
            this.b9.Text = da.Rows[8]["lineNmae"].ToString();
            this.b10.Text = da.Rows[9]["lineNmae"].ToString();
            this.b11.Text = da.Rows[10]["lineNmae"].ToString();
            this.b12.Text = da.Rows[11]["lineNmae"].ToString();
        }
        //地铁二号线单击事件
        private void button2_Click(object sender, EventArgs e)
        {
            R = 2;
            string sql = string.Format("select * from LineTwo");
            DataTable da = DBHelper.GetTable(sql);
            this.b1.Text = da.Rows[0]["lineNmae"].ToString();
            this.b2.Text = da.Rows[1]["lineNmae"].ToString();
            this.b3.Text = da.Rows[2]["lineNmae"].ToString();
            this.b4.Text = da.Rows[3]["lineNmae"].ToString();
            this.b5.Text = da.Rows[4]["lineNmae"].ToString();
            this.b6.Text = da.Rows[5]["lineNmae"].ToString();
            this.b7.Text = da.Rows[6]["lineNmae"].ToString();
            this.b8.Text = da.Rows[7]["lineNmae"].ToString();
            this.b9.Text = da.Rows[8]["lineNmae"].ToString();
            this.b10.Text = da.Rows[9]["lineNmae"].ToString();
            this.b11.Text = da.Rows[10]["lineNmae"].ToString();
            this.b12.Text = da.Rows[11]["lineNmae"].ToString();
        }
        //地铁三号线单击事件
        private void button3_Click(object sender, EventArgs e)
        {
            R = 3;
            string sql = string.Format("select * from LineThree");
            DataTable da = DBHelper.GetTable(sql);
            this.b1.Text = da.Rows[0]["lineNmae"].ToString();
            this.b2.Text = da.Rows[1]["lineNmae"].ToString();
            this.b3.Text = da.Rows[2]["lineNmae"].ToString();
            this.b4.Text = da.Rows[3]["lineNmae"].ToString();
            this.b5.Text = da.Rows[4]["lineNmae"].ToString();
            this.b6.Text = da.Rows[5]["lineNmae"].ToString();
            this.b7.Text = da.Rows[6]["lineNmae"].ToString();
            this.b8.Text = da.Rows[7]["lineNmae"].ToString();
            this.b9.Text = da.Rows[8]["lineNmae"].ToString();
            this.b10.Text = da.Rows[9]["lineNmae"].ToString();
            this.b11.Text = da.Rows[10]["lineNmae"].ToString();
            this.b12.Text = da.Rows[11]["lineNmae"].ToString();
        }
        //第一战点
        private void b1_Click(object sender, EventArgs e)
        {
            if (T == 0)
            {
                string t1 = b1.Text;
                start.Text = t1;
                T ++;
                if (R == 1)
                { Monye(); return; }
                if (R == 2)
                { Monye1(); return; }
                if (R == 3)
                { Monye2(); return; }
            }
            else
            {
                string t1 = b1.Text;
                stop.Text = t1;
                T--;
                if (R == 1)
                { Monye(); }
                if (R == 2)
                { Monye1(); }
                if (R == 3)
                { Monye2();}
            }
        }
        //2
        private void b2_Click(object sender, EventArgs e)
        {
            if (T == 0)
            {
                string t2 = b2.Text;
                start.Text = t2;
                T++;
                if (R == 1)
                { Monye(); return; }
                if (R == 2)
                { Monye1(); return; }
                if (R == 3)
                { Monye2(); return; }
            }
            else
            {
                string t2 = b2.Text;
                stop.Text = t2;
                T--;
                if (R == 1)
                { Monye(); return; }
                if (R == 2)
                { Monye1(); return; }
                if (R == 3)
                { Monye2(); return; }
            }
        }
        //3
        private void b3_Click(object sender, EventArgs e)
        {
            if (T == 0)
            {
                string t3 = b3.Text;
                start.Text = t3;
                T++;
                if (R == 1)
                { Monye(); return; }
                if (R == 2)
                { Monye1(); return; }
                if (R == 3)
                { Monye2(); return; }
            }
            else
            {
                string t3 = b3.Text;
                stop.Text = t3;
                T--;
                if (R == 1)
                { Monye(); return; }
                if (R == 2)
                { Monye1(); return; }
                if (R == 3)
                { Monye2(); return; }
            }
        }
        //4
        private void b4_Click(object sender, EventArgs e)
        {
            if (T == 0)
            {
                string t4 = b4.Text;
                start.Text = t4;
                T++;
                if (R == 1)
                { Monye(); return; }
                if (R == 2)
                { Monye1(); return; }
                if (R == 3)
                { Monye2(); return; }
            }
            else
            {
                string t4 = b4.Text;
                stop.Text = t4;
                T--;
                if (R == 1)
                { Monye(); return; }
                if (R == 2)
                { Monye1(); return; }
                if (R == 3)
                { Monye2(); return; }
            }
        }
        //5
        private void b5_Click(object sender, EventArgs e)
        {
            if (T == 0)
            {
                string t5 = b5.Text;
                start.Text = t5;
                T++;
                if (R == 1)
                { Monye(); return; }
                if (R == 2)
                { Monye1(); return; }
                if (R == 3)
                { Monye2(); return; }
            }
            else
            {
                string t5 = b5.Text;
                stop.Text = t5;
                T--;
                if (R == 1)
                { Monye(); return; }
                if (R == 2)
                { Monye1(); return; }
                if (R == 3)
                { Monye2(); return; }
            }
        }
        //6
        private void b6_Click(object sender, EventArgs e)
        {
            if (T == 0)
            {
                string t6 = b6.Text;
                start.Text = t6;
                T++;
                if (R == 1)
                { Monye(); return; }
                if (R == 2)
                { Monye1(); return; }
                if (R == 3)
                { Monye2(); return; }
            }
            else
            {
                string t6 = b6.Text;
                stop.Text = t6;
                T--;
                if (R == 1)
                { Monye(); return; }
                if (R == 2)
                { Monye1(); return; }
                if (R == 3)
                { Monye2(); return; }
            }
        }
        //7
        private void b7_Click(object sender, EventArgs e)
        {
            if (T == 0)
            {
                string t7 = b7.Text;
                start.Text = t7;
                T++;
                if (R == 1)
                { Monye(); return; }
                if (R == 2)
                { Monye1(); return; }
                if (R == 3)
                { Monye2(); return; }
            }
            else
            {
                string t7 = b7.Text;
                stop.Text = t7;
                T--;
                if (R == 1)
                { Monye(); return; }
                if (R == 2)
                { Monye1(); return; }
                if (R == 3)
                { Monye2(); return; }
            }
        }
        //8
        private void b8_Click(object sender, EventArgs e)
        {
            if (T == 0)
            {
                string t8 = b8.Text;
                start.Text = t8;
                T++;
                if (R == 1)
                { Monye(); return; }
                if (R == 2)
                { Monye1(); return; }
                if (R == 3)
                { Monye2(); return; }
            }
            else
            {
                string t8 = b8.Text;
                stop.Text = t8;
                T--;
                if (R == 1)
                { Monye(); return; }
                if (R == 2)
                { Monye1(); return; }
                if (R == 3)
                { Monye2(); return; }
            }
        }
        //9
        private void b9_Click(object sender, EventArgs e)
        {
            if (T == 0)
            {
                string t9 = b9.Text;
                start.Text = t9;
                T++;
                if (R == 1)
                { Monye(); return; }
                if (R == 2)
                { Monye1(); return; }
                if (R == 3)
                { Monye2(); return; }
            }
            else
            {
                string t9 = b9.Text;
                stop.Text = t9;
                T--;
                if (R == 1)
                { Monye(); return; }
                if (R == 2)
                { Monye1(); return; }
                if (R == 3)
                { Monye2(); return; }
            }
        }
        //10
        private void b10_Click(object sender, EventArgs e)
        {
            if (T == 0)
            {
                string t10 = b10.Text;
                start.Text = t10;
                T++;
            }
            else
            {
                string t10 = b10.Text;
                stop.Text = t10;
                T--;
                if (R == 1)
                { Monye(); return; }
                if (R == 2)
                { Monye1(); return; }
                if (R == 3)
                { Monye2(); return; }
            }
        }
        //11
        private void b11_Click(object sender, EventArgs e)
        {
            if (T == 0)
            {
                string t11 = b11.Text;
                start.Text = t11;
                T++;
            }
            else
            {
                string t11 = b11.Text;
                stop.Text = t11;
                T--;
                if (R == 1)
                { Monye(); return; }
                if (R == 2)
                { Monye1(); return; }
                if (R == 3)
                { Monye2(); return; }
            }
        }
        //12
        private void b12_Click(object sender, EventArgs e)
        {
            if (T == 0)
            {
                string t12 = b12.Text;
                start.Text = t12;
                T++;
            }
            else
            {
                string t12 = b12.Text;
                stop.Text = t12;
                T--;
                if (R == 1)
                { Monye(); return; }
                if (R == 2)
                { Monye1(); return; }
                if (R == 3)
                { Monye2(); return; }
            }
        }
        //取消
        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("你取消选择站点！");
            Main z = new Main();
            this.Hide();
            z.Show();
        }
        //确认
        private void button4_Click(object sender, EventArgs e)
        {
            if (this.start.Text != "起始站" && this.stop.Text != "终点站"&&this.stop.Text!=this.start.Text)
            {
                DBHelper.Start = start.Text;
                DBHelper.Stop = stop.Text;
                DBHelper.m = money.Text;
                Ticket gou = new Ticket();
                this.Hide();
                gou.Show();
            }
            else
            {
                MessageBox.Show("请选择正确的路线！");
            }
        }
    }
}
