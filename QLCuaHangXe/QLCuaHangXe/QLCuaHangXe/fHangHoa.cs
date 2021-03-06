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
    public partial class FHangHoa : DevComponents.DotNetBar.Office2007Form
    {
        public FHangHoa()
        {
            InitializeComponent();
        }

        private void fThongTinSP_Load(object sender, EventArgs e)
        {
            DataService.OpenConnection();
            new CThogntinSpcTr().HienthicmbNcc(cmbNCC); 
            new CThogntinSpcTr().Hienthisanpham(dataGridView1);
            new CThogntinSpcTr().Treeview(treeviewNCC);
           
        }       

        private void btXxoa_Click(object sender, EventArgs e)
        {
            CSanpham objec = new CSanpham();
            objec.Mahang = txtmasp.Text;
            if (new CThigntinSPdata().XoaHang(objec) == true)
            {
                MessageBox.Show(@"Xóa thành công");
                new CThogntinSpcTr().Hienthisanpham(dataGridView1);
            }   
        }

        private void treeviewNCC_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string ten = e.Node.Text;
            new CThogntinSpcTr().Hienthitree(dataGridView1, ten);
        }

        private void btthemNCC_Click(object sender, EventArgs e)
        {
            FNcc d = new FNcc();
            d.MdiParent = FMain.ActiveForm;
            d.Show();
        }

        private void btXluu_Click(object sender, EventArgs e)
        {
            CSanpham objec = new CSanpham();
            objec.Mahang = txtmasp.Text;
            objec.Tenhang = txttensp.Text;
            objec.Soluong = Int32.Parse(txtslhang.Text);
            objec.Dongia = Convert.ToInt32(txtdongia.Text);
            objec.ThongtinBh = txtbaohanh.Text;
            objec.DVtinh = txtdvtinh.Text;
            objec.Mota = txtdacta.Text;            
            objec.MaNcc = cmbNCC.SelectedValue.ToString();

            if (new CThigntinSPdata().ThemHang(objec) == true)
            {
                MessageBox.Show(@"Lưu thành công");
                new CThogntinSpcTr().Hienthisanpham(dataGridView1);
            }
            else
            {
                MessageBox.Show("Lưu thất bại");
            }
        }

        private string GetNextAvalabalIdbs(string codePrefix)
        {
            DataTable tbl = new CThigntinSPdata().Matt();
            int resual = 1;
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                string codeStr = tbl.Rows[i]["MAHANG"].ToString();
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
        private void btXthem_Click(object sender, EventArgs e)
        {
            txtmasp.Text = GetNextAvalabalIdbs("MH");
            txttensp.ResetText();
            txtdacta.ResetText();
            txtdvtinh.ResetText();
            txtbaohanh.ResetText();
            txtdongia.ResetText();
            txtslhang.ResetText();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            try
            {

                txtmasp.Text = row.Cells["colmasp"].Value.ToString();
                txttensp.Text = row.Cells["coltensp"].Value.ToString();
                txtslhang.Text = row.Cells["colslhang"].Value.ToString();
                txtdongia.Text = row.Cells["coldongia"].Value.ToString();
                txtbaohanh.Text=row.Cells["colbaohanh"].Value.ToString();
                txtdvtinh.Text = row.Cells["coldvtinh"].Value.ToString();
                txtdacta.Text = row.Cells["colmota"].Value.ToString();
                cmbNCC.Text = row.Cells["colmancc"].Value.ToString();
            }
            catch (NullReferenceException)
            {
            }
        }

        private void btXcapnhat_Click(object sender, EventArgs e)
        {
            CSanpham objec = new CSanpham();
            objec.Mahang = txtmasp.Text;
            objec.Tenhang = txttensp.Text;
            objec.Soluong = Int32.Parse(txtslhang.Text);
            objec.Dongia = Convert.ToInt32(txtdongia.Text);
            objec.ThongtinBh = txtbaohanh.Text;
            objec.DVtinh = txtdvtinh.Text;
            objec.Mota = txtdacta.Text;
            objec.MaNcc = cmbNCC.SelectedValue.ToString();            

            if (new CThigntinSPdata().CapnhatHang(objec) == true)
            {
                MessageBox.Show(@"Update thành công");
                new CThogntinSpcTr().Hienthisanpham(dataGridView1);
            }
            else
            {
                MessageBox.Show(@"Update thất bại");
            }
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            new CThogntinSpcTr().Hienthisanpham(dataGridView1);
        }

        private void btinhanghoa_Click(object sender, EventArgs e)
        {
            FInDsHangHoa hh =new FInDsHangHoa();
            hh.MdiParent = ActiveForm;
            hh.Show();
        }
    }
}