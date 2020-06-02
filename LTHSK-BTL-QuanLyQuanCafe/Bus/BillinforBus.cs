using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHSK_BTL_QuanLyQuanCafe.Bus
{
    class BillinforBus
    {
        Data.ConnecString conn = new Data.ConnecString();
        Bus.DrinksBus drinksBus = new Bus.DrinksBus();

        public bool insertBillinfor(string bill_id,string drinks_id,string soluong)
        {
            string sql = "insert into tblChitietHD(sMaHD,sMadouong,iSoluong) values (" + bill_id + "," + drinks_id + "," + soluong + ")";
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

        public List<Entity.Billinfor> getListBillinfor(string bill_id)
        {
            List<Entity.Billinfor> lst = new List<Entity.Billinfor>();
            string sql = "select * from viewBill_Infor where sMaHD = " + bill_id;
            DataTable dt = conn.getTable(sql);
            foreach (DataRow item in dt.Rows)
            {
                Entity.Billinfor x = new Entity.Billinfor(
                    item["iId"].ToString(),
                    item["sTendouong"].ToString(),
                    item["iSoluong"].ToString(),
                    string.Format("{0:n0}", int.Parse(item["fDongia"].ToString())),
                    item["sMaHD"].ToString()
                );
                lst.Add(x);
            }
            return lst;
        }
    }
}
