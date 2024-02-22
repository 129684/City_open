using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace City_open
{
    public partial class Main : Form
    {
        //byte变量
        byte[] imagebytes;
        public Main()
        {
            InitializeComponent();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        //二进制转化
        public byte[] GetPictureData(string imagepath)
        {
            //根据图片文件的路径使用文件流打开，并保存为byte[] 
            FileStream fs = new FileStream(imagepath, FileMode.Open);//可以是其他重载方法 
            byte[] byData = new byte[fs.Length];
            fs.Read(byData, 0, byData.Length);
            fs.Close();
            return byData;
        }
        #region MyRegion
        //二进制数据存入数据库
        public bool Getdata(string fullpath)
        {
            FileStream FS = new FileStream(fullpath, FileMode.Open);
            imagebytes = new byte[FS.Length];
            BinaryReader br = new BinaryReader(FS);
            imagebytes = br.ReadBytes(Convert.ToInt32(FS.Length));
            SqlConnection con = new SqlConnection(DBHelper.Sqlstr);
            con.Open();
            string sql = string.Format("update  Users set toplike=@ImageList where UserID={0}",DBHelper.UserID);
            SqlCommand com = new SqlCommand(sql, con);
            com.Parameters.Add("ImageList", SqlDbType.Image);
            com.Parameters["ImageList"].Value = imagebytes;
            int i = com.ExecuteNonQuery();
            con.Close();
            return i > 0;
        }
        #endregion
        //IO流
        public System.Drawing.Image ReturnPhoto(byte[] streamByte)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream(streamByte);
            System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
            return img;
        }
        //窗口加载事件
        private void Main_Load(object sender, EventArgs e)
        {
            string sql = string.Format("select top 1 u.UserID,u.UserName,u.Six,u.Birthday,u.Cell,u.[ID number],u.[address],r.ReMoney,u.toplike from Users u join Recharge r on u.UserID=r.ReID where u.UserID={0} order by r.ReMoney desc", DBHelper.UserID);
            DataTable da = DBHelper.GetTable(sql);
            this.ID.Text = da.Rows[0]["UserID"].ToString();
            this.miz.Text = da.Rows[0]["UserName"].ToString();
            this.genter.Text = da.Rows[0]["Six"].ToString();
            this.brodi.Text = da.Rows[0]["Birthday"].ToString();
            this.call.Text = da.Rows[0]["Cell"].ToString();
            this.imetID.Text = da.Rows[0]["ID number"].ToString();
            this.add.Text = da.Rows[0]["address"].ToString();
            this.Ymoney.Text = da.Rows[0]["ReMoney"].ToString();
            //判断头像字段是否为空
            if (da.Rows[0].IsNull("toplike")) //头像字段为空
            { 
                return;
            }
            else
            {
                byte[] tp = (byte[])(da.Rows[0]["toplike"]);
                MemoryStream my = new MemoryStream(tp);
                this.topimg.Image = Image.FromStream(my);
                
            }
        }
        //上传头像单击事件
        private void button2_Click(object sender, EventArgs e)
        {
            Open_DB.Filter = "*|*";
            if (Open_DB.ShowDialog() == DialogResult.OK)
            {
                string fullpath = Open_DB.FileName;//文件路径

                if (Getdata(fullpath))
                {
                   
                    topimg.Image = ReturnPhoto(imagebytes);
                    MessageBox.Show("头像上传成功！");
                }
            }
        }
        //充值按钮
        private void cmoney_Click(object sender, EventArgs e)
        {
            Voucgar z = new Voucgar();
            this.Hide();
            z.Show();
        }
        //地铁按钮
        private void sping_Click(object sender, EventArgs e)
        {
            BRT z = new BRT();
            this.Hide();
            z.Show();
        }
        //挂失补办
        private void Report_Click(object sender, EventArgs e)
        {
            Reports z = new Reports();
            this.Hide();
            z.Show();
        }
        //信息更改
        private void Information_Click(object sender, EventArgs e)
        {
            upUser u = new upUser();
            this.Hide();
            u.Show();
        }
        //消费记录
        private void ExpCar_Click(object sender, EventArgs e)
        {
            Expense z = new Expense();
            this.Hide();
            z.Show();
        }
        //投诉
        private void ts_Click(object sender, EventArgs e)
        {
            Complain z = new Complain();
            this.Hide();
            z.Show();
        }
        //超市购物
        private void spingc_Click(object sender, EventArgs e)
        {
            Shopping z = new Shopping();
            this.Hide();
            z.Show();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            Channel xiao = new Channel();
            this.Hide();
            xiao.Show();
        }
    }
}
