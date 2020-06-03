using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHSK_BTL_QuanLyQuanCafe.Entity
{
    class User
    {
        public const int ADMIN = 1;
        public string iId { get; set; }
        public string sHoten { get; set; }
        public string sGioitinh { get; set; }
        public string iType_user { get; set; }
        public string iSdt { get; set; }
        public string dNgaysinh { get; set; }
        public string iCMND { get; set; }
        public string sUsername { get; set; }
        public string sPassword { get; set; }
        public string sDiachi { get; set; }
        public User()
        { }

        public User(string iId, string sHoten, string sGioitinh, string iType_user, string iSdt, string dNgaysinh, string iCMND, string sUsername, string sPassword, string sDiachi)
        {
            this.iId = iId;
            this.sHoten = sHoten;
            this.sGioitinh = sGioitinh;
            this.iType_user = iType_user;
            this.iSdt = iSdt;
            this.dNgaysinh = dNgaysinh;
            this.iCMND = iCMND;
            this.sUsername = sUsername;
            this.sPassword = sPassword;
            this.sDiachi = sDiachi;
        }
        public string converdate(string date)
        {

            string[] listDate = date.Split('/');
            //m/d/y
            return listDate[1] + "/" + listDate[0] + "/" + listDate[2].Substring(0, 4);
        }
    }
}
