namespace QLCuaHangXe
{
    partial class FHangBanChay
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.cmbnam = new System.Windows.Forms.ComboBox();
            this.cmbthang = new System.Windows.Forms.ComboBox();
            this.btbaocao = new DevComponents.DotNetBar.ButtonX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.SelectionFormula = "";
            this.crystalReportViewer1.Size = new System.Drawing.Size(924, 382);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ViewTimeSelectionFormula = "";
            // 
            // cmbnam
            // 
            this.cmbnam.FormattingEnabled = true;
            this.cmbnam.Location = new System.Drawing.Point(65, 95);
            this.cmbnam.Name = "cmbnam";
            this.cmbnam.Size = new System.Drawing.Size(62, 21);
            this.cmbnam.TabIndex = 41;
            this.cmbnam.SelectedIndexChanged += new System.EventHandler(this.cmbnam_SelectedIndexChanged);
            // 
            // cmbthang
            // 
            this.cmbthang.FormattingEnabled = true;
            this.cmbthang.Location = new System.Drawing.Point(65, 51);
            this.cmbthang.Name = "cmbthang";
            this.cmbthang.Size = new System.Drawing.Size(62, 21);
            this.cmbthang.TabIndex = 40;
            // 
            // btbaocao
            // 
            this.btbaocao.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btbaocao.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btbaocao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbaocao.Image = global::QLCuaHangXe.Properties.Resources.write_document;
            this.btbaocao.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.btbaocao.Location = new System.Drawing.Point(30, 157);
            this.btbaocao.Name = "btbaocao";
            this.btbaocao.Size = new System.Drawing.Size(85, 26);
            this.btbaocao.TabIndex = 39;
            this.btbaocao.Text = "Xem";
            this.btbaocao.Click += new System.EventHandler(this.btbaocao_Click);
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.White;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(19, 93);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(40, 23);
            this.labelX3.TabIndex = 38;
            this.labelX3.Text = "Năm";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.White;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(19, 52);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(40, 23);
            this.labelX2.TabIndex = 37;
            this.labelX2.Text = "Tháng";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Image = global::QLCuaHangXe.Properties.Resources._1075;
            this.buttonX1.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.buttonX1.Location = new System.Drawing.Point(30, 215);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(85, 27);
            this.buttonX1.TabIndex = 44;
            this.buttonX1.Text = "Thoát";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // fHangBanChay
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(924, 382);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.cmbnam);
            this.Controls.Add(this.cmbthang);
            this.Controls.Add(this.btbaocao);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.crystalReportViewer1);
            this.DoubleBuffered = true;
            this.Name = "FHangBanChay";
            this.Text = "fHangBanChay";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fHangBanChay_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.ComboBox cmbnam;
        private System.Windows.Forms.ComboBox cmbthang;
        private DevComponents.DotNetBar.ButtonX btbaocao;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ButtonX buttonX1;
    }
}