using System;
using System.Collections.Generic;
using System.Data;
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

        public List<Entity.Bill> searchBill(int status,string date1 =null,string date2=null)
        {
            List<Entity.Bill> lst = new List<Entity.Bill>();
            
            String sql = "";
            if(status == 0)
            {
                sql = "select* from viewtblBill where sTrangthai = 1";
            }else if(status == 2)
            {
                sql = "select* from viewtblBill where sTrangthai = 1 and DAY(GETDATE()) = DAY(dThoigianthanhtoan) and MONTH(GETDATE()) = MONTH(dThoigianthanhtoan)" +
    "and YEAR(GETDATE()) = YEAR(dThoigianthanhtoan)";
            }else if(status == 1)
            {
                sql = "select * from viewtblBill where dThoigianthanhtoan between '" + date1 + "' and '" + date2 + "'";
            }
            Debug.WriteLine(sql);
            DataTable dt = conn.getTable(sql);
            foreach(DataRow item in dt.Rows)
            {
                Entity.Bill x = new Entity.Bill(
                    item["iId"].ToString(),
                    item["sName"].ToString(),
                    item["sHoten"].ToString(),
                    item["dThoigianthanhtoan"].ToString(),
                    item["sTrangthai"].ToString(),
                    item["fToongtien"].ToString()
                    );
                lst.Add(x);
            }
            return lst;

        }
        public string getTortalBill(List<Entity.Bill> lst)
        {
            return lst.Count().ToString();
        }

        public string getTortalMoneyBill(List<Entity.Bill> lst)
        {
            int ftong = 0;
            foreach (Entity.Bill item in lst)
            {
                ftong += int.Parse(item.fTortal);
            }
            return string.Format("{0:n0}", int.Parse(ftong.ToString()));
        }

        public string convertime(string time)
        {
            string[] time1 = time.Split(' ');
            time = time1[0];
            string[] tim2 = time.Split('/');
            return tim2[2] + "/" + tim2[0] + "/" + tim2[1];
        }
    }
}
