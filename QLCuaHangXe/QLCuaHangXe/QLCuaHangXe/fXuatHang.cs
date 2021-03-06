using System;

using System.Data;

using System.Windows.Forms;
using QLCuaHangXe.Businessobject;
using QLCuaHangXe.DataLayer;
using QLCuaHangXe.Controller;


namespace QLCuaHangXe
{
    public partial class FXuatHang : DevComponents.DotNetBar.Office2007Form
    {
        public FXuatHang()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private string MaTuTang(string codePrefix)
        {
            DataTable tbl = new XuatHangData().Matutang();
            int resual = 1;
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                string codeStr = tbl.Rows[i]["MAPX"].ToString();
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


        private void btXuat_Click(object sender, EventArgs e)
        {
            Run();
        }

        private void Run()
        {
            txtMaPX.Text = MaTuTang("X");
            cmbNV.Enabled = true;
            cmbKhach.Enabled = true;
            dateTimePicker1.Enabled = true;
            cmbHang.Enabled = true;
        }



        private void fXuatHang_Load(object sender, EventArgs e)
        {
            DataService.OpenConnection();
            new XuatHangCtr().HienthicmbKh(cmbKhach);
            new XuatHangCtr().HienthicmbNv(cmbNV);
            new XuatHangCtr().HienthicmbHang(cmbHang);
            cmbNV.Enabled = false;
            cmbKhach.Enabled = false;
            dateTimePicker1.Enabled = false;
            cmbHang.Enabled = false;
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            XuatHangData luu = new XuatHangData();
            ChiTietPx obj = new ChiTietPx();
            if (txtSL.Text == "" || txtThue.Text == "")
                MessageBox.Show(@"Bạn còn bỏ trống thông tin");
            else
            {
                obj.MaPx = txtMaPX.Text;
                obj.MaHang = cmbHang.SelectedValue.ToString();
                obj.SoLuong = Int32.Parse(txtSL.Text);
                obj.NgayXuat = dateTimePicker1.Value;
                obj.DonGia = Int32.Parse(txtDG.Text);
                obj.Thue = float.Parse(txtThue.Text);
                obj.Manhanvien = cmbNV.SelectedValue.ToString();
                obj.Makhachhang = cmbKhach.SelectedValue.ToString();
                if (Int32.Parse(txtSL.Text) > new XuatHangData().Soluong(cmbHang.SelectedValue.ToString()))
                    MessageBox.Show(@"Số lượng hàng trong kho không đủ xuất");
                else
                {
                    try
                    {
                        luu.InsertCtpx(obj);
                        MessageBox.Show(@"Lưu thành công");
                        new XuatHangCtr().HienthidatagridPx(dataGridView1, txtMaPX.Text, Int32.Parse(txtSL.Text));
                        txtDG.ResetText();
                        txtSL.ResetText();
                        txtThue.ResetText();
                        cmbHang.ResetText();
                        //cai nay em muon insert vao v_hangbanchay. Anh qua tang data sua gium :))
                        //new HangBanChayData().InsertData(obj.MaHang, cmbHang.SelectedValue.ToString(), obj.SoLuong,
                        // obj.NgayXuat);

                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(@"Lưu thất bại");
                    }

                }
            }
            Run();
        }

        readonly XuatHangData _h = new XuatHangData();
        private void cmbHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            //sai cho nay
            txtDG.Text = _h.LayGiaBan(cmbHang.SelectedValue.ToString()).ToString(); 
            //txtDG.Text = h.LayTenSanPham(cmbHang.SelectedValue.ToString()).ToString();
        }


        readonly ChiTietPx _px = new ChiTietPx();
        readonly XuatHangData _xuathang = new XuatHangData();
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            bool k = true;
            int i = e.RowIndex;
            try
            {
                int a = Int32.Parse(txtSL.Text);
                txtSL.Text = _xuathang.DatagridPx(txtMaPX.Text, a).Rows[i][4].ToString();
                //MessageBox.Show(txtSL.Text);
                txtDG.Text = _xuathang.DatagridPx(txtMaPX.Text,a).Rows[i][6].ToString();
                txtThue.Text = _xuathang.DatagridPx(txtMaPX.Text,a).Rows[i][7].ToString();
                cmbHang.Text = _xuathang.DatagridPx(txtMaPX.Text,a).Rows[i][4].ToString();
            }
            catch { 
                k = false;
                MessageBox.Show(@"Loi");
            }
            
            if (k == false)
            {
                int a = Int32.Parse(txtSL.Text);
                i--;
                txtSL.Text = _xuathang.DatagridPx(txtMaPX.Text,a).Rows[i][4].ToString();
                txtDG.Text = _xuathang.DatagridPx(txtMaPX.Text,a).Rows[i][6].ToString();
                txtThue.Text = _xuathang.DatagridPx(txtMaPX.Text,a).Rows[i][7].ToString();
                cmbHang.Text = _xuathang.DatagridPx(txtMaPX.Text,a).Rows[i][4].ToString();
            }

            _px.MaHang = cmbHang.Text;
            //px.SoLuong = Int32.Parse(txtSL.Text);
            _px.DonGia = Int32.Parse(txtDG.Text);
            _px.Thue = Int32.Parse(txtThue.Text);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult x;
          
            x = MessageBox.Show(@"Ban Co Chac Muon Xoa Phiếu Nhập " + txtMaPX.Text + @" ra khoi danh sach", @"Thong Bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (x.ToString() == "OK")
            {
                ChiTietPx objec = new ChiTietPx();
                objec.MaPx = txtMaPX.Text;
                if (new XuatHangData().XoaCtpXuat(objec) == true)
                {
                    MessageBox.Show(@"Xóa thành công nhân viên " + txtMaPX.Text);
                    new XuatHangCtr().HienthidatagridPx(dataGridView1, txtMaPX.Text);
                }
            }
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(txtSL.Text);
            DialogResult x = new DialogResult();
            x = MessageBox.Show(@"Ban Co Muốn Hủy Thao Tác Không", @"Thong Bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (x.ToString() == "OK")
            {
                new XuatHangCtr().HienthidatagridPx(dataGridView1, txtMaPX.Text,a);
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            fInPXuat f = new fInPXuat(txtMaPX.Text);
            f.MdiParent = ActiveForm;
            f.Show();
        }

        private void txtSL_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtDG_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbKhach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtThue_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}