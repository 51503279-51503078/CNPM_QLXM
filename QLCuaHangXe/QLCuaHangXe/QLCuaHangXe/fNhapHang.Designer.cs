namespace QLCuaHangXe
{
    partial class FNhapHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FNhapHang));
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.grBoxNhap = new System.Windows.Forms.GroupBox();
            this.btNhap = new DevComponents.DotNetBar.ButtonX();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbNV = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbNCC = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtMaPN = new System.Windows.Forms.TextBox();
            this.grBoxCT = new System.Windows.Forms.GroupBox();
            this.cmbHang = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtThue = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.txtDG = new System.Windows.Forms.TextBox();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grBoxTV = new System.Windows.Forms.GroupBox();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.btThoat = new DevComponents.DotNetBar.ButtonX();
            this.btHuy = new DevComponents.DotNetBar.ButtonX();
            this.btLuu = new DevComponents.DotNetBar.ButtonX();
            this.btXoa = new DevComponents.DotNetBar.ButtonX();
            this.grBoxNhap.SuspendLayout();
            this.grBoxCT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grBoxTV.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelX10
            // 
            this.labelX10.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX10.Location = new System.Drawing.Point(351, 0);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(160, 34);
            this.labelX10.TabIndex = 19;
            this.labelX10.Text = "Nhập Hàng";
            this.labelX10.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // grBoxNhap
            // 
            this.grBoxNhap.BackColor = System.Drawing.Color.PowderBlue;
            this.grBoxNhap.Controls.Add(this.btNhap);
            this.grBoxNhap.Controls.Add(this.dateTimePicker1);
            this.grBoxNhap.Controls.Add(this.cmbNV);
            this.grBoxNhap.Controls.Add(this.cmbNCC);
            this.grBoxNhap.Controls.Add(this.labelX4);
            this.grBoxNhap.Controls.Add(this.labelX3);
            this.grBoxNhap.Controls.Add(this.labelX2);
            this.grBoxNhap.Controls.Add(this.labelX1);
            this.grBoxNhap.Controls.Add(this.txtMaPN);
            this.grBoxNhap.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxNhap.Location = new System.Drawing.Point(23, 35);
            this.grBoxNhap.Name = "grBoxNhap";
            this.grBoxNhap.Size = new System.Drawing.Size(850, 120);
            this.grBoxNhap.TabIndex = 12;
            this.grBoxNhap.TabStop = false;
            this.grBoxNhap.Text = "Phiếu Nhập";
            // 
            // btNhap
            // 
            this.btNhap.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btNhap.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btNhap.Image = global::QLCuaHangXe.Properties.Resources.wucltux_dll_10_09;
            this.btNhap.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btNhap.Location = new System.Drawing.Point(19, 22);
            this.btNhap.Name = "btNhap";
            this.btNhap.Size = new System.Drawing.Size(130, 52);
            this.btNhap.TabIndex = 5;
            this.btNhap.Text = "Làm mới hóa đơn";
            this.btNhap.Click += new System.EventHandler(this.btNhap_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(290, 68);
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
            this.cmbNV.Location = new System.Drawing.Point(620, 68);
            this.cmbNV.Name = "cmbNV";
            this.cmbNV.Size = new System.Drawing.Size(154, 25);
            this.cmbNV.TabIndex = 3;
            // 
            // cmbNCC
            // 
            this.cmbNCC.DisplayMember = "Text";
            this.cmbNCC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbNCC.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNCC.FormattingEnabled = true;
            this.cmbNCC.ItemHeight = 19;
            this.cmbNCC.Location = new System.Drawing.Point(620, 17);
            this.cmbNCC.Name = "cmbNCC";
            this.cmbNCC.Size = new System.Drawing.Size(154, 25);
            this.cmbNCC.TabIndex = 2;
            // 
            // labelX4
            // 
            this.labelX4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Location = new System.Drawing.Point(467, 62);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(113, 34);
            this.labelX4.TabIndex = 1;
            this.labelX4.Text = "NV nhập hàng";
            // 
            // labelX3
            // 
            this.labelX3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(467, 22);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(94, 14);
            this.labelX3.TabIndex = 1;
            this.labelX3.Text = "Nhà Cung Cấp";
            // 
            // labelX2
            // 
            this.labelX2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(184, 68);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(98, 22);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Ngày Nhập";
            // 
            // labelX1
            // 
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(184, 21);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(98, 21);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Mã Hóa Đơn";
            // 
            // txtMaPN
            // 
            this.txtMaPN.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPN.Location = new System.Drawing.Point(290, 19);
            this.txtMaPN.MaximumSize = new System.Drawing.Size(300, 100);
            this.txtMaPN.MinimumSize = new System.Drawing.Size(20, 20);
            this.txtMaPN.Name = "txtMaPN";
            this.txtMaPN.ReadOnly = true;
            this.txtMaPN.Size = new System.Drawing.Size(154, 25);
            this.txtMaPN.TabIndex = 0;
            this.txtMaPN.TextChanged += new System.EventHandler(this.txtMaPN_TextChanged);
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
            this.grBoxCT.Location = new System.Drawing.Point(23, 161);
            this.grBoxCT.Name = "grBoxCT";
            this.grBoxCT.Size = new System.Drawing.Size(850, 86);
            this.grBoxCT.TabIndex = 11;
            this.grBoxCT.TabStop = false;
            this.grBoxCT.Text = "Chi Tiết Nhập Hàng";
            // 
            // cmbHang
            // 
            this.cmbHang.DisplayMember = "Text";
            this.cmbHang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbHang.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHang.FormattingEnabled = true;
            this.cmbHang.ItemHeight = 19;
            this.cmbHang.Location = new System.Drawing.Point(200, 16);
            this.cmbHang.Name = "cmbHang";
            this.cmbHang.Size = new System.Drawing.Size(152, 25);
            this.cmbHang.TabIndex = 4;
            // 
            // txtThue
            // 
            this.txtThue.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThue.Location = new System.Drawing.Point(573, 51);
            this.txtThue.Name = "txtThue";
            this.txtThue.Size = new System.Drawing.Size(131, 25);
            this.txtThue.TabIndex = 3;
            // 
            // txtSL
            // 
            this.txtSL.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSL.Location = new System.Drawing.Point(573, 19);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(154, 25);
            this.txtSL.TabIndex = 2;
            // 
            // txtDG
            // 
            this.txtDG.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDG.Location = new System.Drawing.Point(200, 47);
            this.txtDG.Name = "txtDG";
            this.txtDG.Size = new System.Drawing.Size(152, 25);
            this.txtDG.TabIndex = 1;
            // 
            // labelX8
            // 
            this.labelX8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX8.Location = new System.Drawing.Point(443, 19);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(107, 26);
            this.labelX8.TabIndex = 1;
            this.labelX8.Text = "Số Lượng Nhập";
            // 
            // labelX9
            // 
            this.labelX9.BackColor = System.Drawing.Color.White;
            this.labelX9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX9.Location = new System.Drawing.Point(704, 51);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(23, 24);
            this.labelX9.TabIndex = 1;
            this.labelX9.Text = "%";
            // 
            // labelX7
            // 
            this.labelX7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX7.Location = new System.Drawing.Point(443, 44);
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
            // labelX6
            // 
            this.labelX6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX6.Location = new System.Drawing.Point(95, 51);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(99, 23);
            this.labelX6.TabIndex = 1;
            this.labelX6.Text = "Đơn Giá Nhập";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 253);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(850, 153);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // grBoxTV
            // 
            this.grBoxTV.BackColor = System.Drawing.Color.PowderBlue;
            this.grBoxTV.Controls.Add(this.buttonX1);
            this.grBoxTV.Controls.Add(this.btThoat);
            this.grBoxTV.Controls.Add(this.btHuy);
            this.grBoxTV.Controls.Add(this.btLuu);
            this.grBoxTV.Controls.Add(this.btXoa);
            this.grBoxTV.Location = new System.Drawing.Point(23, 412);
            this.grBoxTV.Name = "grBoxTV";
            this.grBoxTV.Size = new System.Drawing.Size(850, 64);
            this.grBoxTV.TabIndex = 20;
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
            this.buttonX1.Location = new System.Drawing.Point(543, 24);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(118, 32);
            this.buttonX1.TabIndex = 8;
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
            this.btThoat.Location = new System.Drawing.Point(730, 24);
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
            this.btHuy.Location = new System.Drawing.Point(344, 23);
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
            this.btLuu.Location = new System.Drawing.Point(182, 23);
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
            this.btXoa.Location = new System.Drawing.Point(29, 23);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(100, 32);
            this.btXoa.TabIndex = 0;
            this.btXoa.Text = "Xóa";
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // fNhapHang
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(901, 479);
            this.Controls.Add(this.grBoxTV);
            this.Controls.Add(this.labelX10);
            this.Controls.Add(this.grBoxNhap);
            this.Controls.Add(this.grBoxCT);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Name = "FNhapHang";
            this.Text = "NhapHang";
            this.Load += new System.EventHandler(this.fNhapHang_Load);
            this.grBoxNhap.ResumeLayout(false);
            this.grBoxNhap.PerformLayout();
            this.grBoxCT.ResumeLayout(false);
            this.grBoxCT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grBoxTV.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX10;
        private System.Windows.Forms.GroupBox grBoxNhap;
        private DevComponents.DotNetBar.ButtonX btNhap;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbNV;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbNCC;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.TextBox txtMaPN;
        private System.Windows.Forms.GroupBox grBoxCT;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbHang;
        private System.Windows.Forms.TextBox txtThue;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.TextBox txtDG;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grBoxTV;
        private DevComponents.DotNetBar.ButtonX btThoat;
        private DevComponents.DotNetBar.ButtonX btHuy;
        private DevComponents.DotNetBar.ButtonX btLuu;
        private DevComponents.DotNetBar.ButtonX btXoa;
        private DevComponents.DotNetBar.ButtonX buttonX1;
    }
}