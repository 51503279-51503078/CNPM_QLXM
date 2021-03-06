using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QLCuaHangXe.DataLayer;

namespace QLCuaHangXe
{
    public partial class fPhucHoiDL : DevComponents.DotNetBar.Office2007Form
    {
        public fPhucHoiDL()
        {
            InitializeComponent();
        }

        private void btDuongDan_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "File database|*.db";
            open.Title = "Phuc Hoi CSDL";
            DialogResult r = open.ShowDialog();
            if (r == DialogResult.OK)
                this.txtDuongDan.Text = open.FileName;
            if (txtDuongDan.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đường dẫn!", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDuongDan.Text = "C:\\bkdbHSGV" + ".db";
            }
        }

        private void btBoQua_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        SaoLuuPhucHoiData csdl = new SaoLuuPhucHoiData();
        public int i = 0;
        private void btDongY_Click(object sender, EventArgs e)
        {
            if (csdl.PhucHoiDuLieu(txtDuongDan.Text))
            {
                this.Close();
                i = 1;
            }
        }

        private void fPhucHoiDL_Load(object sender, EventArgs e)
        {
            txtDuongDan.Text = "C:\\bkdbHSGV" + ".db";
            txtDuongDan.Focus();
        }
    }
}