using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHSK_BTL_QuanLyQuanCafe.Bus
{
    class UserBus
    {
        Data.ConnecString conn = new Data.ConnecString();
        public int doLogin(string user, string pass)
        {
            string sql = "Select * from tblUser where sUsername like '" + user + "' and sPassword like '" + pass + "'";
            DataTable dt = conn.getTable(sql);
            if(dt.Rows.Count > 0)
            {
                return int.Parse(dt.Rows[0]["iId"].ToString());
            }
            else
            {
                return -1;
            }
        }

        public Entity.User getUser(string id)
        {
            Entity.User user = new Entity.User();
            DataTable dt = new DataTable();
            string sql = "Select * from tblUser where iId="+id;
            Debug.WriteLine(sql);
            dt = conn.getTable(sql);
            if (dt.Rows.Count > 0)
            {
                user = new Entity.User(
                    dt.Rows[0]["iId"].ToString(),
                    dt.Rows[0]["sHoten"].ToString(),
                    dt.Rows[0]["sGioitinh"].ToString(),
                    dt.Rows[0]["iType_user"].ToString(),
                    dt.Rows[0]["iSdt"].ToString(),
                    new Entity.User().converdate(dt.Rows[0]["dNgaysinh"].ToString()),
                    dt.Rows[0]["iCMND"].ToString(),
                    dt.Rows[0]["sUsername"].ToString(),
                    dt.Rows[0]["sPassword"].ToString(),
                    dt.Rows[0]["sDiaChi"].ToString());
            }
            return user;
        }

        public List<Entity.User> getListUser()
        {
            List<Entity.User> lst = new List<Entity.User>();
            String sql = "select * from tblUser";
            DataTable dt = new Data.ConnecString().getTable(sql);
            foreach (DataRow item in dt.Rows)
            {
                Entity.User x = new Entity.User(
                    item["iId"].ToString(),
                    item["sHoten"].ToString(),
                    item["sGioitinh"].ToString(),
                    item["iType_user"].ToString(),
                    item["iSdt"].ToString(),
                    new Entity.User().converdate(item["dNgaysinh"].ToString()),
                    item["iCMND"].ToString(),
                    item["sUsername"].ToString(),
                    item["sPassword"].ToString(),
                    item["sDiaChi"].ToString()
                );
                lst.Add(x);
            }
            return lst;
        }

        public bool insertUser(string sHoten, string sGioitinh, string iType_user, string iSdt, string dNgaysinh, string iCMND, string sUsername, string sPassword, string sDiachi)
        {
            string sql = "insert into tblUser(sHoten,sGioitinh,iType_user,iSdt,dNgaysinh,iCMND,sUsername,sPassword,sDiaChi) values" +
                "(N'" + sHoten + "', N'" + sGioitinh + "', " + iType_user + ", '" + iSdt + "', '" + dNgaysinh + "', '" + iCMND + "', N'" + sUsername + "', N'" + sPassword + "', N'" + sDiachi + "')";
            try
            {
                conn.ExcuteNonQuery(sql);
                return true;
            }
            catch(Exception exp)
            {
                return false;
            }
        }

        public bool updateUser(string id,string sHoten, string sGioitinh, string iType_user, string iSdt, string dNgaysinh, string iCMND, string sUsername, string sPassword, string sDiachi)
        {
            string sql = "update tblUser set sHoten=N'" + sHoten + "', sGioitinh=N'" + sGioitinh + "',iType_user = " + iType_user + "," +
                    " dNgaysinh = '" + dNgaysinh + "',iCMND ='" + iCMND + "' ,sUsername ='" + sUsername + "',sPassword='" + sPassword + "',sDiachi='" + sDiachi + "' where iId =" + id;
            try
            {
                conn.ExcuteNonQuery(sql);
                return true;
            }
            catch (Exception exp)
            {
                Debug.WriteLine(exp.ToString());
                return false;
            }
        }

        public bool updateUserPass(String id, String pass)
        {
            string sql = "update tblUser set sPassword = '" + pass + "' where iId = " + id;
            try{
                conn.ExcuteNonQuery(sql);
                return true;
            }
            catch(Exception exp)
            {
                Debug.WriteLine(exp.ToString());
                return false;
            } 
        }

        public bool removeUser(string id)
        {
            string sql = "delete from tblUser where iId =" + id;
            try
            {
                conn.ExcuteNonQuery(sql);
                return true;
            }
            catch (Exception exp)
            {
                Debug.WriteLine(exp.ToString());
                return false;
            }
        }
        public DataTable search(string value, string serachby)
        {
            DataTable dt = new DataTable();
            string sql = "Select * from tblUser where " + serachby + " like N'%" + value + "%'";
            dt = conn.getTable(sql);
            return dt;
        }
    }
}
