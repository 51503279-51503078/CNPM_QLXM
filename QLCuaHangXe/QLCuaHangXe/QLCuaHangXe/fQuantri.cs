using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Practices.EnterpriseLibrary;
using QLCuaHangXe.DataLayer;
using QLCuaHangXe.Businessobject;
using QLCuaHangXe.Controller;


namespace QLCuaHangXe
{
    public partial class fQuantri : DevComponents.DotNetBar.Office2007Form
    {
        public fQuantri()
        {
            InitializeComponent();
        }

        private void fQuantri_Load(object sender, EventArgs e)
        {
            DataService.OpenConnection();
            new CQuantriCtr().Hienthicmbquyen(cmbQuyen);
            gantext(0);
            txtTK.ReadOnly = true;
            txtMK.ReadOnly = true;
            cmbQuyen.Enabled = false;
            btLuu.Enabled = false;
            btHuy.Enabled = false;
        }

        CQuantridata dt = new CQuantridata();
        public void gantext(int i)
        {
            txtTK.Text = dt.Hienthi().Rows[i][0].ToString();
            txtMK.Text = dt.Hienthi().Rows[i][1].ToString();
            cmbQuyen.DataSource = dt.Hienthi();
            cmbQuyen.ValueMember = "QUYEN";
            cmbQuyen.Text = dt.Hienthi().Rows[i][2].ToString();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int vitri = 0;
        private void btdau_Click(object sender, EventArgs e)
        {
            vitri = 0;
            if (dt.Hienthi() == null) return;
            gantext(vitri);
        }

        private void btcuoi_Click(object sender, EventArgs e)
        {
            if (dt.Hienthi() == null) return;
            vitri = dt.Hienthi().Rows.Count - 1;
            gantext(vitri);
        }

        private void bttruoc_Click(object sender, EventArgs e)
        {
            vitri--;
            if (dt.Hienthi() == null) return;
            if (vitri < 0) vitri = 0;
            gantext(vitri);
        }

        private void btsau_Click(object sender, EventArgs e)
        {
            vitri++;
            if (dt.Hienthi() == null) return;
            if (vitri > dt.Hienthi().Rows.Count - 1)
                vitri = dt.Hienthi().Rows.Count - 1;
            gantext(vitri);
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            if (txtTK.Text == "")
            {
                MessageBox.Show("Hãy Nhập Tên Tài Khoản", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtMK.Text == "")
            {
                MessageBox.Show("Hãy Nhập Mật Khẩu", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                CQuantri obj = new CQuantri();
                obj.Taikhoan = txtTK.Text;
                obj.Matkhau = txtMK.Text;
                obj.Quyen = cmbQuyen.Text;

                if (new CQuantridata().Insertuser(obj) == true)
                {
                    MessageBox.Show("Đã Thêm Tài Khoản Thành Công", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    grChuyen.Enabled = true;
                    gantext(0);
                    txtTK.ReadOnly = true;
                    txtMK.ReadOnly = true;
                    cmbQuyen.Enabled = false;
                    btLuu.Enabled = false;
                    btHuy.Enabled = false;
                    btThem.Enabled = true;
                    btXoa.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            txtTK.Clear();
            txtMK.Clear();
            txtTK.Focus();
            grChuyen.Enabled = false;
            txtTK.ReadOnly = false;
            txtMK.ReadOnly = false;
            cmbQuyen.Enabled = true;
            btLuu.Enabled = true;
            btHuy.Enabled = true;
            btThem.Enabled = false;
            btXoa.Enabled = false;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn Có Thực Sự Muốn Xóa Tài Khoản Này", "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (h.ToString() == "OK")
            {
                CQuantri objec = new CQuantri();
                objec.Taikhoan = txtTK.Text;
                if (new CQuantridata().Xoa(objec) == true)
                {
                    MessageBox.Show("Xóa thành công");
                    gantext(0);
                }
                else
                    MessageBox.Show("Xóa Chưa Thành Công", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            gantext(0);
            grChuyen.Enabled = true;
            txtTK.ReadOnly = true;
            txtMK.ReadOnly = true;
            cmbQuyen.Enabled = false;
            btLuu.Enabled = false;
            btHuy.Enabled = false;
            btThem.Enabled = true;
            btXoa.Enabled = true;
        }
    }
}