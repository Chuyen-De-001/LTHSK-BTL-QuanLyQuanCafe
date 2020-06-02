using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHSK_BTL_QuanLyQuanCafe.Bus
{
    class BillBus
    {
        Data.ConnecString conn = new Data.ConnecString();

       public bool insertBill(string userid, string tableid)
        {
            string sql = "insert into tblHoadon (sMaNV, sMaban,dThoigianthanhtoan,sTrangthai,fToongtien) values(" + userid + "," + tableid + ",GETDATE(),0,0)";
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

        public string getBill_id(string table_id)
        {
            string sql = "select iId from tblHoadon where sMaban = " + table_id + " and sTrangthai like '0'";
            try
            {
                return conn.ExecuteScalar(sql);
            }
            catch (Exception exp)
            {
                return "-1";
            }
        }

        public bool updateBillStatus(string tortal,string bill_id)
        {
            string sql = "update tblHoadon set sTrangthai = 1, fToongtien = " + tortal + " where iId =" + bill_id;
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
