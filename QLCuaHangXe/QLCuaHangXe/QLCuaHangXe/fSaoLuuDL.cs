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
    public partial class fSaoLuuDL : DevComponents.DotNetBar.Office2007Form
    {
        public fSaoLuuDL()
        {
            InitializeComponent();
        }

        private void btDuongDan_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "File database|*.db";
            save.Title = "Sao Luu CSDL";
            DialogResult r = save.ShowDialog();
            if (r == DialogResult.OK)
                this.txtDuongDan.Text = save.FileName;
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
        private void btDongY_Click(object sender, EventArgs e)
        {
            if (csdl.SaoLuuDuLieu(txtDuongDan.Text))
            this.Close();
        }
    }
}