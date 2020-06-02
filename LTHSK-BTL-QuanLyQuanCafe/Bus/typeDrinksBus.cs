using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHSK_BTL_QuanLyQuanCafe.Bus
{
    class typeDrinksBus
    {
        Data.ConnecString conn = new Data.ConnecString();
        public List<Entity.typeDrinks> getListTypeDrinks()
        {
            List<Entity.typeDrinks> lst = new List<Entity.typeDrinks>();
            String sql = "select * from tblLoaidouong";
            DataTable dt = conn.getTable(sql);
            foreach (DataRow item in dt.Rows)
            {
                Entity.typeDrinks x = new Entity.typeDrinks(
                    item["iId"].ToString(),
                    item["sName"].ToString()
                );
                lst.Add(x);
            }
            return lst;

        }

        public bool insertTypeDrinks(string name)
        {
            String sql = "insert into tblLoaidouong (sName) values (N'"+name+"');";
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

        public bool removeTypeDrinks(string id)
        {
            String sql = "delete from tblLoaidouong where iId ="+id;
            Debug.WriteLine(sql);
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
