using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace City_open
{
    class DBHelper
    {
        //修改内容
        public static string name;
        public static string zid;
        public static string call;
        public static string six;
        public static string yaer;
        public static string add;
        //登录账号
        public static int UserID;
        public static string Start;
        public static string Stop;
        public static string m;
        //连接字符串
        public static string Sqlstr = "Data Source=.;Initial Catalog=City_open;Integrated Security=True";
            /// <summary>        
        /// 执行增删改        
        /// </summary>        
        /// <param name="mySql">mysql语句</param>        
        /// <returns>影响的行数 int</returns>
        public static int ExecuteNonQuery(string sql)
        {
            using (SqlConnection conn = new SqlConnection(Sqlstr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                return cmd.ExecuteNonQuery();
            }
        }
        /// <summary>
        /// 执行查询
        /// </summary>
        /// <param name="mySql">mysql语句</param>
        /// <returns>DataTable</returns>
        public static DataTable GetTable(string sql)
        {
            SqlConnection conn = new SqlConnection(Sqlstr);
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        /// <summary>
        /// 执行聚合函数
        /// </summary>
        /// <param name="mySql">mysql语句</param>
        /// <returns>一行一列的值 object</returns>
        public static object ExecuteScalar(string sql)
        {
            using (SqlConnection conn = new SqlConnection(Sqlstr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                return cmd.ExecuteScalar();
            }
        }
        /// <summary>
        /// 查询list view适配器
        /// </summary>
        /// <param name="sql"></param>
        /// <returns>返回一个读取器</returns>
        public static SqlDataReader GetRea(string sql)
        {
            SqlConnection conn = new SqlConnection(Sqlstr);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql,conn);
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }
    }
}
