namespace QLCuaHangXe
{
    partial class fSaoLuuDL
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
            this.txtDuongDan = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btDuongDan = new DevComponents.DotNetBar.ButtonX();
            this.btBoQua = new DevComponents.DotNetBar.ButtonX();
            this.btDongY = new DevComponents.DotNetBar.ButtonX();
            this.labelXDuongDan = new DevComponents.DotNetBar.LabelX();
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.SuspendLayout();
            // 
            // txtDuongDan
            // 
            // 
            // 
            // 
            this.txtDuongDan.Border.Class = "TextBoxBorder";
            this.txtDuongDan.Location = new System.Drawing.Point(88, 78);
            this.txtDuongDan.Name = "txtDuongDan";
            this.txtDuongDan.Size = new System.Drawing.Size(293, 20);
            this.txtDuongDan.TabIndex = 36;
            // 
            // btDuongDan
            // 
            this.btDuongDan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btDuongDan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btDuongDan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDuongDan.Location = new System.Drawing.Point(387, 78);
            this.btDuongDan.Name = "btDuongDan";
            this.btDuongDan.Size = new System.Drawing.Size(30, 20);
            this.btDuongDan.TabIndex = 33;
            this.btDuongDan.Text = "...";
            this.btDuongDan.Click += new System.EventHandler(this.btDuongDan_Click);
            // 
            // btBoQua
            // 
            this.btBoQua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btBoQua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btBoQua.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.btBoQua.Location = new System.Drawing.Point(234, 132);
            this.btBoQua.Name = "btBoQua";
            this.btBoQua.Size = new System.Drawing.Size(69, 23);
            this.btBoQua.TabIndex = 35;
            this.btBoQua.Text = "Bỏ qua";
            this.btBoQua.Tooltip = "Bỏ qua";
            this.btBoQua.Click += new System.EventHandler(this.btBoQua_Click);
            // 
            // btDongY
            // 
            this.btDongY.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btDongY.AntiAlias = true;
            this.btDongY.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btDongY.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.btDongY.Location = new System.Drawing.Point(149, 132);
            this.btDongY.Name = "btDongY";
            this.btDongY.Size = new System.Drawing.Size(69, 23);
            this.btDongY.TabIndex = 32;
            this.btDongY.Text = "Đồng ý";
            this.btDongY.Tooltip = "Đồng ý";
            this.btDongY.Click += new System.EventHandler(this.btDongY_Click);
            // 
            // labelXDuongDan
            // 
            this.labelXDuongDan.BackColor = System.Drawing.Color.Transparent;
            this.labelXDuongDan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXDuongDan.Location = new System.Drawing.Point(16, 78);
            this.labelXDuongDan.Name = "labelXDuongDan";
            this.labelXDuongDan.Size = new System.Drawing.Size(75, 20);
            this.labelXDuongDan.TabIndex = 34;
            this.labelXDuongDan.Text = "Đường dẫn:";
            // 
            // reflectionLabel1
            // 
            this.reflectionLabel1.BackColor = System.Drawing.Color.White;
            this.reflectionLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reflectionLabel1.Location = new System.Drawing.Point(-1, -1);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(192, 49);
            this.reflectionLabel1.TabIndex = 31;
            this.reflectionLabel1.Text = "<b><font color=\"RED\">Sao Lưu CSDL</font></b>";
            // 
            // fSaoLuuDL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLCuaHangXe.Properties.Resources.subaru_wrc_concep;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(437, 171);
            this.Controls.Add(this.txtDuongDan);
            this.Controls.Add(this.btDuongDan);
            this.Controls.Add(this.btBoQua);
            this.Controls.Add(this.btDongY);
            this.Controls.Add(this.labelXDuongDan);
            this.Controls.Add(this.reflectionLabel1);
            this.Name = "fSaoLuuDL";
            this.Text = "Sao Luu DL";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txtDuongDan;
        private DevComponents.DotNetBar.ButtonX btDuongDan;
        private DevComponents.DotNetBar.ButtonX btBoQua;
        private DevComponents.DotNetBar.ButtonX btDongY;
        private DevComponents.DotNetBar.LabelX labelXDuongDan;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
    }
}