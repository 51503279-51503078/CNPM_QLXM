namespace QLCuaHangXe
{
    partial class FBaoCaoXuatHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FBaoCaoXuatHang));
            this.crtReportView1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnXem = new DevComponents.DotNetBar.ButtonX();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbThang = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbNam = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // crtReportView1
            // 
            this.crtReportView1.ActiveViewIndex = -1;
            this.crtReportView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crtReportView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crtReportView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crtReportView1.Location = new System.Drawing.Point(0, 0);
            this.crtReportView1.Name = "crtReportView1";
            this.crtReportView1.SelectionFormula = "";
            this.crtReportView1.Size = new System.Drawing.Size(756, 368);
            this.crtReportView1.TabIndex = 8;
            this.crtReportView1.ViewTimeSelectionFormula = "";
            // 
            // btnXem
            // 
            this.btnXem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.Image = ((System.Drawing.Image)(resources.GetObject("btnXem.Image")));
            this.btnXem.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnXem.Location = new System.Drawing.Point(39, 225);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(76, 27);
            this.btnXem.TabIndex = 37;
            this.btnXem.Text = "Xem";
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Tháng";
            // 
            // cmbThang
            // 
            this.cmbThang.DisplayMember = "Text";
            this.cmbThang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbThang.FormattingEnabled = true;
            this.cmbThang.ItemHeight = 20;
            this.cmbThang.Location = new System.Drawing.Point(72, 101);
            this.cmbThang.Name = "cmbThang";
            this.cmbThang.Size = new System.Drawing.Size(62, 26);
            this.cmbThang.TabIndex = 38;
            this.cmbThang.SelectedIndexChanged += new System.EventHandler(this.cmbThang_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "Năm";
            // 
            // cmbNam
            // 
            this.cmbNam.DisplayMember = "Text";
            this.cmbNam.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNam.FormattingEnabled = true;
            this.cmbNam.ItemHeight = 20;
            this.cmbNam.Location = new System.Drawing.Point(72, 155);
            this.cmbNam.Name = "cmbNam";
            this.cmbNam.Size = new System.Drawing.Size(62, 26);
            this.cmbNam.TabIndex = 40;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Image = global::QLCuaHangXe.Properties.Resources._1075;
            this.buttonX1.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.buttonX1.Location = new System.Drawing.Point(39, 279);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(76, 27);
            this.buttonX1.TabIndex = 44;
            this.buttonX1.Text = "Thoát";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // FBaoCaoXuatHang
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(756, 368);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbNam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbThang);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.crtReportView1);
            this.DoubleBuffered = true;
            this.Name = "FBaoCaoXuatHang";
            this.Text = "BaoCaoXuatHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fBaoCaoXuatHang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crtReportView1;
        private DevComponents.DotNetBar.ButtonX btnXem;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbThang;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbNam;
        private DevComponents.DotNetBar.ButtonX buttonX1;
    }
}