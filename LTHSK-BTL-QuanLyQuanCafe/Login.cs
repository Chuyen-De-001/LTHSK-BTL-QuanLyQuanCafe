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
    public partial class Login : Form
    {

        Bus.UserBus userBus = new Bus.UserBus();
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int IdUser = userBus.doLogin(txtUser.Text, txtPass.Text);
            //Debug.WriteLine(iLogin);
            if (IdUser > 0)
            {
                Main main = new Main(IdUser);
                main.Show();

            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

    }
}
