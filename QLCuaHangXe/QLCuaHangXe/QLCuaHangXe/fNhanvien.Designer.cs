namespace QLCuaHangXe
{
    partial class fNhanvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fNhanvien));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colmanv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltennv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colns = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colgt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colchucvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collcb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupgt = new System.Windows.Forms.GroupBox();
            this.radnu = new System.Windows.Forms.RadioButton();
            this.radnam = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtns = new System.Windows.Forms.TextBox();
            this.txtluong = new System.Windows.Forms.TextBox();
            this.txtchv = new System.Windows.Forms.TextBox();
            this.txtdt = new System.Windows.Forms.TextBox();
            this.txtdc = new System.Windows.Forms.TextBox();
            this.txttennv = new System.Windows.Forms.TextBox();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bttimma = new DevComponents.DotNetBar.ButtonX();
            this.bttimten = new DevComponents.DotNetBar.ButtonX();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtten = new System.Windows.Forms.TextBox();
            this.txtma = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnIn = new DevComponents.DotNetBar.ButtonX();
            this.btThoat = new DevComponents.DotNetBar.ButtonX();
            this.btHuy = new DevComponents.DotNetBar.ButtonX();
            this.btLuu = new DevComponents.DotNetBar.ButtonX();
            this.btXoa = new DevComponents.DotNetBar.ButtonX();
            this.btSua = new DevComponents.DotNetBar.ButtonX();
            this.btThem = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupgt.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colmanv,
            this.coltennv,
            this.colns,
            this.colgt,
            this.coldt,
            this.coldc,
            this.colchucvu,
            this.collcb});
            this.dataGridView1.Location = new System.Drawing.Point(14, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(920, 176);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // colmanv
            // 
            this.colmanv.DataPropertyName = "MANHANVIEN";
            this.colmanv.HeaderText = "Mã nhân viên";
            this.colmanv.Name = "colmanv";
            this.colmanv.ReadOnly = true;
            // 
            // coltennv
            // 
            this.coltennv.DataPropertyName = "TENNHANVIEN";
            this.coltennv.HeaderText = "Tên nhân viên";
            this.coltennv.Name = "coltennv";
            this.coltennv.ReadOnly = true;
            this.coltennv.Width = 160;
            // 
            // colns
            // 
            this.colns.DataPropertyName = "NAMSINH";
            this.colns.HeaderText = "Năm sinh";
            this.colns.Name = "colns";
            this.colns.ReadOnly = true;
            // 
            // colgt
            // 
            this.colgt.DataPropertyName = "GIOITINH";
            this.colgt.HeaderText = "Giới tính";
            this.colgt.Name = "colgt";
            this.colgt.ReadOnly = true;
            this.colgt.Width = 80;
            // 
            // coldt
            // 
            this.coldt.DataPropertyName = "DIENTHOAI";
            this.coldt.HeaderText = "Điện thoại";
            this.coldt.Name = "coldt";
            this.coldt.ReadOnly = true;
            // 
            // coldc
            // 
            this.coldc.DataPropertyName = "DIACHI";
            this.coldc.HeaderText = "Địa chỉ";
            this.coldc.Name = "coldc";
            this.coldc.ReadOnly = true;
            this.coldc.Width = 80;
            // 
            // colchucvu
            // 
            this.colchucvu.DataPropertyName = "CHUCVU";
            this.colchucvu.HeaderText = "Chức vụ";
            this.colchucvu.Name = "colchucvu";
            this.colchucvu.ReadOnly = true;
            // 
            // collcb
            // 
            this.collcb.DataPropertyName = "LUONGCOBAN";
            this.collcb.HeaderText = "Lương cơ bản";
            this.collcb.Name = "collcb";
            this.collcb.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupgt);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtns);
            this.groupBox1.Controls.Add(this.txtluong);
            this.groupBox1.Controls.Add(this.txtchv);
            this.groupBox1.Controls.Add(this.txtdt);
            this.groupBox1.Controls.Add(this.txtdc);
            this.groupBox1.Controls.Add(this.txttennv);
            this.groupBox1.Controls.Add(this.txtmanv);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(671, 165);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Nhân Viên";
            // 
            // groupgt
            // 
            this.groupgt.Controls.Add(this.radnu);
            this.groupgt.Controls.Add(this.radnam);
            this.groupgt.Location = new System.Drawing.Point(296, 122);
            this.groupgt.Name = "groupgt";
            this.groupgt.Size = new System.Drawing.Size(135, 31);
            this.groupgt.TabIndex = 20;
            this.groupgt.TabStop = false;
            // 
            // radnu
            // 
            this.radnu.AutoSize = true;
            this.radnu.Location = new System.Drawing.Point(75, 8);
            this.radnu.Name = "radnu";
            this.radnu.Size = new System.Drawing.Size(43, 20);
            this.radnu.TabIndex = 19;
            this.radnu.TabStop = true;
            this.radnu.Text = "Nữ";
            this.radnu.UseVisualStyleBackColor = true;
            // 
            // radnam
            // 
            this.radnam.AutoSize = true;
            this.radnam.Location = new System.Drawing.Point(12, 8);
            this.radnam.Name = "radnam";
            this.radnam.Size = new System.Drawing.Size(55, 20);
            this.radnam.TabIndex = 18;
            this.radnam.TabStop = true;
            this.radnam.Text = "Nam";
            this.radnam.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(222, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Giới tính";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Năm sinh";
            // 
            // txtns
            // 
            this.txtns.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtns.Location = new System.Drawing.Point(80, 131);
            this.txtns.Name = "txtns";
            this.txtns.Size = new System.Drawing.Size(135, 22);
            this.txtns.TabIndex = 14;
            this.txtns.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtns_KeyPress);
            // 
            // txtluong
            // 
            this.txtluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtluong.Location = new System.Drawing.Point(487, 78);
            this.txtluong.Name = "txtluong";
            this.txtluong.Size = new System.Drawing.Size(135, 22);
            this.txtluong.TabIndex = 13;
            this.txtluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtluong_KeyPress);
            // 
            // txtchv
            // 
            this.txtchv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtchv.Location = new System.Drawing.Point(487, 35);
            this.txtchv.Name = "txtchv";
            this.txtchv.Size = new System.Drawing.Size(135, 22);
            this.txtchv.TabIndex = 12;
            // 
            // txtdt
            // 
            this.txtdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdt.Location = new System.Drawing.Point(296, 79);
            this.txtdt.Name = "txtdt";
            this.txtdt.Size = new System.Drawing.Size(133, 22);
            this.txtdt.TabIndex = 10;
            this.txtdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdt_KeyPress);
            // 
            // txtdc
            // 
            this.txtdc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdc.Location = new System.Drawing.Point(296, 35);
            this.txtdc.Name = "txtdc";
            this.txtdc.Size = new System.Drawing.Size(133, 22);
            this.txtdc.TabIndex = 9;
            // 
            // txttennv
            // 
            this.txttennv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttennv.Location = new System.Drawing.Point(80, 82);
            this.txttennv.Name = "txttennv";
            this.txttennv.Size = new System.Drawing.Size(135, 22);
            this.txttennv.TabIndex = 8;
            // 
            // txtmanv
            // 
            this.txtmanv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmanv.Location = new System.Drawing.Point(80, 32);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.ReadOnly = true;
            this.txtmanv.Size = new System.Drawing.Size(134, 22);
            this.txtmanv.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(435, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Lương";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(432, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Chức vụ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(222, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Điện Thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(230, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa Chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên NV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã NV";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bttimma);
            this.groupBox2.Controls.Add(this.bttimten);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtten);
            this.groupBox2.Controls.Add(this.txtma);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(691, -1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 165);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Kiếm";
            // 
            // bttimma
            // 
            this.bttimma.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bttimma.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bttimma.Image = ((System.Drawing.Image)(resources.GetObject("bttimma.Image")));
            this.bttimma.Location = new System.Drawing.Point(167, 51);
            this.bttimma.Name = "bttimma";
            this.bttimma.Size = new System.Drawing.Size(70, 22);
            this.bttimma.TabIndex = 5;
            this.bttimma.Click += new System.EventHandler(this.bttimma_Click);
            // 
            // bttimten
            // 
            this.bttimten.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bttimten.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bttimten.Image = ((System.Drawing.Image)(resources.GetObject("bttimten.Image")));
            this.bttimten.Location = new System.Drawing.Point(167, 128);
            this.bttimten.Name = "bttimten";
            this.bttimten.Size = new System.Drawing.Size(70, 22);
            this.bttimten.TabIndex = 5;
            this.bttimten.Click += new System.EventHandler(this.bttimten_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "Tìm Theo Mã";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 16);
            this.label10.TabIndex = 4;
            this.label10.Text = "Tìm Theo Tên";
            // 
            // txtten
            // 
            this.txtten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtten.Location = new System.Drawing.Point(11, 128);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(142, 22);
            this.txtten.TabIndex = 3;
            // 
            // txtma
            // 
            this.txtma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtma.Location = new System.Drawing.Point(14, 51);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(139, 22);
            this.txtma.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnIn);
            this.groupBox3.Controls.Add(this.btThoat);
            this.groupBox3.Controls.Add(this.btHuy);
            this.groupBox3.Controls.Add(this.btLuu);
            this.groupBox3.Controls.Add(this.btXoa);
            this.groupBox3.Controls.Add(this.btSua);
            this.groupBox3.Controls.Add(this.btThem);
            this.groupBox3.Location = new System.Drawing.Point(12, 352);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(922, 57);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thao tác";
            // 
            // btnIn
            // 
            this.btnIn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnIn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.Image")));
            this.btnIn.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnIn.Location = new System.Drawing.Point(589, 19);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(120, 33);
            this.btnIn.TabIndex = 29;
            this.btnIn.Text = "In Danh Sách";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btThoat
            // 
            this.btThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Image = ((System.Drawing.Image)(resources.GetObject("btThoat.Image")));
            this.btThoat.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btThoat.Location = new System.Drawing.Point(808, 19);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(105, 33);
            this.btThoat.TabIndex = 26;
            this.btThoat.Text = "Thoát";
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btHuy
            // 
            this.btHuy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btHuy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHuy.Image = ((System.Drawing.Image)(resources.GetObject("btHuy.Image")));
            this.btHuy.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btHuy.Location = new System.Drawing.Point(472, 18);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(105, 32);
            this.btHuy.TabIndex = 27;
            this.btHuy.Text = "Hủy";
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // btLuu
            // 
            this.btLuu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btLuu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLuu.Image = ((System.Drawing.Image)(resources.GetObject("btLuu.Image")));
            this.btLuu.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btLuu.Location = new System.Drawing.Point(354, 18);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(105, 33);
            this.btLuu.TabIndex = 23;
            this.btLuu.Text = "Lưu";
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btXoa
            // 
            this.btXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Image = ((System.Drawing.Image)(resources.GetObject("btXoa.Image")));
            this.btXoa.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btXoa.Location = new System.Drawing.Point(239, 19);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(105, 33);
            this.btXoa.TabIndex = 24;
            this.btXoa.Text = "Xóa";
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btSua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.Image = ((System.Drawing.Image)(resources.GetObject("btSua.Image")));
            this.btSua.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btSua.Location = new System.Drawing.Point(122, 18);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(105, 33);
            this.btSua.TabIndex = 25;
            this.btSua.Text = "Sửa";
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btThem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Image = ((System.Drawing.Image)(resources.GetObject("btThem.Image")));
            this.btThem.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btThem.Location = new System.Drawing.Point(9, 18);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(105, 33);
            this.btThem.TabIndex = 28;
            this.btThem.Text = "Thêm";
            this.btThem.Click += new System.EventHandler(this.btThem_Click_1);
            // 
            // fNhanvien
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(946, 421);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "fNhanvien";
            this.Text = "Nhanvien";
            this.Load += new System.EventHandler(this.fNhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupgt.ResumeLayout(false);
            this.groupgt.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtchv;
        private System.Windows.Forms.TextBox txtdt;
        private System.Windows.Forms.TextBox txtdc;
        private System.Windows.Forms.TextBox txttennv;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtns;
        private System.Windows.Forms.TextBox txtluong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupgt;
        private System.Windows.Forms.RadioButton radnu;
        private System.Windows.Forms.RadioButton radnam;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmanv;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltennv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colns;
        private System.Windows.Forms.DataGridViewTextBoxColumn colgt;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldt;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colchucvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn collcb;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.ButtonX bttimma;
        private DevComponents.DotNetBar.ButtonX bttimten;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevComponents.DotNetBar.ButtonX btnIn;
        private DevComponents.DotNetBar.ButtonX btThoat;
        private DevComponents.DotNetBar.ButtonX btHuy;
        private DevComponents.DotNetBar.ButtonX btLuu;
        private DevComponents.DotNetBar.ButtonX btXoa;
        private DevComponents.DotNetBar.ButtonX btSua;
        private DevComponents.DotNetBar.ButtonX btThem;
    }
}