using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHSK_BTL_QuanLyQuanCafe.Entity
{
    class Drinks
    {
        public string iId { get; set; }
        public string sTendouong { get; set; }
        public string sLoaidouong { get; set; }
        public string fDongia { get; set; }

        public Drinks() { }

        public Drinks(string id, string name, string type, string price)
        {
            this.iId = id;
            this.sTendouong = name;
            this.sLoaidouong = type;
            this.fDongia = price;
        }
    }
}
