using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTHSK_BTL_QuanLyQuanCafe.Reports
{
    public partial class fReport : Form
    {
        string bill = "";
        string status = null;
        string date1 = null;
        string date2 = null;
        Data.ConnecString conn = new Data.ConnecString();
        Bus.BillinforBus billinforBus = new Bus.BillinforBus();
        Bus.BillBus billBus = new Bus.BillBus();
        String sql = "";

        public fReport()
        {
        }

        public fReport(string rbill_id = null,string rstatus = null,string rdate1=null,string rdate2=null)
        {
            //status = 0 tất cả hóa đơn.
            //status = 1 hiện theo khoảng thời gian
            //status = 2 hiên hóa đơn ngày hôm nay.
            InitializeComponent();

            bill = rbill_id;
            status = rstatus;
            date1 = rdate1;
            date2 = rdate2;

        }

        private void fReport_Load(object sender, EventArgs e)
        {
            String sql = "";
            if(status == null)
            {
                sql = "select * from dbo.viewRepostBill where bill_id = " + bill;
                CrystalReport1 crystalReport = new CrystalReport1();
                crystalReport.SetDataSource(conn.getTable(sql));
                crystalReportViewer1.ReportSource = crystalReport;
            }
            else
            {
                if(status == "0")
                {
                    sql = "select* from viewtblBill where sTrangthai = 1";
                }else if( status == "1")
                {
                    sql = "select * from viewtblBill where dThoigianthanhtoan between '" + date1 + "' and '" + date2 + "'";
                }else if(status == "2")
                {
                    sql = "select* from viewtblBill where sTrangthai = 1 and DAY(GETDATE()) = DAY(dThoigianthanhtoan) and MONTH(GETDATE()) = MONTH(dThoigianthanhtoan)" +
"and YEAR(GETDATE()) = YEAR(dThoigianthanhtoan)";
                }
                CrystalReport_0 crystalReport_0 = new CrystalReport_0();
                crystalReport_0.SetDataSource(conn.getTable(sql));
                crystalReportViewer1.ReportSource = crystalReport_0;

            }

        }
    }
}
