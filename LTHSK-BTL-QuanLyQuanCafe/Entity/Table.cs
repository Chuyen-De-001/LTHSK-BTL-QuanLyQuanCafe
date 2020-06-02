using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHSK_BTL_QuanLyQuanCafe.Entity
{
    class Table
    {
        public string id { get; set; }
        public string name { get; set; }
        public string status { get; set; }

        public Table() { }

        public Table(string ID, string NAME, string STATUS)
        {
            this.id = ID;
            this.name = NAME;
            this.status = STATUS;
        }

        public String getStatus(string status)
        {
            if (String.Compare(status, "0") == 0)
            {
                return "Trống";
            }
            return "Có người";
        }
    }
}
