namespace QLCuaHangXe
{
    partial class FHangHoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FHangHoa));
            this.treeviewNCC = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtdvtinh = new System.Windows.Forms.TextBox();
            this.txtdacta = new System.Windows.Forms.TextBox();
            this.txttensp = new System.Windows.Forms.TextBox();
            this.txtmasp = new System.Windows.Forms.TextBox();
            this.cmbNCC = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colmasp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colslhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbaohanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldvtinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmancc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btthemNCC = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.btXthem = new DevComponents.DotNetBar.ButtonX();
            this.btXluu = new DevComponents.DotNetBar.ButtonX();
            this.btXxoa = new DevComponents.DotNetBar.ButtonX();
            this.btXcapnhat = new DevComponents.DotNetBar.ButtonX();
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.btthoat = new DevComponents.DotNetBar.ButtonX();
            this.bthuy = new DevComponents.DotNetBar.ButtonX();
            this.btinhanghoa = new DevComponents.DotNetBar.ButtonX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.txtslhang = new System.Windows.Forms.TextBox();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.txtbaohanh = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeviewNCC
            // 
            this.treeviewNCC.ImageIndex = 0;
            this.treeviewNCC.ImageList = this.imageList1;
            this.treeviewNCC.Location = new System.Drawing.Point(12, 75);
            this.treeviewNCC.Name = "treeviewNCC";
            this.treeviewNCC.SelectedImageIndex = 0;
            this.treeviewNCC.Size = new System.Drawing.Size(166, 251);
            this.treeviewNCC.TabIndex = 1;
            this.treeviewNCC.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeviewNCC_NodeMouseClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ieframe_dll_64_13.png");
            this.imageList1.Images.SetKeyName(1, "muscule_car_128.png");
            // 
            // txtdvtinh
            // 
            this.txtdvtinh.Location = new System.Drawing.Point(596, 130);
            this.txtdvtinh.Name = "txtdvtinh";
            this.txtdvtinh.Size = new System.Drawing.Size(168, 20);
            this.txtdvtinh.TabIndex = 6;
            // 
            // txtdacta
            // 
            this.txtdacta.Location = new System.Drawing.Point(596, 156);
            this.txtdacta.Name = "txtdacta";
            this.txtdacta.Size = new System.Drawing.Size(168, 20);
            this.txtdacta.TabIndex = 7;
            // 
            // txttensp
            // 
            this.txttensp.Location = new System.Drawing.Point(307, 103);
            this.txttensp.Name = "txttensp";
            this.txttensp.Size = new System.Drawing.Size(168, 20);
            this.txttensp.TabIndex = 8;
            // 
            // txtmasp
            // 
            this.txtmasp.Location = new System.Drawing.Point(307, 76);
            this.txtmasp.Name = "txtmasp";
            this.txtmasp.ReadOnly = true;
            this.txtmasp.Size = new System.Drawing.Size(168, 20);
            this.txtmasp.TabIndex = 5;
            // 
            // cmbNCC
            // 
            this.cmbNCC.FormattingEnabled = true;
            this.cmbNCC.Location = new System.Drawing.Point(596, 182);
            this.cmbNCC.Name = "cmbNCC";
            this.cmbNCC.Size = new System.Drawing.Size(168, 21);
            this.cmbNCC.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colmasp,
            this.coltensp,
            this.colslhang,
            this.coldongia,
            this.colbaohanh,
            this.coldvtinh,
            this.colmota,
            this.colmancc});
            this.dataGridView1.Location = new System.Drawing.Point(206, 223);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(558, 135);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // colmasp
            // 
            this.colmasp.DataPropertyName = "MAHANG";
            this.colmasp.HeaderText = "Mã Sản Phẩm";
            this.colmasp.Name = "colmasp";
            this.colmasp.ReadOnly = true;
            this.colmasp.Width = 130;
            // 
            // coltensp
            // 
            this.coltensp.DataPropertyName = "TENHANG";
            this.coltensp.HeaderText = "Tên Sản Phẩm";
            this.coltensp.Name = "coltensp";
            this.coltensp.ReadOnly = true;
            this.coltensp.Width = 130;
            // 
            // colslhang
            // 
            this.colslhang.DataPropertyName = "SOLUONG";
            this.colslhang.HeaderText = "SL Hàng";
            this.colslhang.Name = "colslhang";
            this.colslhang.ReadOnly = true;
            // 
            // coldongia
            // 
            this.coldongia.DataPropertyName = "DGBAN";
            this.coldongia.HeaderText = "Đơn giá";
            this.coldongia.Name = "coldongia";
            this.coldongia.ReadOnly = true;
            // 
            // colbaohanh
            // 
            this.colbaohanh.DataPropertyName = "THONGTINBAOHANH";
            this.colbaohanh.HeaderText = "TT BẢO HÀNH";
            this.colbaohanh.Name = "colbaohanh";
            this.colbaohanh.ReadOnly = true;
            // 
            // coldvtinh
            // 
            this.coldvtinh.DataPropertyName = "DONVITINH";
            this.coldvtinh.HeaderText = "Đơn Vị Tính";
            this.coldvtinh.Name = "coldvtinh";
            this.coldvtinh.ReadOnly = true;
            // 
            // colmota
            // 
            this.colmota.DataPropertyName = "MOTA";
            this.colmota.HeaderText = "Mô Tả";
            this.colmota.Name = "colmota";
            this.colmota.ReadOnly = true;
            // 
            // colmancc
            // 
            this.colmancc.DataPropertyName = "TENNHACUNGCAP";
            this.colmancc.HeaderText = "Mã NCC";
            this.colmancc.Name = "colmancc";
            this.colmancc.ReadOnly = true;
            this.colmancc.Visible = false;
            // 
            // btthemNCC
            // 
            this.btthemNCC.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btthemNCC.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btthemNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthemNCC.ForeColor = System.Drawing.Color.Red;
            this.btthemNCC.Location = new System.Drawing.Point(23, 332);
            this.btthemNCC.Name = "btthemNCC";
            this.btthemNCC.Size = new System.Drawing.Size(142, 26);
            this.btthemNCC.TabIndex = 10;
            this.btthemNCC.Text = "Thêm Nhà Cung Cấp ";
            this.btthemNCC.Click += new System.EventHandler(this.btthemNCC_Click);
            // 
            // labelX1
            // 
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(206, 76);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(95, 19);
            this.labelX1.TabIndex = 11;
            this.labelX1.Text = "Mã sản phẩm";
            // 
            // labelX2
            // 
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(206, 104);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(95, 19);
            this.labelX2.TabIndex = 11;
            this.labelX2.Text = "Tên sản phẩm";
            // 
            // labelX3
            // 
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(495, 157);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(95, 19);
            this.labelX3.TabIndex = 11;
            this.labelX3.Text = "Mô tả";
            // 
            // labelX4
            // 
            this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Location = new System.Drawing.Point(495, 131);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(95, 19);
            this.labelX4.TabIndex = 11;
            this.labelX4.Text = "Đơn vị tính";
            // 
            // labelX5
            // 
            this.labelX5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.Location = new System.Drawing.Point(495, 184);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(95, 19);
            this.labelX5.TabIndex = 11;
            this.labelX5.Text = "Nhà cung cấp";
            // 
            // btXthem
            // 
            this.btXthem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btXthem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btXthem.Image = ((System.Drawing.Image)(resources.GetObject("btXthem.Image")));
            this.btXthem.Location = new System.Drawing.Point(21, 19);
            this.btXthem.Name = "btXthem";
            this.btXthem.Size = new System.Drawing.Size(74, 30);
            this.btXthem.TabIndex = 12;
            this.btXthem.Text = "Thêm";
            this.btXthem.Click += new System.EventHandler(this.btXthem_Click);
            // 
            // btXluu
            // 
            this.btXluu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btXluu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btXluu.Image = ((System.Drawing.Image)(resources.GetObject("btXluu.Image")));
            this.btXluu.Location = new System.Drawing.Point(101, 19);
            this.btXluu.Name = "btXluu";
            this.btXluu.Size = new System.Drawing.Size(71, 30);
            this.btXluu.TabIndex = 12;
            this.btXluu.Text = "Lưu";
            this.btXluu.Click += new System.EventHandler(this.btXluu_Click);
            // 
            // btXxoa
            // 
            this.btXxoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btXxoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btXxoa.Image = ((System.Drawing.Image)(resources.GetObject("btXxoa.Image")));
            this.btXxoa.Location = new System.Drawing.Point(178, 19);
            this.btXxoa.Name = "btXxoa";
            this.btXxoa.Size = new System.Drawing.Size(73, 30);
            this.btXxoa.TabIndex = 12;
            this.btXxoa.Text = "Xóa";
            this.btXxoa.Click += new System.EventHandler(this.btXxoa_Click);
            // 
            // btXcapnhat
            // 
            this.btXcapnhat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btXcapnhat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btXcapnhat.Image = ((System.Drawing.Image)(resources.GetObject("btXcapnhat.Image")));
            this.btXcapnhat.Location = new System.Drawing.Point(333, 19);
            this.btXcapnhat.Name = "btXcapnhat";
            this.btXcapnhat.Size = new System.Drawing.Size(103, 30);
            this.btXcapnhat.TabIndex = 12;
            this.btXcapnhat.Text = "Cập nhật";
            this.btXcapnhat.Click += new System.EventHandler(this.btXcapnhat_Click);
            // 
            // reflectionLabel1
            // 
            this.reflectionLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reflectionLabel1.Location = new System.Drawing.Point(209, 3);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(309, 50);
            this.reflectionLabel1.TabIndex = 13;
            this.reflectionLabel1.Text = "<b><font color=\"#000000\">THÔNG TIN</font> <i><font color=\"#BA1419\">SẢN PHẨM</font" +
                "></i></b>";
            // 
            // btthoat
            // 
            this.btthoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btthoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btthoat.Image = ((System.Drawing.Image)(resources.GetObject("btthoat.Image")));
            this.btthoat.Location = new System.Drawing.Point(643, 19);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(103, 30);
            this.btthoat.TabIndex = 12;
            this.btthoat.Text = "Thoát";
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // bthuy
            // 
            this.bthuy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bthuy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bthuy.Image = ((System.Drawing.Image)(resources.GetObject("bthuy.Image")));
            this.bthuy.Location = new System.Drawing.Point(257, 19);
            this.bthuy.Name = "bthuy";
            this.bthuy.Size = new System.Drawing.Size(70, 30);
            this.bthuy.TabIndex = 12;
            this.bthuy.Text = "Hủy";
            this.bthuy.Click += new System.EventHandler(this.bthuy_Click);
            // 
            // btinhanghoa
            // 
            this.btinhanghoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btinhanghoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btinhanghoa.Image = global::QLCuaHangXe.Properties.Resources.wucltux_dll_10_09;
            this.btinhanghoa.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btinhanghoa.Location = new System.Drawing.Point(442, 19);
            this.btinhanghoa.Name = "btinhanghoa";
            this.btinhanghoa.Size = new System.Drawing.Size(131, 30);
            this.btinhanghoa.TabIndex = 12;
            this.btinhanghoa.Text = "In Danh Sách";
            this.btinhanghoa.Click += new System.EventHandler(this.btinhanghoa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btXxoa);
            this.groupBox1.Controls.Add(this.btXthem);
            this.groupBox1.Controls.Add(this.btinhanghoa);
            this.groupBox1.Controls.Add(this.btXluu);
            this.groupBox1.Controls.Add(this.bthuy);
            this.groupBox1.Controls.Add(this.btXcapnhat);
            this.groupBox1.Controls.Add(this.btthoat);
            this.groupBox1.Location = new System.Drawing.Point(12, 364);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(752, 69);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thao tác";
            // 
            // labelX6
            // 
            this.labelX6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX6.Location = new System.Drawing.Point(209, 130);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(83, 19);
            this.labelX6.TabIndex = 11;
            this.labelX6.Text = "SL Hàng";
            // 
            // txtslhang
            // 
            this.txtslhang.Location = new System.Drawing.Point(307, 130);
            this.txtslhang.Name = "txtslhang";
            this.txtslhang.Size = new System.Drawing.Size(168, 20);
            this.txtslhang.TabIndex = 15;
            // 
            // labelX7
            // 
            this.labelX7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX7.Location = new System.Drawing.Point(209, 155);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(83, 19);
            this.labelX7.TabIndex = 11;
            this.labelX7.Text = "Đơn giá bán";
            // 
            // txtdongia
            // 
            this.txtdongia.Location = new System.Drawing.Point(307, 155);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(168, 20);
            this.txtdongia.TabIndex = 15;
            // 
            // labelX8
            // 
            this.labelX8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX8.Location = new System.Drawing.Point(209, 182);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(83, 19);
            this.labelX8.TabIndex = 11;
            this.labelX8.Text = "TT bảo hành";
            // 
            // txtbaohanh
            // 
            this.txtbaohanh.Location = new System.Drawing.Point(307, 181);
            this.txtbaohanh.Name = "txtbaohanh";
            this.txtbaohanh.Size = new System.Drawing.Size(168, 20);
            this.txtbaohanh.TabIndex = 15;
            // 
            // fHangHoa
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(776, 442);
            this.Controls.Add(this.txtbaohanh);
            this.Controls.Add(this.txtdongia);
            this.Controls.Add(this.txtslhang);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reflectionLabel1);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX8);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.btthemNCC);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtdvtinh);
            this.Controls.Add(this.txtdacta);
            this.Controls.Add(this.txttensp);
            this.Controls.Add(this.txtmasp);
            this.Controls.Add(this.cmbNCC);
            this.Controls.Add(this.treeviewNCC);
            this.Name = "FHangHoa";
            this.Text = "HangHoa";
            this.Load += new System.EventHandler(this.fThongTinSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeviewNCC;
        private System.Windows.Forms.TextBox txtdvtinh;
        private System.Windows.Forms.TextBox txtdacta;
        private System.Windows.Forms.TextBox txttensp;
        private System.Windows.Forms.TextBox txtmasp;
        private System.Windows.Forms.ComboBox cmbNCC;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevComponents.DotNetBar.ButtonX btthemNCC;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.ButtonX btXthem;
        private DevComponents.DotNetBar.ButtonX btXluu;
        private DevComponents.DotNetBar.ButtonX btXxoa;
        private DevComponents.DotNetBar.ButtonX btXcapnhat;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        private DevComponents.DotNetBar.ButtonX btthoat;
        private DevComponents.DotNetBar.ButtonX bthuy;
        private DevComponents.DotNetBar.ButtonX btinhanghoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ImageList imageList1;
        private DevComponents.DotNetBar.LabelX labelX6;
        private System.Windows.Forms.TextBox txtslhang;
        private DevComponents.DotNetBar.LabelX labelX7;
        private System.Windows.Forms.TextBox txtdongia;
        private DevComponents.DotNetBar.LabelX labelX8;
        private System.Windows.Forms.TextBox txtbaohanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmasp;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colslhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbaohanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldvtinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmota;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmancc;
    }
}