namespace QLCuaHangXe
{
    partial class fInDSHangHoa
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
            this.crtReportView1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crtReportView1
            // 
            this.crtReportView1.ActiveViewIndex = -1;
            this.crtReportView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crtReportView1.DisplayGroupTree = false;
            this.crtReportView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crtReportView1.Location = new System.Drawing.Point(0, 0);
            this.crtReportView1.Name = "crtReportView1";
            this.crtReportView1.SelectionFormula = "";
            this.crtReportView1.ShowGroupTreeButton = false;
            this.crtReportView1.Size = new System.Drawing.Size(797, 422);
            this.crtReportView1.TabIndex = 2;
            this.crtReportView1.ViewTimeSelectionFormula = "";
            // 
            // fInDSHangHoa
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(797, 422);
            this.Controls.Add(this.crtReportView1);
            this.DoubleBuffered = true;
            this.Name = "fInDSHangHoa";
            this.Text = "DSHangHoa";
            this.Load += new System.EventHandler(this.fInDSHangHoa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crtReportView1;
    }
}