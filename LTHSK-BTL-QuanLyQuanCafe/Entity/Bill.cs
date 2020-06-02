using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHSK_BTL_QuanLyQuanCafe.Entity
{
    class Bill
    {
        public string id { get; set; }
        public string table_id { get; set; }
        public string user_id { get; set; }

        public string dTime { get; set; }
        public string status { get; set; }
        public string fTortal { get; set; }

        public Bill() { }
        public Bill(string id, string table_id, string user_id, string dTime, string status, string fTortal)
        {
            this.id = id;
            this.table_id = table_id;
            this.user_id = user_id;
            this.dTime = dTime;
            this.status = status;
            this.fTortal = fTortal;
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
