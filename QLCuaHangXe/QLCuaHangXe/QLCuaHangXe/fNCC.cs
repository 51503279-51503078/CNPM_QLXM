using System;

using System.Data;

using System.Windows.Forms;
using QLCuaHangXe.Businessobject;

using QLCuaHangXe.DataLayer;
using QLCuaHangXe.Controller;

namespace QLCuaHangXe
{
    public partial class FNcc : DevComponents.DotNetBar.Office2007Form
    {
        public FNcc()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            FInDsNhaCungCap f = new FInDsNhaCungCap();
            f.MdiParent = ActiveForm;
            f.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DataService.OpenConnection();
            new CNhacungcapCtr().Hienthidatagridview(dataGridView1);
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            try
            {
                txtMaNCC.Text = row.Cells["colmancc"].Value.ToString();
                txtTenNCC.Text = row.Cells["coltenncc"].Value.ToString();
                txtDCNCC.Text = row.Cells["coldc"].Value.ToString();
                txtDTNCC.Text = row.Cells["coldt"].Value.ToString();
                txtEmailNCC.Text = row.Cells["colemail"].Value.ToString();
            }
            catch (NullReferenceException)
            {
            }
        }

        private string GetNextAvalabalIdbs(string codePrefix)
        {
            DataTable tbl = new NhaCungCapData().Matutang();
            int resual = 1;
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                string codeStr = tbl.Rows[i]["MANHACUNGCAP"].ToString();
                codeStr = codeStr.Replace(codePrefix, "");
                int codeInt = Convert.ToInt32(codeStr);
                if (resual != codeInt)
                {
                    return codePrefix + String.Format("{000:00}", resual);
                }
                resual++;
            }
            return codePrefix + String.Format("{000:00}", resual);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaNCC.Text = GetNextAvalabalIdbs("NCC");
            txtTenNCC.ResetText();
            txtDCNCC.ResetText();
            txtDTNCC.ResetText();
            txtEmailNCC.ResetText();
        }

        public bool Kiemtradt()
        {
            if (Convert.ToInt32(txtDTNCC.Text.Substring(0, 1)) != 0 || txtDTNCC.Text.Length != 10 && txtDTNCC.Text.Length != 11)
                return false;
            
             return true;
        }

       

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!new CNhacungcapCtr().KiemTraLuu())
            {
                MessageBox.Show(@"Error");
            }
            else
            {
                NhaCungCap objec = new NhaCungCap();
                objec.MaNcc = txtMaNCC.Text;
                objec.TenNcc = txtTenNCC.Text;
                objec.Diachi = txtDCNCC.Text;
                objec.Dienthoai = txtDTNCC.Text;
                objec.Email = txtEmailNCC.Text;

                if (new NhaCungCapData().ThemNhaCungCap(objec))
                {
                    MessageBox.Show(@"Lưu thành công");
                    new CNhacungcapCtr().Hienthidatagridview(dataGridView1);
                }
                else
                    MessageBox.Show(@"Lưu thất bại");
            }
        }

        private void txtDTNCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            new CNhacungcapCtr().Hienthidatagridview(dataGridView1);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult x;
            x = MessageBox.Show(@"Ban Co Chac Muon Xoa NCC " + txtTenNCC.Text, "Thong Bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (x.ToString() == "OK")
            {
                NhaCungCap objec = new NhaCungCap();
                objec.MaNcc = txtMaNCC.Text;
                if (new NhaCungCapData().XoaNcc(objec) )
                {
                    MessageBox.Show(@"Xóa thành công NCC " + txtTenNCC.Text);
                    new CNhacungcapCtr().Hienthidatagridview(dataGridView1);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            NhaCungCap objec = new NhaCungCap();
            objec.MaNcc = txtMaNCC.Text;
            objec.TenNcc = txtTenNCC.Text;
            objec.Diachi = txtDCNCC.Text;
            objec.Dienthoai = txtDTNCC.Text;
            objec.Email = txtEmailNCC.Text;

            if (new NhaCungCapData().CapNhatNcc(objec))
            {
                MessageBox.Show(@"Updata thành công");
                new CNhacungcapCtr().Hienthidatagridview(dataGridView1);
            }
            else
            {
                MessageBox.Show(@"Updata thất bại");
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            string ten = txtTenNCC.Text;
            new CNhacungcapCtr().Hienthidatagridviewtheoten(dataGridView1, ten);
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            string ma = txtMaNCC.Text;
            new CNhacungcapCtr().Hienthidatagridviewtheoma(dataGridView1, ma);
        }

        private void txtMaNCC_TextChanged(object sender, EventArgs e)
        {

        }
    }
}