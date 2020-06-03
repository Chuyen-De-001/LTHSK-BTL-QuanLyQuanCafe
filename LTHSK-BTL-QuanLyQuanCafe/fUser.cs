using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTHSK_BTL_QuanLyQuanCafe
{
    public partial class fUser : Form
    {
        String rAction = "";
        Functions functions = new Functions();
        Bus.UserBus userBus = new Bus.UserBus();
        
        Entity.User user = new Entity.User();
        public fUser()
        {
            InitializeComponent();
        }
        public fUser(String action,String id)
        {
            InitializeComponent();
            rAction = action;
            if (id != "-1")
            {
                user = new Bus.UserBus().getUser(id);
            }

        }

        private void fUser_Load(object sender, EventArgs e)
        {
            String title = "";
            if (rAction == "view")
            {
                title = "Thông tin tài khoản";
                ShowDL(user);
                disEnable();
                btnSave.Visible = false;
                btnSignUp.Visible = false;
            }
            else if (rAction == "create")
            {
                title = "Đăng kí tài khoản";

                tab2_txt_repass.Enabled = false;
                tab2_txt_pass.Enabled = false;
                tab2_btnSaveChangPass.Visible = false;
                btnSave.Visible = false;
            }
            else if (rAction == "edit")
            {

                ShowDL(user);
                title = "Sửa thông tin tài khoản";
                btnSignUp.Visible = false;
            }
            labTitle.Text = title;
            tab2_txt_User.Text = user.sUsername;

        }


        #region Method
        private void ShowDL(Entity.User user)
        {
            txt_cmnd.Text = user.iCMND;
            txt_diachi.Text = user.sDiachi;
            txt_hoten.Text = user.sHoten;
            txt_matkhau.Text = user.sPassword;
            dateTimePicker1.Text = new Entity.User().converdate(user.dNgaysinh);
            txt_sdt.Text = user.iSdt;
            txt_user.Text = user.sUsername;
            if (String.Compare(user.sGioitinh, "Nam", true) == 0)
            {
                ra_Nam.Checked = true;
            }
            else
            {
                ra_Nu.Checked = true;
            }
            if (String.Compare(user.iType_user, "1", true) == 0)
            {
                com_chucvu.SelectedItem = "Quản lý";
            }
            else
            {
                com_chucvu.SelectedItem = "Nhân viên";
            }
        }
        public string getGioitinh()
        {
            string gt = "";
            if (ra_Nam.Checked == true)
            {
                gt = "Nam";
            }
            else
            {
                gt = "Nữ";
            }
            return gt;
        }
        private void disEnable()
        {
            txt_cmnd.Enabled = false;
            txt_diachi.Enabled = false;
            txt_hoten.Enabled = false;
            txt_matkhau.Enabled = false;
            dateTimePicker1.Enabled = false;
            txt_sdt.Enabled = false;
            txt_user.Enabled = false;
            ra_Nam.Enabled = false;
            ra_Nu.Enabled = false;
            com_chucvu.Enabled = false;
        }
        public string getType_user()
        {
            string type = "0";
            if (String.Compare(com_chucvu.SelectedItem.ToString(), "Quản lý") == 0)
            {
                type = "1";
            }
            return type;
        }

        public string getDate()
        {
            return dateTimePicker1.Value.Month.ToString() + "/" + dateTimePicker1.Value.Day.ToString() + "/" + dateTimePicker1.Value.Year.ToString();
        }

        #endregion

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (functions.checkEmpty(txt_hoten.Text) && functions.checkEmpty(getGioitinh()) && functions.checkEmpty(txt_sdt.Text) && functions.checkEmpty(getDate()) && functions.checkEmpty(txt_cmnd.Text)
     && functions.checkEmpty(txt_user.Text) && functions.checkEmpty(txt_matkhau.Text) && functions.checkEmpty(txt_diachi.Text))
            {
                if (userBus.insertUser(txt_hoten.Text, getGioitinh(), getType_user(), txt_sdt.Text, getDate(), txt_cmnd.Text,
                                    txt_user.Text, txt_matkhau.Text, txt_diachi.Text))
                    {
                        MessageBox.Show("Đăng kí thành công","Thành công",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Đăng kí thất bại","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);

                    }
            }
            else
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (functions.checkEmpty(txt_hoten.Text) && functions.checkEmpty(getGioitinh()) && functions.checkEmpty(txt_sdt.Text) && functions.checkEmpty(getDate()) && functions.checkEmpty(txt_cmnd.Text)
     && functions.checkEmpty(txt_user.Text) && functions.checkEmpty(txt_matkhau.Text) && functions.checkEmpty(txt_diachi.Text))
            {
                if (userBus.updateUser(user.iId,txt_hoten.Text, getGioitinh(), getType_user(), txt_sdt.Text, getDate(), txt_cmnd.Text,
                                    txt_user.Text, txt_matkhau.Text, txt_diachi.Text))
                {

                    MessageBox.Show("Lưu thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lưu thất bại","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveChangPass_Click(object sender, EventArgs e)
        {
            if (functions.checkEmpty(tab2_txt_pass.Text) == true && functions.checkEmpty(tab2_txt_repass.Text) == true)
            {
                if (String.Compare(tab2_txt_pass.Text, tab2_txt_repass.Text) == 0)
                {
                    if (userBus.updateUserPass(user.iId, tab2_txt_pass.Text))
                    {
                        MessageBox.Show("Thay đổi mật khẩu thành công.","Thành công",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thay đổi mật khẩu thất bại.","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Password và Re-Password không khớp nhau!");
                }
            }
            else
            {
                MessageBox.Show("Phải điền đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fUser_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
