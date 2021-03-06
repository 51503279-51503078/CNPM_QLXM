using System;
using System.Collections.Generic;

using System.Windows.Forms;

using QLCuaHangXe.DataLayer;
using QLCuaHangXe.Businessobject;

namespace QLCuaHangXe
{
    public partial class FDoiMk : DevComponents.DotNetBar.Office2007Form
    {
        public FDoiMk()
        {
            InitializeComponent();
        }

        private void fDoiMK_Load(object sender, EventArgs e)
        {
            DataService.OpenConnection();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                CDoiMk us = new CDoiMk
                {
                    TaiKhoan = txtusername.Text,
                    MatKhau = txtpsshientai.Text
                };
                string newpass = txtnewpass1.Text;
                if (newpass != txtnewpass2.Text)
                {
                    MessageBox.Show(@"Mật khẩu xác nhận không đúng", @"Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtnewpass1.Focus();
                }
                else
                {
                    if (new CDoiMKdata().Doimatkhau(us, newpass))
                    {
                        MessageBox.Show(@"Đổi mật khẩu thành công", @"Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(@"Mật khẩu hiện tại không đúng", @"Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtpsshientai.Focus();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show(@"Error");
                throw;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}