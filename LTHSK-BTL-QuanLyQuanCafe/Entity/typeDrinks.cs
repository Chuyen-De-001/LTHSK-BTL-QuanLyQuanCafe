using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHSK_BTL_QuanLyQuanCafe.Entity
{
    class typeDrinks
    {
        public string iId { get; set; }
        public string sName { get; set; }

        public typeDrinks() { }

        public typeDrinks(string id, string name)
        {
            this.iId = id;
            this.sName = name;
        }
    }
}
