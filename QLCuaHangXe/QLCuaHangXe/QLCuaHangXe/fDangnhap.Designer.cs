namespace QLCuaHangXe
{
    partial class FDangnhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FDangnhap));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.btok = new DevComponents.DotNetBar.ButtonX();
            this.btthoat = new DevComponents.DotNetBar.ButtonX();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.txttendn = new System.Windows.Forms.TextBox();
            this.timer_Clock = new System.Windows.Forms.Timer(this.components);
            this.lblClock = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // labelX1
            // 
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(152, 99);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(98, 29);
            this.labelX1.TabIndex = 5;
            this.labelX1.Text = "Tên Đăng Nhập:";
            // 
            // labelX2
            // 
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(152, 144);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(98, 29);
            this.labelX2.TabIndex = 6;
            this.labelX2.Text = "Mật Khẩu:";
            // 
            // reflectionLabel1
            // 
            this.reflectionLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reflectionLabel1.Location = new System.Drawing.Point(120, 12);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(240, 61);
            this.reflectionLabel1.TabIndex = 4;
            this.reflectionLabel1.Text = "<font color=\"#262626\"><i><b>ĐĂNG NHẬP</b></i></font>";
            // 
            // btok
            // 
            this.btok.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btok.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btok.Image = ((System.Drawing.Image)(resources.GetObject("btok.Image")));
            this.btok.Location = new System.Drawing.Point(175, 197);
            this.btok.Name = "btok";
            this.btok.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btok.Size = new System.Drawing.Size(75, 35);
            this.btok.TabIndex = 2;
            this.btok.Text = "<b>&OK</b>";
            this.btok.Click += new System.EventHandler(this.btok_Click);
            // 
            // btthoat
            // 
            this.btthoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btthoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btthoat.Image = ((System.Drawing.Image)(resources.GetObject("btthoat.Image")));
            this.btthoat.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btthoat.Location = new System.Drawing.Point(285, 197);
            this.btthoat.Name = "btthoat";
            this.btthoat.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btthoat.Size = new System.Drawing.Size(75, 35);
            this.btthoat.TabIndex = 3;
            this.btthoat.Text = "<b>&Thoát</b>";
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(256, 144);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.PasswordChar = '*';
            this.txtmatkhau.Size = new System.Drawing.Size(157, 20);
            this.txtmatkhau.TabIndex = 1;
            // 
            // txttendn
            // 
            this.txttendn.Location = new System.Drawing.Point(256, 104);
            this.txttendn.Name = "txttendn";
            this.txttendn.Size = new System.Drawing.Size(157, 20);
            this.txttendn.TabIndex = 0;
            // 
            // timer_Clock
            // 
            this.timer_Clock.Enabled = true;
            this.timer_Clock.Tick += new System.EventHandler(this.timer_Clock_Tick);
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.Location = new System.Drawing.Point(12, 228);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(0, 13);
            this.lblClock.TabIndex = 9;
            // 
            // fDangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 267);
            this.Controls.Add(this.lblClock);
            this.Controls.Add(this.txttendn);
            this.Controls.Add(this.txtmatkhau);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.btok);
            this.Controls.Add(this.reflectionLabel1);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FDangnhap";
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.fDangnhap_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        private DevComponents.DotNetBar.ButtonX btok;
        private DevComponents.DotNetBar.ButtonX btthoat;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.TextBox txttendn;
        private System.Windows.Forms.Timer timer_Clock;
        private System.Windows.Forms.Label lblClock;
    }
}

