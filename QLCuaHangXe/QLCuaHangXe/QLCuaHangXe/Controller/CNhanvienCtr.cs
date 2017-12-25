
using System.Data;

using System.Windows.Forms;
using QLCuaHangXe.DataLayer;


namespace QLCuaHangXe.Controller
{
    public class CNhanvienCtr
    {
        //CNhanviendata _nv = new CNhanviendata();
        public void Hienthinv(DataGridView dg)
        {
            BindingSource bs = new BindingSource();
            DataTable tbl = new CNhanviendata().Nhanvien();
            bs.DataSource = tbl;
            dg.DataSource = bs;
        }

        public void Hienthidatagridviewtheoma(DataGridView dg, string ma)
        {
            BindingSource bs = new BindingSource();
            DataTable tbl = new CNhanviendata().Timtheoma(ma);
            bs.DataSource = tbl;
            dg.DataSource = bs;
        }

        public void Hienthidatagridviewtheoten(DataGridView dg, string ten)
        {
            BindingSource bs = new BindingSource();
            DataTable tbl = new CNhanviendata().Timtheoten(ten);
            bs.DataSource = tbl;
            dg.DataSource = bs;
        }

        public bool KiemTraLuu(TextBox txttennv,TextBox txtten,TextBox txtns,TextBox txtdc,
                                TextBox txtdt, TextBox txtchv, TextBox txtluong)
        {
            bool vad = false;
            if (txttennv.Text == "")
            {
                MessageBox.Show(@"Khong Duoc Bo Trong Ten Nhan Vien", @"Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtten.Focus();
                
            }
            else if (txtns.Text == "")
            {
                MessageBox.Show(@"Khong Duoc Bo Trong Nam Sinh", @"Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtns.Focus();
                
            }
            else if (txtdc.Text == "")
            {
                MessageBox.Show(@"Khong Duoc Bo Trong DC Nhan Vien", @"Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdc.Focus();
                
            }
            else if (txtdt.Text == "")
            {
                MessageBox.Show(@"Khong Duoc Bo Trong DT Nhan Vien", @"Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdt.Focus();
            }
            else if (new CKhachhangCtr().Kiemtradt(txtdt) == false)
            {
                MessageBox.Show(@"Khong Duoc Bo Trong DT Nhan Vien", @"Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdt.Focus();
            }
            else if (txtchv.Text == "")
            {
                MessageBox.Show(@"Khong Duoc Bo Trong Chuc Vu Nhan Vien", @"Thong Bao", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtchv.Focus();
            }
            else if (txtluong.Text == "")
            {
                MessageBox.Show(@"Khong Duoc Bo Trong Luong Nhan Vien", @"Thong Bao", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtluong.Focus();
            }
            else vad = true;
            return vad;
        }
    }
}
