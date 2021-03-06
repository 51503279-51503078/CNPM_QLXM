namespace QLCuaHangXe
{
    partial class FNhatKy
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colmank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colthoigian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colnoidung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collydo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btthoat = new DevComponents.DotNetBar.ButtonX();
            this.btTimTuyChon = new DevComponents.DotNetBar.ButtonX();
            this.btTimTatCa = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.cmbTaikhoan = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.checkNhanVien = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.checkNam = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.checkThang = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.dtTuNgay = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.checkNgay = new DevComponents.DotNetBar.Controls.CheckBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.groupPanel3.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtTuNgay)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colmank,
            this.colten,
            this.colthoigian,
            this.colnoidung,
            this.collydo});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(254, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(524, 416);
            this.dataGridView1.TabIndex = 0;
            // 
            // colmank
            // 
            this.colmank.DataPropertyName = "MANK";
            this.colmank.HeaderText = "Mã Nhật Ký";
            this.colmank.Name = "colmank";
            // 
            // colten
            // 
            this.colten.DataPropertyName = "TAIKHOAN";
            this.colten.HeaderText = "Tên";
            this.colten.Name = "colten";
            // 
            // colthoigian
            // 
            this.colthoigian.DataPropertyName = "THOIGIAN";
            this.colthoigian.HeaderText = "Thời Gian";
            this.colthoigian.Name = "colthoigian";
            // 
            // colnoidung
            // 
            this.colnoidung.DataPropertyName = "NOIDUNG";
            this.colnoidung.HeaderText = "Nội Dung";
            this.colnoidung.Name = "colnoidung";
            // 
            // collydo
            // 
            this.collydo.DataPropertyName = "LYDO";
            this.collydo.HeaderText = "Lý Do";
            this.collydo.Name = "collydo";
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.btthoat);
            this.groupPanel1.Controls.Add(this.btTimTuyChon);
            this.groupPanel1.Controls.Add(this.btTimTatCa);
            this.groupPanel1.Controls.Add(this.groupPanel3);
            this.groupPanel1.Controls.Add(this.groupPanel2);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(248, 416);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel1.TabIndex = 1;
            this.groupPanel1.Text = "Các Lực Chọn Tìm Kiếm";
            // 
            // btthoat
            // 
            this.btthoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btthoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthoat.Location = new System.Drawing.Point(116, 309);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(103, 23);
            this.btthoat.TabIndex = 6;
            this.btthoat.Text = "&Thoát";
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // btTimTuyChon
            // 
            this.btTimTuyChon.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btTimTuyChon.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btTimTuyChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTimTuyChon.Location = new System.Drawing.Point(116, 281);
            this.btTimTuyChon.Name = "btTimTuyChon";
            this.btTimTuyChon.Size = new System.Drawing.Size(103, 22);
            this.btTimTuyChon.TabIndex = 5;
            this.btTimTuyChon.Text = "Tìm Tùy Chọn";
            this.btTimTuyChon.Click += new System.EventHandler(this.btTimTuyChon_Click);
            // 
            // btTimTatCa
            // 
            this.btTimTatCa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btTimTatCa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btTimTatCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTimTatCa.Location = new System.Drawing.Point(22, 281);
            this.btTimTatCa.Name = "btTimTatCa";
            this.btTimTatCa.Size = new System.Drawing.Size(68, 22);
            this.btTimTatCa.TabIndex = 4;
            this.btTimTatCa.Text = "Tìm Tất Cả";
            this.btTimTatCa.Click += new System.EventHandler(this.btTimTatCa_Click);
            // 
            // groupPanel3
            // 
            this.groupPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel3.Controls.Add(this.labelX2);
            this.groupPanel3.Controls.Add(this.cmbTaikhoan);
            this.groupPanel3.Controls.Add(this.checkNhanVien);
            this.groupPanel3.Location = new System.Drawing.Point(22, 177);
            this.groupPanel3.Name = "groupPanel3";
            this.groupPanel3.Size = new System.Drawing.Size(197, 83);
            // 
            // 
            // 
            this.groupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel3.Style.BackColorGradientAngle = 90;
            this.groupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderBottomWidth = 1;
            this.groupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderLeftWidth = 1;
            this.groupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderRightWidth = 1;
            this.groupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderTopWidth = 1;
            this.groupPanel3.Style.CornerDiameter = 4;
            this.groupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel3.TabIndex = 3;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            this.labelX2.Location = new System.Drawing.Point(3, 32);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(61, 18);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Nhân Viên";
            // 
            // cmbTaikhoan
            // 
            this.cmbTaikhoan.DisplayMember = "Text";
            this.cmbTaikhoan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTaikhoan.FormattingEnabled = true;
            this.cmbTaikhoan.ItemHeight = 14;
            this.cmbTaikhoan.Location = new System.Drawing.Point(65, 32);
            this.cmbTaikhoan.Name = "cmbTaikhoan";
            this.cmbTaikhoan.Size = new System.Drawing.Size(125, 20);
            this.cmbTaikhoan.TabIndex = 1;
            // 
            // checkNhanVien
            // 
            this.checkNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.checkNhanVien.Location = new System.Drawing.Point(13, 3);
            this.checkNhanVien.Name = "checkNhanVien";
            this.checkNhanVien.Size = new System.Drawing.Size(140, 23);
            this.checkNhanVien.TabIndex = 0;
            this.checkNhanVien.Text = "Theo Tên Nhân Viên";
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.checkNam);
            this.groupPanel2.Controls.Add(this.checkThang);
            this.groupPanel2.Controls.Add(this.dtTuNgay);
            this.groupPanel2.Controls.Add(this.labelX3);
            this.groupPanel2.Controls.Add(this.checkNgay);
            this.groupPanel2.DrawTitleBox = false;
            this.groupPanel2.Location = new System.Drawing.Point(22, 74);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(197, 97);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel2.TabIndex = 2;
            // 
            // checkNam
            // 
            this.checkNam.BackColor = System.Drawing.Color.Transparent;
            this.checkNam.Location = new System.Drawing.Point(129, 17);
            this.checkNam.Name = "checkNam";
            this.checkNam.Size = new System.Drawing.Size(56, 26);
            this.checkNam.TabIndex = 3;
            this.checkNam.Text = "Năm";
            // 
            // checkThang
            // 
            this.checkThang.BackColor = System.Drawing.Color.Transparent;
            this.checkThang.Location = new System.Drawing.Point(68, 18);
            this.checkThang.Name = "checkThang";
            this.checkThang.Size = new System.Drawing.Size(55, 25);
            this.checkThang.TabIndex = 3;
            this.checkThang.Text = "Tháng";
            // 
            // dtTuNgay
            // 
            // 
            // 
            // 
            this.dtTuNgay.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtTuNgay.ButtonDropDown.Visible = true;
            this.dtTuNgay.Location = new System.Drawing.Point(85, 58);
            // 
            // 
            // 
            this.dtTuNgay.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtTuNgay.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtTuNgay.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtTuNgay.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtTuNgay.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtTuNgay.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtTuNgay.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtTuNgay.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtTuNgay.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtTuNgay.MonthCalendar.DisplayMonth = new System.DateTime(2009, 3, 1, 0, 0, 0, 0);
            this.dtTuNgay.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtTuNgay.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtTuNgay.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtTuNgay.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtTuNgay.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtTuNgay.MonthCalendar.TodayButtonVisible = true;
            this.dtTuNgay.Name = "dtTuNgay";
            this.dtTuNgay.Size = new System.Drawing.Size(100, 20);
            this.dtTuNgay.TabIndex = 2;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            this.labelX3.Location = new System.Drawing.Point(3, 58);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(61, 24);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "Từ Ngày:";
            // 
            // checkNgay
            // 
            this.checkNgay.BackColor = System.Drawing.Color.Transparent;
            this.checkNgay.Location = new System.Drawing.Point(10, 20);
            this.checkNgay.Name = "checkNgay";
            this.checkNgay.Size = new System.Drawing.Size(52, 23);
            this.checkNgay.TabIndex = 2;
            this.checkNgay.Text = "Ngày";
            // 
            // fNhatKy
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(778, 416);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FNhatKy";
            this.Text = "NhatKy";
            this.Load += new System.EventHandler(this.fNhatKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel3.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtTuNgay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.ButtonX btTimTuyChon;
        private DevComponents.DotNetBar.ButtonX btTimTatCa;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbTaikhoan;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkNhanVien;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkNam;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkThang;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtTuNgay;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkNgay;
        private DevComponents.DotNetBar.ButtonX btthoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmank;
        private System.Windows.Forms.DataGridViewTextBoxColumn colten;
        private System.Windows.Forms.DataGridViewTextBoxColumn colthoigian;
        private System.Windows.Forms.DataGridViewTextBoxColumn colnoidung;
        private System.Windows.Forms.DataGridViewTextBoxColumn collydo;
    }
}