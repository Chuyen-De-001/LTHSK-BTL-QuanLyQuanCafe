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
        Data.ConnecString conn = new Data.ConnecString();
        Bus.BillinforBus billinforBus = new Bus.BillinforBus();

        public fReport()
        {
        }

        public fReport(string bill_id)
        {
            InitializeComponent();
            bill = bill_id;
        }

        private void fReport_Load(object sender, EventArgs e)
        {
            String sql = "select * from dbo.viewRepostBill where bill_id = " + bill;
            CrystalReport1 crystalReport = new CrystalReport1();
            crystalReport.SetDataSource(conn.getTable(sql));
            crystalReportViewer1.ReportSource = crystalReport;
        }
    }
}
