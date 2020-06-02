namespace LTHSK_BTL_QuanLyQuanCafe
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtNameUser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flp_dsban = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_soluong = new System.Windows.Forms.NumericUpDown();
            this.ttn_datmon = new System.Windows.Forms.Button();
            this.comboBox_typeDrink = new System.Windows.Forms.ComboBox();
            this.btn_refesh = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dataGridView_listChiTietHD = new System.Windows.Forms.DataGridView();
            this.id_bill_infor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTendouong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fDongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMaHd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_tortal_payment = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_thanhtoan = new System.Windows.Forms.Button();
            this.lab_chooseTable = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.combox_drinks = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_soluong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listChiTietHD)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýTàiKhoảnToolStripMenuItem,
            this.quảnLýToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1134, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýTàiKhoảnToolStripMenuItem
            // 
            this.quảnLýTàiKhoảnToolStripMenuItem.Image = global::LTHSK_BTL_QuanLyQuanCafe.Properties.Resources.User__2_;
            this.quảnLýTàiKhoảnToolStripMenuItem.Name = "quảnLýTàiKhoảnToolStripMenuItem";
            this.quảnLýTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.quảnLýTàiKhoảnToolStripMenuItem.Text = "Quản lý tài khoản";
            this.quảnLýTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.quảnLýTàiKhoảnToolStripMenuItem_Click);
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.Image = global::LTHSK_BTL_QuanLyQuanCafe.Properties.Resources.hoadon;
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.quảnLýToolStripMenuItem.Text = "Quản lý cửa hàng";
            this.quảnLýToolStripMenuItem.Click += new System.EventHandler(this.quảnLýToolStripMenuItem_Click);
            // 
            // txtNameUser
            // 
            this.txtNameUser.AutoSize = true;
            this.txtNameUser.Location = new System.Drawing.Point(993, 57);
            this.txtNameUser.Name = "txtNameUser";
            this.txtNameUser.Size = new System.Drawing.Size(77, 17);
            this.txtNameUser.TabIndex = 1;
            this.txtNameUser.Text = "name User";
            this.txtNameUser.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.txtNameUser.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1003, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Xin chào:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // flp_dsban
            // 
            this.flp_dsban.Location = new System.Drawing.Point(12, 190);
            this.flp_dsban.Name = "flp_dsban";
            this.flp_dsban.Size = new System.Drawing.Size(552, 311);
            this.flp_dsban.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(808, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Số lượng:";
            // 
            // numericUpDown_soluong
            // 
            this.numericUpDown_soluong.Location = new System.Drawing.Point(910, 137);
            this.numericUpDown_soluong.Name = "numericUpDown_soluong";
            this.numericUpDown_soluong.Size = new System.Drawing.Size(100, 22);
            this.numericUpDown_soluong.TabIndex = 8;
            this.numericUpDown_soluong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ttn_datmon
            // 
            this.ttn_datmon.Location = new System.Drawing.Point(1029, 103);
            this.ttn_datmon.Name = "ttn_datmon";
            this.ttn_datmon.Size = new System.Drawing.Size(93, 63);
            this.ttn_datmon.TabIndex = 7;
            this.ttn_datmon.Text = "Đặt món";
            this.ttn_datmon.UseVisualStyleBackColor = true;
            this.ttn_datmon.Click += new System.EventHandler(this.ttn_datmon_Click);
            // 
            // comboBox_typeDrink
            // 
            this.comboBox_typeDrink.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_typeDrink.FormattingEnabled = true;
            this.comboBox_typeDrink.Location = new System.Drawing.Point(576, 107);
            this.comboBox_typeDrink.Name = "comboBox_typeDrink";
            this.comboBox_typeDrink.Size = new System.Drawing.Size(221, 24);
            this.comboBox_typeDrink.TabIndex = 5;
            this.comboBox_typeDrink.TextChanged += new System.EventHandler(this.comboBox_typeDrink_TextChanged);
            // 
            // btn_refesh
            // 
            this.btn_refesh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_refesh.ImageIndex = 0;
            this.btn_refesh.ImageList = this.imageList1;
            this.btn_refesh.Location = new System.Drawing.Point(428, 107);
            this.btn_refesh.Name = "btn_refesh";
            this.btn_refesh.Padding = new System.Windows.Forms.Padding(8);
            this.btn_refesh.Size = new System.Drawing.Size(93, 63);
            this.btn_refesh.TabIndex = 8;
            this.btn_refesh.Text = "Làm lại";
            this.btn_refesh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_refesh.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "refresh-29.png");
            // 
            // dataGridView_listChiTietHD
            // 
            this.dataGridView_listChiTietHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_listChiTietHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_bill_infor,
            this.sTendouong,
            this.soluong,
            this.fDongia,
            this.sMaHd});
            this.dataGridView_listChiTietHD.Location = new System.Drawing.Point(576, 190);
            this.dataGridView_listChiTietHD.Name = "dataGridView_listChiTietHD";
            this.dataGridView_listChiTietHD.RowHeadersWidth = 51;
            this.dataGridView_listChiTietHD.RowTemplate.Height = 24;
            this.dataGridView_listChiTietHD.Size = new System.Drawing.Size(546, 224);
            this.dataGridView_listChiTietHD.TabIndex = 10;
            // 
            // id_bill_infor
            // 
            this.id_bill_infor.DataPropertyName = "id";
            this.id_bill_infor.HeaderText = "Mã ";
            this.id_bill_infor.MinimumWidth = 6;
            this.id_bill_infor.Name = "id_bill_infor";
            this.id_bill_infor.Visible = false;
            this.id_bill_infor.Width = 125;
            // 
            // sTendouong
            // 
            this.sTendouong.DataPropertyName = "sTendouong";
            this.sTendouong.HeaderText = "Tên đồ uống";
            this.sTendouong.MinimumWidth = 6;
            this.sTendouong.Name = "sTendouong";
            this.sTendouong.Width = 150;
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "iSoluong";
            this.soluong.HeaderText = "Số lượng";
            this.soluong.MinimumWidth = 6;
            this.soluong.Name = "soluong";
            this.soluong.Width = 50;
            // 
            // fDongia
            // 
            this.fDongia.DataPropertyName = "fDongia";
            this.fDongia.HeaderText = "Đơn giá";
            this.fDongia.MinimumWidth = 6;
            this.fDongia.Name = "fDongia";
            this.fDongia.Width = 150;
            // 
            // sMaHd
            // 
            this.sMaHd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sMaHd.DataPropertyName = "sMaHD";
            this.sMaHd.HeaderText = "Mã hóa đơn";
            this.sMaHd.MinimumWidth = 6;
            this.sMaHd.Name = "sMaHd";
            // 
            // txt_tortal_payment
            // 
            this.txt_tortal_payment.AutoSize = true;
            this.txt_tortal_payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tortal_payment.ForeColor = System.Drawing.Color.Red;
            this.txt_tortal_payment.Location = new System.Drawing.Point(650, 445);
            this.txt_tortal_payment.Name = "txt_tortal_payment";
            this.txt_tortal_payment.Size = new System.Drawing.Size(47, 20);
            this.txt_tortal_payment.TabIndex = 14;
            this.txt_tortal_payment.Text = "tortal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(573, 447);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tổng tiền:";
            // 
            // btn_thanhtoan
            // 
            this.btn_thanhtoan.Location = new System.Drawing.Point(1002, 438);
            this.btn_thanhtoan.Name = "btn_thanhtoan";
            this.btn_thanhtoan.Size = new System.Drawing.Size(120, 63);
            this.btn_thanhtoan.TabIndex = 12;
            this.btn_thanhtoan.Text = "Thanh Toán";
            this.btn_thanhtoan.UseVisualStyleBackColor = true;
            this.btn_thanhtoan.Click += new System.EventHandler(this.btn_thanhtoan_Click);
            // 
            // lab_chooseTable
            // 
            this.lab_chooseTable.AutoSize = true;
            this.lab_chooseTable.Location = new System.Drawing.Point(81, 149);
            this.lab_chooseTable.Name = "lab_chooseTable";
            this.lab_chooseTable.Size = new System.Drawing.Size(30, 17);
            this.lab_chooseTable.TabIndex = 15;
            this.lab_chooseTable.Text = "null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Mã bàn: ";
            // 
            // combox_drinks
            // 
            this.combox_drinks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combox_drinks.FormattingEnabled = true;
            this.combox_drinks.Location = new System.Drawing.Point(803, 107);
            this.combox_drinks.Name = "combox_drinks";
            this.combox_drinks.Size = new System.Drawing.Size(207, 24);
            this.combox_drinks.TabIndex = 17;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 513);
            this.Controls.Add(this.combox_drinks);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lab_chooseTable);
            this.Controls.Add(this.txt_tortal_payment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_thanhtoan);
            this.Controls.Add(this.dataGridView_listChiTietHD);
            this.Controls.Add(this.btn_refesh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown_soluong);
            this.Controls.Add(this.ttn_datmon);
            this.Controls.Add(this.comboBox_typeDrink);
            this.Controls.Add(this.flp_dsban);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNameUser);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Quản lý cửa hàng.";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_soluong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listChiTietHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.Label txtNameUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flp_dsban;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_soluong;
        private System.Windows.Forms.Button ttn_datmon;
        private System.Windows.Forms.ComboBox comboBox_typeDrink;
        private System.Windows.Forms.Button btn_refesh;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridView dataGridView_listChiTietHD;
        private System.Windows.Forms.Label txt_tortal_payment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_thanhtoan;
        private System.Windows.Forms.Label lab_chooseTable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combox_drinks;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_bill_infor;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTendouong;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn fDongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaHd;
    }
}

