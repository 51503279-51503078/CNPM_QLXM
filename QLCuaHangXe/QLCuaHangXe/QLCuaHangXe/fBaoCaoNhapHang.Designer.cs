namespace QLCuaHangXe
{
    partial class FBaoCaoNhapHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FBaoCaoNhapHang));
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
            this.crtReportView1.AutoSize = true;
            this.crtReportView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crtReportView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crtReportView1.Location = new System.Drawing.Point(0, 0);
            this.crtReportView1.Name = "crtReportView1";
            this.crtReportView1.SelectionFormula = "";
            this.crtReportView1.Size = new System.Drawing.Size(860, 356);
            this.crtReportView1.TabIndex = 14;
            this.crtReportView1.ViewTimeSelectionFormula = "";
            // 
            // btnXem
            // 
            this.btnXem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.Image = ((System.Drawing.Image)(resources.GetObject("btnXem.Image")));
            this.btnXem.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnXem.Location = new System.Drawing.Point(28, 199);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(85, 27);
            this.btnXem.TabIndex = 32;
            this.btnXem.Text = "Xem";
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Tháng";
            // 
            // cmbThang
            // 
            this.cmbThang.DisplayMember = "Text";
            this.cmbThang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbThang.FormattingEnabled = true;
            this.cmbThang.ItemHeight = 20;
            this.cmbThang.Location = new System.Drawing.Point(72, 103);
            this.cmbThang.Name = "cmbThang";
            this.cmbThang.Size = new System.Drawing.Size(64, 26);
            this.cmbThang.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Năm";
            // 
            // cmbNam
            // 
            this.cmbNam.DisplayMember = "Text";
            this.cmbNam.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNam.FormattingEnabled = true;
            this.cmbNam.ItemHeight = 20;
            this.cmbNam.Location = new System.Drawing.Point(72, 154);
            this.cmbNam.Name = "cmbNam";
            this.cmbNam.Size = new System.Drawing.Size(64, 26);
            this.cmbNam.TabIndex = 35;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Image = global::QLCuaHangXe.Properties.Resources._1075;
            this.buttonX1.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.buttonX1.Location = new System.Drawing.Point(28, 249);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(85, 27);
            this.buttonX1.TabIndex = 43;
            this.buttonX1.Text = "Thoát";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // fBaoCaoNhapHang
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(860, 356);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbNam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbThang);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.crtReportView1);
            this.DoubleBuffered = true;
            this.Name = "FBaoCaoNhapHang";
            this.Text = "BaoCaoNhapHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fBaoCaoNhapHang_Load);
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