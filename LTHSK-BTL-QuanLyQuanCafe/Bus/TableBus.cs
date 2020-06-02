using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHSK_BTL_QuanLyQuanCafe.Bus
{
    class TableBus
    {
        Data.ConnecString conn = new Data.ConnecString();
        
        public List<Entity.Table> getListTable()
        {
            List<Entity.Table> lst = new List<Entity.Table>();
            String sql = "select * from tblBan";
            DataTable dt = conn.getTable(sql);
            Debug.WriteLine(dt.Rows.Count);
            foreach (DataRow item in dt.Rows)
            {
                Entity.Table tb = new Entity.Table(
                   item["iId"].ToString(),
                   item["sName"].ToString(),
                   getStatus(item["sStatus"].ToString())
                   );
                lst.Add(tb);
            }
            return lst;
        }

        public bool insertTable(string name)
        {
            String sql = "insert into tblBan (sName,sStatus) values (N'"+name+"', '0');";
            try
            {
                conn.ExcuteNonQuery(sql);
                return true;
            }
            catch (Exception exp)
            {
                return false;
            }
        }

        public bool removeTable(string id)
        {
            String sql = "delete from tblBan where iId = "+id;
            try
            {
                conn.ExcuteNonQuery(sql);
                return true;
            }
            catch (Exception exp)
            {
                return false;
            }
        }
        public String getStatus(string status)
        {
            if (String.Compare(status, "0") == 0)
            {
                return "Trống";
            }
            return "Có người";
        }

        public bool updateTableStatus(string table_id,string status)
        {
            string sql = "update tblBan set sStatus = "+ status + " where iId =" + table_id;
            try
            {
                conn.ExcuteNonQuery(sql);
                return true;
            }
            catch (Exception exp)
            {
                return false;
            }
        }

    }
}
