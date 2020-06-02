using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTHSK_BTL_QuanLyQuanCafe
{
    public partial class Main : Form
    {
        Bus.UserBus userBus = new Bus.UserBus();
        Bus.typeDrinksBus typeDrinksBus = new Bus.typeDrinksBus();
        Bus.TableBus tableBus = new Bus.TableBus();
        Bus.DrinksBus drinksBus = new Bus.DrinksBus();
        Bus.BillBus billBus = new Bus.BillBus();
        Bus.BillinforBus billinforBus = new Bus.BillinforBus();
        int bill_id = -1;

        Functions functions = new Functions();
        List<Button> lst_button = new List<Button>();

        public Main()
        {
            InitializeComponent();
        }
        Entity.User user = new Entity.User();
        public Main(int id)
        {
            InitializeComponent();
            user = userBus.getUser(id.ToString());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            txtNameUser.Text = user.sHoten;
            if(user.iType_user == "0")
            {
                quảnLýToolStripMenuItem.Visible = false;
            }
            LoadTable();
            LoadCombox();
        }

        public void LoadTable()
        {
            List<Entity.Table> lst_table = tableBus.getListTable();
            Debug.WriteLine(lst_table.Count);
            int i = 0;
            foreach (Entity.Table item in lst_table)
            {
                Button btn = new Button() { Width = 80, Height = 80 };
                //this.button1.Click += new System.EventHandler(this.button1_Click_1);
                btn.Click += btn_click;
                //btn.Tag = item.id;
                btn.Name = item.id;
                if (String.Compare(item.status, "Có người") == 0)
                {
                    btn.Text = item.name + "\n Có người";
                    btn.BackColor = System.Drawing.Color.Yellow;
                }
                else
                {
                    btn.Text = item.name + "\n Trống";
                    btn.BackColor = System.Drawing.Color.Green;
                }
                lst_button.Add(btn);
                //flp_dsban.Controls.Add(btn);
            }
            foreach(Button item in lst_button)
            {
                flp_dsban.Controls.Add(item);
            }
        }
        public void LoadCombox()
        {
            Entity.typeDrinks x = new Entity.typeDrinks("0", "Tất cả đồ uống");
            comboBox_typeDrink.DisplayMember = "sName";
            comboBox_typeDrink.ValueMember = "iId";
            List<Entity.typeDrinks> lsttypeDrinks = typeDrinksBus.getListTypeDrinks();
            lsttypeDrinks.Add(x);

            comboBox_typeDrink.DataSource = lsttypeDrinks;
            comboBox_typeDrink.SelectedValue = "0";
            numericUpDown_soluong.Value = 1;

            combox_drinks.DataSource = drinksBus.getListDrinks();
            combox_drinks.DisplayMember = "sTendouong";
            combox_drinks.ValueMember = "iId";
        }




        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fUser fUser = new fUser("view",user.iId);
            fUser.Show();
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fManage manage = new fManage();
            manage.Show();
        }

        public void btn_click(object sender, EventArgs e)
        {
            //lst_button[1].BackColor = System.Drawing.Color.Yellow;
            lab_chooseTable.Text = (sender as Button).Name;
            String id_table = (sender as Button).Name;
            bill_id = int.Parse(billBus.getBill_id(id_table));
            Load_viewBill_Infor(bill_id);
        }
        public void Load_viewBill_Infor(int bill_id)
        {
            List<Entity.Billinfor> lst = new List<Entity.Billinfor>();
            if (bill_id > 0)
            {
                lst = billinforBus.getListBillinfor(bill_id.ToString());
                dataGridView_listChiTietHD.DataSource = lst;
            }
            else
            {
                dataGridView_listChiTietHD.DataSource = new List<Entity.Billinfor>();
            }
            float tortal = 0;
            foreach (Entity.Billinfor item in lst)
            {
                tortal += int.Parse(item.iSoluong) * int.Parse(item.fDongia.Replace(",", ""));
            }
            txt_tortal_payment.Text = string.Format("{0:n0}", int.Parse(tortal.ToString())) + " VNĐ";
        }

        private void comboBox_typeDrink_TextChanged(object sender, EventArgs e)
        {
            if (comboBox_typeDrink.SelectedValue.ToString() == "0")
            {
                combox_drinks.DataSource = drinksBus.getListDrinks();
            }
            else
            {
                combox_drinks.DataSource = drinksBus.getListDrinksbyType(comboBox_typeDrink.SelectedValue.ToString());
            }
        }

        private void ttn_datmon_Click(object sender, EventArgs e)
        {
            string id_table = lab_chooseTable.Text;
            if (id_table == "null")
            {
                MessageBox.Show("Bạn chưa chọn bàn.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                functions.orderDrinks(id_table, combox_drinks.SelectedValue.ToString(), user.iId, numericUpDown_soluong.Value.ToString());
                bill_id = int.Parse(billBus.getBill_id(id_table));
                //MessageBox.Show(bill_id.ToString());
                if (bill_id > 0)
                {
                    int index = lst_button.FindIndex(a => a.Name == id_table);
                    lst_button[index].BackColor = System.Drawing.Color.Yellow;
                    Load_viewBill_Infor(bill_id);
                }
                else
                {
                    //btn_refesh_Click(sender, e);
                }


            }
        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            string[] arrayTortal = txt_tortal_payment.Text.Split(' ');
            string id_table  = lab_chooseTable.Text;
            int index = lst_button.FindIndex(a => a.Name == id_table);
            if (lst_button[index].BackColor == System.Drawing.Color.Yellow)
            {
                if (MessageBox.Show("Có muốn in hóa đơn?", "Quesion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    /*                functions.payment_bill(bill_id.ToString(), id_table, arrayTortal[0].Replace(",", ""));
                                    MessageBox.Show("Thanh toán thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    int index = lst_button.FindIndex(a => a.Name == id_table);
                                    string[] statustable = lst_button[index].Text.Split('\n');
                                    lst_button[index].BackColor = System.Drawing.Color.Green;
                                    lst_button[index].Text = statustable[0] + "\n" + "Trống";

                                    Reports.fReport fReport = new Reports.fReport(bill_id.ToString());
                                    fReport.Show();

                                    Load_viewBill_Infor(bill_id);
                                    lab_chooseTable.Text = "null";*/
                    //Reports.fReports reports = new Reports.fReports(bill_id.ToString());
                    //reports.Show();
                    Reports.fReport fReport = new Reports.fReport(bill_id.ToString());
                    fReport.Show();
                }
                else
                {
                    functions.payment_bill(bill_id.ToString(), id_table, arrayTortal[0].Replace(",", ""));
                    MessageBox.Show("Thanh toán thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //btn_refesh_Click(sender, e);

                    string[] statustable = lst_button[index].Text.Split('\n');
                    lst_button[index].BackColor = System.Drawing.Color.Green;
                    lst_button[index].Text = statustable[0] + "\n" + "Trống";

                    Load_viewBill_Infor(bill_id);
                    lab_chooseTable.Text = "null";

                }
            }
            else
            {
                MessageBox.Show("Bàn vẫn trống, không thể thanh toán.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
