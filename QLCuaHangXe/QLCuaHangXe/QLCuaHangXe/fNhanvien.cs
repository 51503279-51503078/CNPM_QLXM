using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using DevComponents.DotNetBar.Controls;
using System.Drawing.Imaging;
using QLCuaHangXe.Controller;
using QLCuaHangXe.DataLayer;
using QLCuaHangXe.Businessobject;

namespace QLCuaHangXe
{
    public partial class fNhanvien :DevComponents.DotNetBar.Office2007Form
    {
        public fNhanvien()
        {            
            InitializeComponent();
        }

        private void fNhanvien_Load(object sender, EventArgs e)
        {
            DataService.OpenConnection();
            new CNhanvienCtr().Hienthinv(dataGridView1);      
        }

        private string GetNextAvalabalIDBS(string codePrefix)
        {
            DataTable tbl = new CNhanviendata().Matutang();
            int resual = 1;
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                string codeStr = tbl.Rows[i]["MANHANVIEN"].ToString();
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

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            try
            {

                txtmanv.Text = row.Cells["colmanv"].Value.ToString();
                txttennv.Text = row.Cells["coltennv"].Value.ToString();

                txtns.Text = row.Cells["colns"].Value.ToString();

                if (row.Cells["colgt"].Value.ToString() == "Nam")
                    radnam.Checked=true;
                else
                    radnu.Checked=true;
                txtdt.Text = row.Cells["coldt"].Value.ToString();

                txtdc.Text = row.Cells["coldc"].Value.ToString();

                txtchv.Text = row.Cells["colchucvu"].Value.ToString();

                txtluong.Text = row.Cells["collcb"].Value.ToString();

            }
            catch (NullReferenceException) 
            { }
        }
        

        private void bttimma_Click(object sender, EventArgs e)
        {
            string ma = txtma.Text;
            new CNhanvienCtr().Hienthidatagridviewtheoma(dataGridView1, ma);
        }

        private void bttimten_Click(object sender, EventArgs e)
        {
            string ten = txtten.Text;
            new CNhanvienCtr().Hienthidatagridviewtheoten(dataGridView1, ten);
        }

        private void txtdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtns_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void btThem_Click_1(object sender, EventArgs e)
        {
            txtdc.Text = "";
            txtchv.Text = "";
            txtdt.Text = "";
            txtluong.Text = "";
            txtmanv.Text = "";
            txtns.Text = "";
            txttennv.Text = "";
            txtmanv.Focus();
            txtmanv.Text = GetNextAvalabalIDBS("NV");
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            FInDsNhanvien f = new FInDsNhanvien();
            f.MdiParent = FMain.ActiveForm;
            f.Show();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            string gioitinh;
            if (radnam.Checked == true)
            {
                gioitinh = "Nam";
            }
            else
            {
                gioitinh = "Nu";
            }

            CNhanvien objecNV = new CNhanvien();
            objecNV.MaNv = txtmanv.Text;
            objecNV.TenNv = txttennv.Text;
            objecNV.Namsinh = txtns.Text;
            objecNV.Gioitinh = gioitinh;
            objecNV.Dienthoai = txtdt.Text;
            objecNV.Diachi = txtdc.Text;
            objecNV.Chucvu = txtchv.Text;
            objecNV.LuongCb = Int32.Parse(txtluong.Text);

            if (new CNhanviendata().CapnhatNv(objecNV) == true)
            {
                MessageBox.Show("Sửa thành công nhân viên " + txttennv.Text);
                new CNhanvienCtr().Hienthinv(dataGridView1);
            }
            else
            {
                MessageBox.Show("Sửa không thành công nhân viên " + txttennv.Text);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult x = new DialogResult();
            x = MessageBox.Show("Ban Co Chac Muon Xoa Nhan Vien " + txttennv.Text + " ra khoi danh sach", "Thong Bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (x.ToString() == "OK")
            {
                CNhanvien objecnv = new CNhanvien();
                objecnv.MaNv = txtmanv.Text;
                if (new CNhanviendata().Xoanhanvien(objecnv) == true)
                {
                    MessageBox.Show("Xóa thành công nhân viên " + txttennv.Text);
                    new CNhanvienCtr().Hienthinv(dataGridView1);
                }
            }
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            DialogResult h = new DialogResult();
            h = MessageBox.Show("Bạn Có Muốn Hủy Thao Tác Không ", "Thong Bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (h.ToString() == "OK")
            {
                new CNhanvienCtr().Hienthinv(dataGridView1);
            }
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            if (txttennv.Text == "")
            {
                MessageBox.Show("Khong Duoc Bo Trong Ten Nhan Vien", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtten.Focus();
            }
            else if (txtns.Text == "")
            {
                MessageBox.Show("Khong Duoc Bo Trong Nam Sinh", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtns.Focus();
            }
            else if (txtdc.Text == "")
            {
                MessageBox.Show("Khong Duoc Bo Trong DC Nhan Vien", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdc.Focus();
            }
            else if (txtdt.Text == "")
            {
                MessageBox.Show("Khong Duoc Bo Trong DT Nhan Vien", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdt.Focus();
            }
            else if (txtchv.Text == "")
            {
                MessageBox.Show("Khong Duoc Bo Trong Chuc Vu Nhan Vien", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtchv.Focus();
            }
            else if (txtluong.Text == "")
            {
                MessageBox.Show("Khong Duoc Bo Trong Luong Nhan Vien", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtluong.Focus();
            }
            else
            {
                if (txtdt.Text.Length != 10 && txtdt.Text.Length != 11)
                {
                    MessageBox.Show("Bạn nhập số DT Không đúng với thực tế", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtdt.Focus();
                }
                else
                {
                    string gioitinh;
                    if (radnam.Checked == true)
                    {
                        gioitinh = "Nam";
                    }
                    else
                    {
                        gioitinh = "Nu";
                    }
                    CNhanvien objecNV = new CNhanvien();
                    objecNV.MaNv = txtmanv.Text;
                    objecNV.TenNv = txttennv.Text;
                    objecNV.Namsinh = txtns.Text;
                    objecNV.Gioitinh = gioitinh;
                    objecNV.Dienthoai = txtdt.Text;
                    objecNV.Diachi = txtdc.Text;
                    objecNV.Chucvu = txtchv.Text;
                    objecNV.LuongCb = Int32.Parse(txtluong.Text);

                    if (new CNhanviendata().ThemNv(objecNV) == true)
                    {
                        MessageBox.Show("Lưu thành công");
                        new CNhanvienCtr().Hienthinv(dataGridView1);
                    }
                    else
                    {
                        MessageBox.Show("Lưu thất bại");
                    }
                }
            }
        }      
    }
}