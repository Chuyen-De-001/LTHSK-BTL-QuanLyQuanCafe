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
    public partial class fManage : Form
    {
        String id = "-1";
        Bus.UserBus userBus = new Bus.UserBus();
        Bus.typeDrinksBus typeDrinksBus = new Bus.typeDrinksBus();
        Bus.DrinksBus drinksBus = new Bus.DrinksBus();
        Bus.TableBus tableBus = new Bus.TableBus();
        Bus.BillBus billBus = new Bus.BillBus();
        Functions functions = new Functions();
        
       
        public fManage()
        {
            InitializeComponent();
        }

        private void fManage_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            Load_tabNhanVien();
            Load_tabtypeDrink();
            Load_tabMenu();
            Load_tabTable();
            Load_tbaBill(0);

        }
        #region Methoad

        public void Load_tbaBill(int status,string date1=null,string date2=null)
        {
            comboBox_thongke_hoadon_tab4.SelectedItem = "Thống kế tất cả hóa đơn";
            List<Entity.Bill> lst_bill = billBus.searchBill(status,date1,date2);
            dataGridView_listBill_tab4.DataSource = lst_bill;
            lab_fTongHD_tab4.Text = billBus.getTortalBill(lst_bill);
            lab_ftongtien_tab4.Text = billBus.getTortalMoneyBill(lst_bill);
            DisableTabThongke();
            Debug.WriteLine(date1);
        }
        public void Load_tabNhanVien()
        {
            List<Entity.User> tab1_lst = userBus.getListUser();
            tab1_dtgirldview_dsNv.DataSource = tab1_lst;
        }
        public void Load_tabtypeDrink()
        {
            List<Entity.typeDrinks> lst_tab22 = typeDrinksBus.getListTypeDrinks();
            dataGridView_listTypeDrinks_tab22.DataSource = lst_tab22;
        }

        public void Load_tabTable()
        {
            List<Entity.Table> lst_Table_tab3 = tableBus.getListTable();
            dataGridView_listTable_tab3.DataSource = lst_Table_tab3;
        }

        public void Load_tabMenu()
        {
            comboBox_typeDrinks_tab21.DisplayMember = "sName";
            comboBox_typeDrinks_tab21.ValueMember = "iId";
            comboBox_typeDrinks_tab21.DataSource = typeDrinksBus.getListTypeDrinks();
            comboBox_typeDrinks_tab21.SelectedItem = null;
            List<Entity.Drinks> lst_Menu_tab21 = drinksBus.getListDrinks();
            dataGridView_drinks_tab21.DataSource = lst_Menu_tab21;

        }
        private void fUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Load_tabNhanVien();
        }
        private string getSearchby()
        {
            string searchby = "";
            if (comboBox1.SelectedItem.ToString() == "Tìm theo tên")
            {
                searchby = "sHoten";
            }
            else if (comboBox1.SelectedItem.ToString() == "Tìm theo mã nhân viên")
            {
                searchby = "Iid";
            }
            else if (comboBox1.SelectedItem.ToString() == "Tìm theo giới tính")
            {
                searchby = "sGioitinh";
            }
            else if (comboBox1.SelectedItem.ToString() == "Tìm theo địa chỉ")
            {
                searchby = "sDiaChi";
            }

            return searchby;
        }
        public void DisableTabThongke()
        {
            label13.Visible = false;
            label14.Visible = false;
            dateTimePicker_thongke_to_tab4.Visible = false;
            dateTimePicker_thongke_to1_tab4.Visible = false;
        }
        public void EnableTabThongke()
        {
            label13.Visible = true;
            label14.Visible = true;
            dateTimePicker_thongke_to_tab4.Visible = true;
            dateTimePicker_thongke_to1_tab4.Visible = true;
        }
        #endregion



        private void tab1_btn_them_Click(object sender, EventArgs e)
        {
            fUser fUser = new fUser("create", "-1"); //-1 == k truyền.
            fUser.FormClosing += new FormClosingEventHandler(this.fUser_FormClosing);
            fUser.Show();
        }



        private void tab1_dtgirldview_dsNv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = tab1_dtgirldview_dsNv.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void tab1_btn_xoa_Click(object sender, EventArgs e)
        {
            if (id != "-1")
            {
                if(MessageBox.Show("Bạn có muốn xóa nhân viên?","Xóa nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    userBus.removeUser(id);
                    id = "-1";
                    Load_tabNhanVien();
                    
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn nhân viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tab1_btn_sua_Click(object sender, EventArgs e)
        {
            if(id == "-1")
            {
                MessageBox.Show("Bạn chưa chọn nhân viên.","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                fUser fUser = new fUser("edit", id);
                fUser.FormClosing += new FormClosingEventHandler(this.fUser_FormClosing);
                fUser.Show();
            }

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (functions.checkEmpty(txt_search.Text))
            {
                tab1_dtgirldview_dsNv.DataSource = userBus.search(txt_search.Text, getSearchby());
            }
            else
            {
                MessageBox.Show("Phải nhập từ khóa để tìm kiếm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_them_2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_listTypeDrinks_tab22_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dataGridView_listTypeDrinks_tab22.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_namTypeDrink_tab22.Text = dataGridView_listTypeDrinks_tab22.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btn_them_tab22_Click(object sender, EventArgs e)
        {
            if (functions.checkEmpty(txt_namTypeDrink_tab22.Text)){
                if (typeDrinksBus.insertTypeDrinks(txt_namTypeDrink_tab22.Text)){
                    MessageBox.Show("Thêm thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    id = "-1";
                    Load_tabtypeDrink();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if(id != "-1")
            {
                if (typeDrinksBus.removeTypeDrinks(id))
                {
                    MessageBox.Show("Xóa thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    id = "-1";
                    Load_tabtypeDrink();
                }
                else
                {

                    MessageBox.Show("Xóa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView_drinks_tab21_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dataGridView_drinks_tab21.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_ten_tab21.Text = dataGridView_drinks_tab21.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_gia_tab21.Text = dataGridView_drinks_tab21.Rows[e.RowIndex].Cells[3].Value.ToString();
            comboBox_typeDrinks_tab21.Text = dataGridView_drinks_tab21.Rows[e.RowIndex].Cells[2].Value.ToString();

        }

        private void btn_them_tab21_Click(object sender, EventArgs e)
        {
            if (functions.checkEmpty(txt_ten_tab21.Text) && functions.checkEmpty(comboBox_typeDrinks_tab21.SelectedValue.ToString()) && functions.checkEmpty(txt_gia_tab21.Text))
            {

                if (drinksBus.insertDrinks(txt_ten_tab21.Text, comboBox_typeDrinks_tab21.SelectedValue.ToString(), txt_gia_tab21.Text.Replace(",", "")))
                {
                    MessageBox.Show("Thêm thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Load_tabMenu();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_xoa_tab21_Click(object sender, EventArgs e)
        {
            if (id != "-1")
            {
                if (drinksBus.removeDrinks(id))
                {
                    MessageBox.Show("Xóa thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    id = "-1";
                    Load_tabMenu();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_sua_tab21_Click(object sender, EventArgs e)
        {
            if (functions.checkEmpty(txt_ten_tab21.Text) && functions.checkEmpty(comboBox_typeDrinks_tab21.SelectedValue.ToString()) && functions.checkEmpty(txt_gia_tab21.Text))
            {
                if(id != "-1")
                {
                    if (drinksBus.updateDrink(id,txt_ten_tab21.Text, comboBox_typeDrinks_tab21.SelectedValue.ToString(), txt_gia_tab21.Text.Replace(",", "")))
                    {
                        MessageBox.Show("Sửa thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        id = "-1";
                        Load_tabMenu();
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btn_xoa_4_Click(object sender, EventArgs e)
        {
            if (id != "-1")
            {
                if (tableBus.removeTable(id))
                {
                    MessageBox.Show("Xóa bàn thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    id = "-1";
                    Load_tabTable();
                }
                else
                {
                    MessageBox.Show("Xóa bàn thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_them_4_Click(object sender, EventArgs e)
        {
            string name ="Bàn "+ (dataGridView_listTable_tab3.Rows.Count + 1).ToString();
            if (tableBus.insertTable(name))
            {
                MessageBox.Show("Thêm bàn thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Load_tabTable();
            }
            else
            {
                MessageBox.Show("Thêm bàn thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_listTable_tab3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dataGridView_listTable_tab3.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_thongke_hoadon_tab4_TextChanged(object sender, EventArgs e)
        {
            if (comboBox_thongke_hoadon_tab4.SelectedItem.ToString() == "Thống kê theo thời gian")
            {
                EnableTabThongke();

            }
            else
            {
                DisableTabThongke();
            }
        }

        private void btn_thongke_tab4_Click(object sender, EventArgs e)
        {
            int status = 0;
            if (comboBox_thongke_hoadon_tab4.SelectedItem.ToString() == "Thống kê theo thời gian")
            {
                status = 1;
            }
            else if (comboBox_thongke_hoadon_tab4.SelectedItem.ToString() == "Thống kê ngày hôm nay")
            {
                status = 2;
            }
            if (status == 1)
            {
                if (new Entity.Bill().convertime(dateTimePicker_thongke_to_tab4.Value.ToString()) == new Entity.Bill().convertime(dateTimePicker_thongke_to1_tab4.Value.ToString()))
                {
                    MessageBox.Show("Chưa chọn khoảng thời gian", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            Load_tbaBill(status, new Entity.Bill().convertime(dateTimePicker_thongke_to_tab4.Value.ToString()), new Entity.Bill().convertime(dateTimePicker_thongke_to1_tab4.Value.ToString()));

            
        }
    }
}
