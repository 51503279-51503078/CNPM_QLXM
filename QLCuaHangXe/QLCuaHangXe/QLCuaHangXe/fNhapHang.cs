using System;

using System.Data;

using System.Windows.Forms;
using QLCuaHangXe.Businessobject;
using QLCuaHangXe.DataLayer;
using QLCuaHangXe.Controller;


namespace QLCuaHangXe
{
    public partial class FNhapHang : DevComponents.DotNetBar.Office2007Form
    {
        public FNhapHang()
        {
            InitializeComponent();
        }

        private void fNhapHang_Load(object sender, EventArgs e)
        {
            DataService.OpenConnection();            
            new NhapHangCtr().HienthicmbNv(cmbNV);
            new NhapHangCtr().HienthicmbNcc(cmbNCC);
            new NhapHangCtr().HienthicmbHang(cmbHang);

            cmbNCC.Enabled = false;
            cmbNV.Enabled = false;
            dateTimePicker1.Enabled = false;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private string MaTuTang(string codePrefix)
        {
            DataTable tbl = new NhapHangData().Matutang();
            int resual = 1;
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                string codeStr = tbl.Rows[i]["MAPN"].ToString();
                codeStr = codeStr.Replace(codePrefix, "");
                int codeInt = Convert.ToInt32(codeStr);
                if (resual != codeInt)
                {
                    return codePrefix + String.Format("{0:00}", resual);
                }
                resual++;
            }
            return codePrefix + String.Format("{0:00}", resual);
        }

        private void btNhap_Click(object sender, EventArgs e)
        {
            txtMaPN.Text = MaTuTang("N");
            cmbNCC.Enabled = true;
            cmbNV.Enabled = true;
            dateTimePicker1.Enabled = true;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            txtMaPN.Text = MaTuTang("N");
            txtDG.ResetText();
            txtSL.ResetText();
            txtThue.ResetText();
        }

        ChiTietPn _ct = new ChiTietPn();
        XuatHangData _hanghoa = new XuatHangData();
        NhapHangData _nhaphang = new NhapHangData();
        private void btLuu_Click(object sender, EventArgs e)
        {
            if (cmbNCC.Enabled == false)
                MessageBox.Show("Bạn chưa làm mới hóa đơn nhập");
            else
            {
                if (txtSL.Text == "" || txtDG.Text == "" || txtThue.Text=="")
                    MessageBox.Show("Bạn còn thiếu thông tin nhập hàng");
                else
                {
                    ChiTietPn obj = new ChiTietPn();
                    obj.MaPn = txtMaPN.Text;
                    obj.MaHang = cmbHang.SelectedValue.ToString();
                    obj.SoLuong = Int32.Parse(txtSL.Text);
                    obj.DonGia = Int32.Parse(txtDG.Text);
                    obj.Thue = float.Parse(txtThue.Text);
                    obj.Ngaynhap = dateTimePicker1.Value;
                    obj.Manhanvien = cmbNV.SelectedValue.ToString();
                    obj.Manhacungcap = cmbNCC.SelectedValue.ToString();
                    if (new NhapHangData().InsertCtpn(obj) == true)
                    {
                        MessageBox.Show("Lưu Thành Công");
                        new NhapHangCtr().HienthidatagridPn(dataGridView1, txtMaPN.Text);
                    }
                    else
                    {
                        MessageBox.Show("Thất bại");
                    }
                }
            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            bool k = true;
            int i = e.RowIndex;
            try
            {
                txtSL.Text = _nhaphang.Hienthiphieunhap(txtMaPN.Text).Rows[i][5].ToString();
                txtDG.Text = _nhaphang.Hienthiphieunhap(txtMaPN.Text).Rows[i][6].ToString();
                txtThue.Text = _nhaphang.Hienthiphieunhap(txtMaPN.Text).Rows[i][7].ToString();
                cmbHang.Text = _nhaphang.Hienthiphieunhap(txtMaPN.Text).Rows[i][4].ToString();
            }
            catch { k = false; }
            if (k == false)
            {
                i--;
                txtSL.Text = _nhaphang.Hienthiphieunhap(txtMaPN.Text).Rows[i][5].ToString();
                txtDG.Text = _nhaphang.Hienthiphieunhap(txtMaPN.Text).Rows[i][6].ToString();
                txtThue.Text = _nhaphang.Hienthiphieunhap(txtMaPN.Text).Rows[i][7].ToString();
                cmbHang.Text = _nhaphang.Hienthiphieunhap(txtMaPN.Text).Rows[i][4].ToString();
            }
            _ct.MaHang = cmbHang.Text;
            _ct.SoLuong = Convert.ToInt32(txtSL.Text);
            _ct.DonGia = Convert.ToInt32(txtDG.Text);
            _ct.Thue = float.Parse(txtThue.Text);            
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            DialogResult h = new DialogResult();
            h = MessageBox.Show("Bạn Có Muốn Hủy Thao Tác Không ", "Thong Bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (h.ToString() == "OK")
            {
                new NhapHangCtr().HienthidatagridPn(dataGridView1,txtMaPN.Text);
            }            
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult x = new DialogResult();
            x = MessageBox.Show("Ban Co Chac Muon Xoa Phiếu Nhập " + txtMaPN.Text + " ra khoi danh sach", "Thong Bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (x.ToString() == "OK")
            {
                ChiTietPn objec = new ChiTietPn();
                objec.MaPn = txtMaPN.Text;
                if (new NhapHangData().XoaCtpNhap(objec) == true)
                {
                    MessageBox.Show("Xóa thành công nhân viên " + txtMaPN.Text);
                    new NhapHangCtr().HienthidatagridPn(dataGridView1,txtMaPN.Text);
                }
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            fInPNhap f = new fInPNhap(txtMaPN.Text);
            f.MdiParent = FMain.ActiveForm;
            f.Show();
        }

        private void btSua_Click(object sender, EventArgs e)
        {

        }

        private void txtMaPN_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}