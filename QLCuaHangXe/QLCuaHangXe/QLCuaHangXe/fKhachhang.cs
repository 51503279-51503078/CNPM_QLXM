using System;

using System.Data;

using System.Windows.Forms;

using QLCuaHangXe.Controller;
using QLCuaHangXe.DataLayer;
using QLCuaHangXe.Businessobject;

namespace QLCuaHangXe
{
    public partial class FKhachhang : DevComponents.DotNetBar.Office2007Form
    {
        public FKhachhang()
        {
            InitializeComponent();
        }

        private void fKhachhang_Load(object sender, EventArgs e)
        {
            DataService.OpenConnection();
            new CKhachhangCtr().Hienthikhachhang(dataGridView1);
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            try
            {
                txtmakh.Text = row.Cells["colmakh"].Value.ToString();
                txttenkh.Text = row.Cells["coltenkh"].Value.ToString();                
                txtdc.Text = row.Cells["coldc"].Value.ToString();
                if (row.Cells["colgt"].Value.ToString() == "Nam")
                    radnam.Checked = true;
                else
                    radnu.Checked = true;
                txtdt.Text = row.Cells["coldt"].Value.ToString();
                txtemail.Text = row.Cells["colemail"].Value.ToString();
            }
            catch (NullReferenceException)
            {
            }
        }

        private string GetNextAvalabalIdbs(string codePrefix)
        {
            DataTable tbl = new CKhachhangdata().Matt();
            int resual = 1;
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                string codeStr = tbl.Rows[i]["MAKHACHHANG"].ToString();
                codeStr = codeStr.Replace(codePrefix, "");
                int codeInt = Convert.ToInt32(codeStr);
                if (resual != codeInt)
                {
                    return codePrefix + String.Format("{00:00}", resual);
                }
                resual++;
            }
            return codePrefix + String.Format("{00:00}", resual);
        }

        private void bttimten_Click(object sender, EventArgs e)
        {
            string ten = txtten.Text;
            new CKhachhangCtr().Hienthidatagridviewtheoten(dataGridView1, ten);
        }

        private void bttimma_Click(object sender, EventArgs e)
        {
            string ma = txtma.Text;
            new CKhachhangCtr().Hienthidatagridviewtheoma(dataGridView1, ma);
        }

        
        

        private void txtdt_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void btThem_Click_1(object sender, EventArgs e)
        {
            txtmakh.Text = GetNextAvalabalIdbs("KH");
            txttenkh.ResetText();
            txtdc.ResetText();
            txtdt.ResetText();
            txtemail.ResetText();
        }

        private void btSua_Click_1(object sender, EventArgs e)
        {
            string gioitinh;
            if (radnam.Checked)
            {
                gioitinh = "Nam";
            }
            else
            {
                gioitinh = "Nu";
            }
            CKhachhang objec = new CKhachhang();
            objec.MaKh = txtmakh.Text;
            objec.TenKh = txttenkh.Text;
            objec.DiaChi = txtdc.Text;
            objec.Gioitinh = gioitinh;            
            objec.DienThoai = txtdt.Text;
            objec.Email = txtemail.Text;

            if (new CKhachhangdata().CapnhatKh(objec))
            {
                MessageBox.Show(@"Updata thành công");
                new CKhachhangCtr().Hienthikhachhang(dataGridView1);
            }
            else
            {
                MessageBox.Show(@"Updata thất bại");
            }
        }

        private void btXoa_Click_1(object sender, EventArgs e)
        {
            new CKhachhangdata().Xoakhachhang(txtmakh.Text);
            MessageBox.Show(@"Xóa thành công");
            new CKhachhangCtr().Hienthikhachhang(dataGridView1);
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            if (!new CKhachhangCtr().KiemTra(txttenkh, txtdc, txtdt, txtemail))
            {
                MessageBox.Show(@"Error");
            }
            else
            {
                string gioitinh;
                if (radnam.Checked)
                    gioitinh = "Nam";
                else
                    gioitinh = "Nu";
                CKhachhang objec = new CKhachhang();
                objec.MaKh = txtmakh.Text;
                objec.TenKh = txttenkh.Text;
                objec.Gioitinh = gioitinh;
                objec.DiaChi = txtdc.Text;
                objec.DienThoai = txtdt.Text;
                objec.Email = txtemail.Text;

                if (new CKhachhangdata().ThemKh(objec))
                {
                    MessageBox.Show(@"Lưu thành công");
                    new CKhachhangCtr().Hienthikhachhang(dataGridView1);
                }
                else
                    MessageBox.Show(@"Lưu thất bại");
            }
        }

        private void btHuy_Click_1(object sender, EventArgs e)
        {
            new CKhachhangCtr().Hienthikhachhang(dataGridView1);
        }

        private void btnIn_Click_1(object sender, EventArgs e)
        {
            fInDSKhachHang f = new fInDSKhachHang();
            f.MdiParent = ActiveForm;
            f.Show();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}