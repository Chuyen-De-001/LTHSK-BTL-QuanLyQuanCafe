using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHSK_BTL_QuanLyQuanCafe.Data
{
    class ConnecString
    {
        public SqlConnection getConnect()
        {
            String strConn = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=LTHSK-BTL-QuanLyQuanCafe;Integrated Security=True";
            return new SqlConnection(strConn);
        }
        public DataTable getTable(String sql)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = getConnect();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public void ExcuteNonQuery(String sql)
        {
            SqlConnection conn = getConnect();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            cmd.Clone();
            conn.Close();
        }
        public string ExecuteScalar(String sql)
        {
            SqlConnection conn = getConnect();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand(sql, conn);
            string id = cmd.ExecuteScalar().ToString();
            cmd.Clone();
            conn.Close();
            return id;
        }
    }
}
