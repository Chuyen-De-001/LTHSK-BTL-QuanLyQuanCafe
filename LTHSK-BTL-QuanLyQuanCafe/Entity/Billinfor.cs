using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHSK_BTL_QuanLyQuanCafe.Entity
{
    class Billinfor
    {
        public string id { get; set; }
        public string sTendouong { get; set; }
        public string iSoluong { get; set; }
        public string fDongia { get; set; }
        public string sMaHD { get; set; }

        public Billinfor() { }

        public Billinfor(string id, string name, string count, string price, string bill_id)
        {
            this.id = id;
            this.sTendouong = name;
            this.iSoluong = count;
            this.fDongia = price;
            this.sMaHD = bill_id;
        }
    }
}
