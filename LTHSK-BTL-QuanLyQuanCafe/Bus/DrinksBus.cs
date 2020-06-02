using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHSK_BTL_QuanLyQuanCafe.Bus
{
    class DrinksBus
    {
        Data.ConnecString conn = new Data.ConnecString();
        public List<Entity.Drinks> getListDrinks()
        {
            List<Entity.Drinks> lst = new List<Entity.Drinks>();
            DataTable dt = conn.getTable("select * from tblMenu");
            foreach (DataRow item in dt.Rows)
            {
                Entity.Drinks x = new Entity.Drinks(
                    item["iId"].ToString(),
                    item["sTendouong"].ToString(),
                    getTypeDrinks(item["sLoaidouong"].ToString()),
                    string.Format("{0:n0}", int.Parse(item["fDongia"].ToString()))
                );
                lst.Add(x);
            }
            return lst;
        }

        public List<Entity.Drinks> getListDrinksbyType(string typeid)
        {
            List<Entity.Drinks> lst = new List<Entity.Drinks>();
            DataTable dt = conn.getTable("select * from tblMenu where sLoaidouong = "+typeid);
            foreach (DataRow item in dt.Rows)
            {
                Entity.Drinks x = new Entity.Drinks(
                    item["iId"].ToString(),
                    item["sTendouong"].ToString(),
                    getTypeDrinks(item["sLoaidouong"].ToString()),
                    string.Format("{0:n0}", int.Parse(item["fDongia"].ToString()))
                );
                lst.Add(x);
            }
            return lst;
        }

        public string getTypeDrinks(string type_id)
        {
            List<Entity.typeDrinks> lst = new typeDrinksBus().getListTypeDrinks();
            foreach (Entity.typeDrinks item in lst)
            {
                if (item.iId == type_id)
                {
                    return item.sName;
                }
            }
            return "";
        }


        public bool insertDrinks(string name,String typeDrink,String fDongia)
        {
            String sql = "insert into tblMenu (sTendouong,sLoaidouong,fDongia) values(N'"+name+"',"+typeDrink+","+fDongia+")";
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

        public bool removeDrinks(string id)
        {
            String sql = "delete from tblMenu where iId = "+id;
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

        public bool updateDrink(string id, string name, string loai, string gia)
        {
            string sql = "update tblMenu set sTendouong =N'" + name + "' ,fDongia = " + gia + " ,sLoaidouong = " + loai + " where iId = " + id;
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
