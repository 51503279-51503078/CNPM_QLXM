namespace QLCuaHangXe
{
    partial class FXuatHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FXuatHang));
            this.grBoxTV = new System.Windows.Forms.GroupBox();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.btThoat = new DevComponents.DotNetBar.ButtonX();
            this.btHuy = new DevComponents.DotNetBar.ButtonX();
            this.btLuu = new DevComponents.DotNetBar.ButtonX();
            this.btXoa = new DevComponents.DotNetBar.ButtonX();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.grBoxCT = new System.Windows.Forms.GroupBox();
            this.cmbHang = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtThue = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.grBoxNhap = new System.Windows.Forms.GroupBox();
            this.btXuat = new DevComponents.DotNetBar.ButtonX();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbNV = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbKhach = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtMaPX = new System.Windows.Forms.TextBox();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.txtDG = new System.Windows.Forms.TextBox();
            this.grBoxTV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grBoxCT.SuspendLayout();
            this.grBoxNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // grBoxTV
            // 
            this.grBoxTV.BackColor = System.Drawing.Color.PowderBlue;
            this.grBoxTV.Controls.Add(this.buttonX1);
            this.grBoxTV.Controls.Add(this.btThoat);
            this.grBoxTV.Controls.Add(this.btHuy);
            this.grBoxTV.Controls.Add(this.btLuu);
            this.grBoxTV.Controls.Add(this.btXoa);
            this.grBoxTV.Location = new System.Drawing.Point(20, 400);
            this.grBoxTV.Name = "grBoxTV";
            this.grBoxTV.Size = new System.Drawing.Size(850, 65);
            this.grBoxTV.TabIndex = 11;
            this.grBoxTV.TabStop = false;
            this.grBoxTV.Text = "Tác Vụ";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX1.Image = global::QLCuaHangXe.Properties.Resources._4;
            this.buttonX1.ImageFixedSize = new System.Drawing.Size(18, 18);
            this.buttonX1.Location = new System.Drawing.Point(501, 25);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(118, 32);
            this.buttonX1.TabIndex = 9;
            this.buttonX1.Text = "In Hóa Đơn";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // btThoat
            // 
            this.btThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Image = ((System.Drawing.Image)(resources.GetObject("btThoat.Image")));
            this.btThoat.ImageFixedSize = new System.Drawing.Size(18, 18);
            this.btThoat.Location = new System.Drawing.Point(713, 25);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(100, 32);
            this.btThoat.TabIndex = 0;
            this.btThoat.Text = "Thoát";
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btHuy
            // 
            this.btHuy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btHuy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHuy.Image = ((System.Drawing.Image)(resources.GetObject("btHuy.Image")));
            this.btHuy.ImageFixedSize = new System.Drawing.Size(18, 18);
            this.btHuy.Location = new System.Drawing.Point(343, 25);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(100, 32);
            this.btHuy.TabIndex = 0;
            this.btHuy.Text = "Hủy";
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // btLuu
            // 
            this.btLuu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btLuu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLuu.Image = ((System.Drawing.Image)(resources.GetObject("btLuu.Image")));
            this.btLuu.ImageFixedSize = new System.Drawing.Size(18, 18);
            this.btLuu.Location = new System.Drawing.Point(185, 25);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(100, 32);
            this.btLuu.TabIndex = 0;
            this.btLuu.Text = "Lưu";
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btXoa
            // 
            this.btXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Image = ((System.Drawing.Image)(resources.GetObject("btXoa.Image")));
            this.btXoa.ImageFixedSize = new System.Drawing.Size(18, 18);
            this.btXoa.Location = new System.Drawing.Point(29, 25);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(100, 32);
            this.btXoa.TabIndex = 0;
            this.btXoa.Text = "Xóa";
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 235);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(850, 159);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // labelX10
            // 
            this.labelX10.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX10.Location = new System.Drawing.Point(353, 0);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(160, 35);
            this.labelX10.TabIndex = 14;
            this.labelX10.Text = "Xuất Hàng";
            this.labelX10.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // grBoxCT
            // 
            this.grBoxCT.BackColor = System.Drawing.Color.PowderBlue;
            this.grBoxCT.Controls.Add(this.cmbHang);
            this.grBoxCT.Controls.Add(this.txtThue);
            this.grBoxCT.Controls.Add(this.txtSL);
            this.grBoxCT.Controls.Add(this.txtDG);
            this.grBoxCT.Controls.Add(this.labelX8);
            this.grBoxCT.Controls.Add(this.labelX9);
            this.grBoxCT.Controls.Add(this.labelX7);
            this.grBoxCT.Controls.Add(this.labelX5);
            this.grBoxCT.Controls.Add(this.labelX6);
            this.grBoxCT.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxCT.Location = new System.Drawing.Point(20, 144);
            this.grBoxCT.Name = "grBoxCT";
            this.grBoxCT.Size = new System.Drawing.Size(850, 85);
            this.grBoxCT.TabIndex = 13;
            this.grBoxCT.TabStop = false;
            this.grBoxCT.Text = "Chi Tiết Phiếu Xuất";
            // 
            // cmbHang
            // 
            this.cmbHang.DisplayMember = "Text";
            this.cmbHang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbHang.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHang.FormattingEnabled = true;
            this.cmbHang.ItemHeight = 19;
            this.cmbHang.Location = new System.Drawing.Point(187, 18);
            this.cmbHang.Name = "cmbHang";
            this.cmbHang.Size = new System.Drawing.Size(152, 25);
            this.cmbHang.TabIndex = 4;
            this.cmbHang.SelectedIndexChanged += new System.EventHandler(this.cmbHang_SelectedIndexChanged);
            // 
            // txtThue
            // 
            this.txtThue.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThue.Location = new System.Drawing.Point(573, 51);
            this.txtThue.Name = "txtThue";
            this.txtThue.Size = new System.Drawing.Size(131, 25);
            this.txtThue.TabIndex = 3;
            this.txtThue.TextChanged += new System.EventHandler(this.txtThue_TextChanged);
            // 
            // txtSL
            // 
            this.txtSL.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSL.Location = new System.Drawing.Point(573, 19);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(154, 25);
            this.txtSL.TabIndex = 2;
            this.txtSL.TextChanged += new System.EventHandler(this.txtSL_TextChanged);
            // 
            // labelX8
            // 
            this.labelX8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX8.Location = new System.Drawing.Point(479, 19);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(71, 26);
            this.labelX8.TabIndex = 1;
            this.labelX8.Text = "Số Lượng";
            // 
            // labelX9
            // 
            this.labelX9.BackColor = System.Drawing.Color.White;
            this.labelX9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX9.Location = new System.Drawing.Point(704, 52);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(23, 24);
            this.labelX9.TabIndex = 1;
            this.labelX9.Text = "%";
            // 
            // labelX7
            // 
            this.labelX7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX7.Location = new System.Drawing.Point(480, 47);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(60, 36);
            this.labelX7.TabIndex = 1;
            this.labelX7.Text = "Thuế";
            // 
            // labelX5
            // 
            this.labelX5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.Location = new System.Drawing.Point(93, 20);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(84, 20);
            this.labelX5.TabIndex = 1;
            this.labelX5.Text = "Tên Hàng";
            // 
            // grBoxNhap
            // 
            this.grBoxNhap.BackColor = System.Drawing.Color.PowderBlue;
            this.grBoxNhap.Controls.Add(this.btXuat);
            this.grBoxNhap.Controls.Add(this.dateTimePicker1);
            this.grBoxNhap.Controls.Add(this.cmbNV);
            this.grBoxNhap.Controls.Add(this.cmbKhach);
            this.grBoxNhap.Controls.Add(this.labelX4);
            this.grBoxNhap.Controls.Add(this.labelX3);
            this.grBoxNhap.Controls.Add(this.labelX2);
            this.grBoxNhap.Controls.Add(this.labelX1);
            this.grBoxNhap.Controls.Add(this.txtMaPX);
            this.grBoxNhap.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxNhap.Location = new System.Drawing.Point(20, 30);
            this.grBoxNhap.Name = "grBoxNhap";
            this.grBoxNhap.Size = new System.Drawing.Size(850, 108);
            this.grBoxNhap.TabIndex = 12;
            this.grBoxNhap.TabStop = false;
            this.grBoxNhap.Text = "Phiếu Xuất";
            // 
            // btXuat
            // 
            this.btXuat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btXuat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btXuat.Image = global::QLCuaHangXe.Properties.Resources.run;
            this.btXuat.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btXuat.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btXuat.Location = new System.Drawing.Point(58, 29);
            this.btXuat.Name = "btXuat";
            this.btXuat.Size = new System.Drawing.Size(119, 47);
            this.btXuat.TabIndex = 5;
            this.btXuat.Text = "Làm Mới Hóa Đơn";
            this.btXuat.Click += new System.EventHandler(this.btXuat_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(291, 51);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(152, 25);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // cmbNV
            // 
            this.cmbNV.DisplayMember = "Text";
            this.cmbNV.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbNV.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNV.FormattingEnabled = true;
            this.cmbNV.ItemHeight = 19;
            this.cmbNV.Location = new System.Drawing.Point(570, 51);
            this.cmbNV.Name = "cmbNV";
            this.cmbNV.Size = new System.Drawing.Size(154, 25);
            this.cmbNV.TabIndex = 3;
            // 
            // cmbKhach
            // 
            this.cmbKhach.DisplayMember = "Text";
            this.cmbKhach.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbKhach.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKhach.FormattingEnabled = true;
            this.cmbKhach.ItemHeight = 19;
            this.cmbKhach.Location = new System.Drawing.Point(570, 21);
            this.cmbKhach.Name = "cmbKhach";
            this.cmbKhach.Size = new System.Drawing.Size(154, 25);
            this.cmbKhach.TabIndex = 2;
            this.cmbKhach.SelectedIndexChanged += new System.EventHandler(this.cmbKhach_SelectedIndexChanged);
            // 
            // labelX4
            // 
            this.labelX4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Location = new System.Drawing.Point(466, 55);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(84, 14);
            this.labelX4.TabIndex = 1;
            this.labelX4.Text = "Nhân Viên";
            // 
            // labelX3
            // 
            this.labelX3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(464, 26);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(94, 20);
            this.labelX3.TabIndex = 1;
            this.labelX3.Text = "Khách Hàng";
            // 
            // labelX2
            // 
            this.labelX2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(187, 51);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(98, 22);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Ngày Xuất";
            // 
            // labelX1
            // 
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(187, 24);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(98, 21);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Mã Phiếu Xuất";
            // 
            // txtMaPX
            // 
            this.txtMaPX.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPX.Location = new System.Drawing.Point(291, 24);
            this.txtMaPX.MaximumSize = new System.Drawing.Size(300, 100);
            this.txtMaPX.MinimumSize = new System.Drawing.Size(20, 20);
            this.txtMaPX.Name = "txtMaPX";
            this.txtMaPX.ReadOnly = true;
            this.txtMaPX.Size = new System.Drawing.Size(154, 25);
            this.txtMaPX.TabIndex = 0;
            // 
            // labelX6
            // 
            this.labelX6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX6.Location = new System.Drawing.Point(95, 51);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(84, 23);
            this.labelX6.TabIndex = 1;
            this.labelX6.Text = "Đơn Giá";
            // 
            // txtDG
            // 
            this.txtDG.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDG.Location = new System.Drawing.Point(187, 49);
            this.txtDG.Name = "txtDG";
            this.txtDG.Size = new System.Drawing.Size(152, 25);
            this.txtDG.TabIndex = 1;
            this.txtDG.TextChanged += new System.EventHandler(this.txtDG_TextChanged);
            // 
            // FXuatHang
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(889, 473);
            this.Controls.Add(this.labelX10);
            this.Controls.Add(this.grBoxCT);
            this.Controls.Add(this.grBoxNhap);
            this.Controls.Add(this.grBoxTV);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Name = "FXuatHang";
            this.Text = "XuatHang";
            this.Load += new System.EventHandler(this.fXuatHang_Load);
            this.grBoxTV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grBoxCT.ResumeLayout(false);
            this.grBoxCT.PerformLayout();
            this.grBoxNhap.ResumeLayout(false);
            this.grBoxNhap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grBoxTV;
        private DevComponents.DotNetBar.ButtonX btThoat;
        private DevComponents.DotNetBar.ButtonX btHuy;
        private DevComponents.DotNetBar.ButtonX btLuu;
        private DevComponents.DotNetBar.ButtonX btXoa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevComponents.DotNetBar.LabelX labelX10;
        private System.Windows.Forms.GroupBox grBoxCT;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbHang;
        private System.Windows.Forms.TextBox txtThue;
        private System.Windows.Forms.TextBox txtSL;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX5;
        private System.Windows.Forms.GroupBox grBoxNhap;
        private DevComponents.DotNetBar.ButtonX btXuat;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbNV;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbKhach;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.TextBox txtMaPX;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private System.Windows.Forms.TextBox txtDG;
        private DevComponents.DotNetBar.LabelX labelX6;
    }
}