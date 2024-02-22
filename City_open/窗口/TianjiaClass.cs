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
    public partial class TianjiaClass : Form
    {
        public TianjiaClass()
        {
            InitializeComponent();
        }
        //关闭
        private void TianjiaClass_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name =this.CalssName.Text;
            if(name=="")
            {
                MessageBox.Show("请输入正确的值！");
            }
            string sql = string.Format("insert into MClass(MCalssName) values('{0}')",name);
            if(DBHelper.ExecuteNonQuery(sql)>0)
            {
                MessageBox.Show("添加商品类型成功！");
                Management t = new Management();
                t.Show();
                this.Hide();
            }
        }
    }
}
