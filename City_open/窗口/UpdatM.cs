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
    public partial class UpdatM : Form
    {
        public UpdatM()
        {
            InitializeComponent();
        }
        int i = Management.i;
        //窗体加载
        private void UpdatM_Load(object sender, EventArgs e)
        {
            string sql = string.Format("select * from Merchandise where MerID={0}",i);
            SqlDataReader sdr = DBHelper.GetRea(sql);
            while (sdr.Read())
            {
                this.wate1.Text = sdr["MerName"].ToString();
                this.wate2.Text = sdr["ClassID"].ToString();
                this.wate3.Text = sdr["MerMoney"].ToString();
            }
            sdr.Close();
        }
        //修改按钮
        private void button1_Click(object sender, EventArgs e)
        {
            string sql = string.Format("update Merchandise set MerName='{0}',ClassID={1},MerMoney={2} where MerID={3}",wate1.Text,wate2.Text,wate3.Text,i);
            if (DBHelper.ExecuteNonQuery(sql) > 0)
            {
                MessageBox.Show("修改成功！");
                Management d = new Management();
                this.Hide();
                d.Show();
            }
            else
            {
                MessageBox.Show("修改失败！请检查！");
 
            }
        }

        private void wate2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')//允许输入退格键
            {
                if (e.KeyChar < '0' || e.KeyChar > '9')//允许输入0-9数字
                {
                    e.Handled = true;
                }
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

        private void UpdatM_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
