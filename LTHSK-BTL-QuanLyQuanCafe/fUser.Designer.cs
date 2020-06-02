namespace LTHSK_BTL_QuanLyQuanCafe
{
    partial class fUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fUser));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabInfoUser = new System.Windows.Forms.TabPage();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_cmnd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.com_chucvu = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ra_Nu = new System.Windows.Forms.RadioButton();
            this.ra_Nam = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labTitle = new System.Windows.Forms.Label();
            this.tab_changePass = new System.Windows.Forms.TabPage();
            this.tab2_btnSaveChangPass = new System.Windows.Forms.Button();
            this.tab2_txt_repass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tab2_txt_pass = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tab2_txt_User = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1.SuspendLayout();
            this.tabInfoUser.SuspendLayout();
            this.tab_changePass.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabInfoUser);
            this.tabControl1.Controls.Add(this.tab_changePass);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabInfoUser
            // 
            this.tabInfoUser.Controls.Add(this.btnSave);
            this.tabInfoUser.Controls.Add(this.btnSignUp);
            this.tabInfoUser.Controls.Add(this.txt_diachi);
            this.tabInfoUser.Controls.Add(this.label10);
            this.tabInfoUser.Controls.Add(this.txt_matkhau);
            this.tabInfoUser.Controls.Add(this.label9);
            this.tabInfoUser.Controls.Add(this.txt_user);
            this.tabInfoUser.Controls.Add(this.label8);
            this.tabInfoUser.Controls.Add(this.txt_cmnd);
            this.tabInfoUser.Controls.Add(this.label7);
            this.tabInfoUser.Controls.Add(this.dateTimePicker1);
            this.tabInfoUser.Controls.Add(this.label6);
            this.tabInfoUser.Controls.Add(this.txt_sdt);
            this.tabInfoUser.Controls.Add(this.label5);
            this.tabInfoUser.Controls.Add(this.com_chucvu);
            this.tabInfoUser.Controls.Add(this.label3);
            this.tabInfoUser.Controls.Add(this.ra_Nu);
            this.tabInfoUser.Controls.Add(this.ra_Nam);
            this.tabInfoUser.Controls.Add(this.label4);
            this.tabInfoUser.Controls.Add(this.txt_hoten);
            this.tabInfoUser.Controls.Add(this.label2);
            this.tabInfoUser.Controls.Add(this.labTitle);
            this.tabInfoUser.ImageIndex = 0;
            this.tabInfoUser.Location = new System.Drawing.Point(4, 25);
            this.tabInfoUser.Name = "tabInfoUser";
            this.tabInfoUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabInfoUser.Size = new System.Drawing.Size(792, 421);
            this.tabInfoUser.TabIndex = 0;
            this.tabInfoUser.Text = "Thông tin tài khoản.";
            this.tabInfoUser.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(315, 328);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(141, 52);
            this.btnSave.TabIndex = 39;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(315, 328);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(141, 52);
            this.btnSignUp.TabIndex = 38;
            this.btnSignUp.Text = "Đăng kí";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // txt_diachi
            // 
            this.txt_diachi.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_diachi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_diachi.Location = new System.Drawing.Point(546, 219);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(167, 22);
            this.txt_diachi.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(442, 220);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 17);
            this.label10.TabIndex = 36;
            this.label10.Text = "Địa chỉ";
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_matkhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_matkhau.Location = new System.Drawing.Point(546, 178);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.Size = new System.Drawing.Size(167, 22);
            this.txt_matkhau.TabIndex = 35;
            this.txt_matkhau.UseSystemPasswordChar = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(442, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 17);
            this.label9.TabIndex = 34;
            this.label9.Text = "Mật khẩu:";
            // 
            // txt_user
            // 
            this.txt_user.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_user.Location = new System.Drawing.Point(546, 138);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(167, 22);
            this.txt_user.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(442, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 17);
            this.label8.TabIndex = 32;
            this.label8.Text = "Tài khoản:";
            // 
            // txt_cmnd
            // 
            this.txt_cmnd.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_cmnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cmnd.Location = new System.Drawing.Point(546, 99);
            this.txt_cmnd.Name = "txt_cmnd";
            this.txt_cmnd.Size = new System.Drawing.Size(167, 22);
            this.txt_cmnd.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(442, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "CMND";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(163, 265);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(167, 22);
            this.dateTimePicker1.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(77, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Ngày sinh:";
            // 
            // txt_sdt
            // 
            this.txt_sdt.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_sdt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_sdt.Location = new System.Drawing.Point(163, 223);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(167, 22);
            this.txt_sdt.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(77, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "SĐT";
            // 
            // com_chucvu
            // 
            this.com_chucvu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_chucvu.FormattingEnabled = true;
            this.com_chucvu.Items.AddRange(new object[] {
            "Nhân viên",
            "Quản lý"});
            this.com_chucvu.Location = new System.Drawing.Point(163, 179);
            this.com_chucvu.Name = "com_chucvu";
            this.com_chucvu.Size = new System.Drawing.Size(167, 24);
            this.com_chucvu.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Chức vụ: ";
            // 
            // ra_Nu
            // 
            this.ra_Nu.AutoSize = true;
            this.ra_Nu.BackColor = System.Drawing.Color.Transparent;
            this.ra_Nu.Location = new System.Drawing.Point(238, 136);
            this.ra_Nu.Name = "ra_Nu";
            this.ra_Nu.Size = new System.Drawing.Size(47, 21);
            this.ra_Nu.TabIndex = 13;
            this.ra_Nu.TabStop = true;
            this.ra_Nu.Text = "Nữ";
            this.ra_Nu.UseVisualStyleBackColor = false;
            // 
            // ra_Nam
            // 
            this.ra_Nam.AutoSize = true;
            this.ra_Nam.BackColor = System.Drawing.Color.Transparent;
            this.ra_Nam.Location = new System.Drawing.Point(162, 136);
            this.ra_Nam.Name = "ra_Nam";
            this.ra_Nam.Size = new System.Drawing.Size(58, 21);
            this.ra_Nam.TabIndex = 12;
            this.ra_Nam.TabStop = true;
            this.ra_Nam.Text = "Nam";
            this.ra_Nam.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Giới tính: ";
            // 
            // txt_hoten
            // 
            this.txt_hoten.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_hoten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_hoten.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txt_hoten.Location = new System.Drawing.Point(162, 96);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(167, 22);
            this.txt_hoten.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Họ và tên:";
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitle.Location = new System.Drawing.Point(255, 38);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(276, 32);
            this.labTitle.TabIndex = 0;
            this.labTitle.Text = "Thông tin tài khoản";
            // 
            // tab_changePass
            // 
            this.tab_changePass.Controls.Add(this.tab2_btnSaveChangPass);
            this.tab_changePass.Controls.Add(this.tab2_txt_repass);
            this.tab_changePass.Controls.Add(this.label1);
            this.tab_changePass.Controls.Add(this.tab2_txt_pass);
            this.tab_changePass.Controls.Add(this.label11);
            this.tab_changePass.Controls.Add(this.tab2_txt_User);
            this.tab_changePass.Controls.Add(this.label12);
            this.tab_changePass.Controls.Add(this.label13);
            this.tab_changePass.ImageIndex = 1;
            this.tab_changePass.Location = new System.Drawing.Point(4, 25);
            this.tab_changePass.Name = "tab_changePass";
            this.tab_changePass.Padding = new System.Windows.Forms.Padding(3);
            this.tab_changePass.Size = new System.Drawing.Size(792, 421);
            this.tab_changePass.TabIndex = 1;
            this.tab_changePass.Text = "Thay đổi mật khẩu";
            this.tab_changePass.UseVisualStyleBackColor = true;
            // 
            // tab2_btnSaveChangPass
            // 
            this.tab2_btnSaveChangPass.Location = new System.Drawing.Point(327, 297);
            this.tab2_btnSaveChangPass.Name = "tab2_btnSaveChangPass";
            this.tab2_btnSaveChangPass.Size = new System.Drawing.Size(133, 59);
            this.tab2_btnSaveChangPass.TabIndex = 15;
            this.tab2_btnSaveChangPass.Text = "Lưu";
            this.tab2_btnSaveChangPass.UseVisualStyleBackColor = true;
            this.tab2_btnSaveChangPass.Click += new System.EventHandler(this.btnSaveChangPass_Click);
            // 
            // tab2_txt_repass
            // 
            this.tab2_txt_repass.Location = new System.Drawing.Point(327, 244);
            this.tab2_txt_repass.Name = "tab2_txt_repass";
            this.tab2_txt_repass.Size = new System.Drawing.Size(226, 22);
            this.tab2_txt_repass.TabIndex = 14;
            this.tab2_txt_repass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(210, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "re - Password:";
            // 
            // tab2_txt_pass
            // 
            this.tab2_txt_pass.Location = new System.Drawing.Point(327, 198);
            this.tab2_txt_pass.Name = "tab2_txt_pass";
            this.tab2_txt_pass.Size = new System.Drawing.Size(226, 22);
            this.tab2_txt_pass.TabIndex = 12;
            this.tab2_txt_pass.UseSystemPasswordChar = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(210, 201);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "Password:";
            // 
            // tab2_txt_User
            // 
            this.tab2_txt_User.Enabled = false;
            this.tab2_txt_User.Location = new System.Drawing.Point(327, 152);
            this.tab2_txt_User.Name = "tab2_txt_User";
            this.tab2_txt_User.Size = new System.Drawing.Size(226, 22);
            this.tab2_txt_User.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(210, 155);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 17);
            this.label12.TabIndex = 9;
            this.label12.Text = "Username:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(278, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(264, 32);
            this.label13.TabIndex = 8;
            this.label13.Text = "Thay đổi mật khẩu";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "User (2).png");
            this.imageList1.Images.SetKeyName(1, "key.png");
            // 
            // fUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "fUser";
            this.Text = "fUser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fUser_FormClosing);
            this.Load += new System.EventHandler(this.fUser_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabInfoUser.ResumeLayout(false);
            this.tabInfoUser.PerformLayout();
            this.tab_changePass.ResumeLayout(false);
            this.tab_changePass.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabInfoUser;
        private System.Windows.Forms.TabPage tab_changePass;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox com_chucvu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton ra_Nu;
        private System.Windows.Forms.RadioButton ra_Nam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_matkhau;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_cmnd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button tab2_btnSaveChangPass;
        private System.Windows.Forms.TextBox tab2_txt_repass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tab2_txt_pass;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tab2_txt_User;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ImageList imageList1;
    }
}