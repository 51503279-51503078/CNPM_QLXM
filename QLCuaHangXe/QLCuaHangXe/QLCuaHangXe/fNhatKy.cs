using System;
/*
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QLCuaHangXe.DataLayer;
*/
using QLCuaHangXe.Controller;
//using QLCuaHangXe.Businessobject;

namespace QLCuaHangXe
{
    public partial class FNhatKy : DevComponents.DotNetBar.Office2007Form
    {
        public FNhatKy()
        {
            InitializeComponent();
        }

        private void fNhatKy_Load(object sender, EventArgs e)
        {
            new CNhatKyCtr().HienThiComboBox(cmbTaikhoan);
            dtTuNgay.Text = System.DateTime.Now.ToShortDateString();
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btTimTatCa_Click(object sender, EventArgs e)
        {
            new CNhatKyCtr().HienThiTimKiemTatCa(dataGridView1);
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.Rows[i].Cells[0].Value = (i + 1);
                }
                else
                {
                    dataGridView1.Rows[0].Cells[0].Value = null;
                }
            }
        }

        string _timchuoi = null;
        public void Timkiem()
        {
            _timchuoi = null;
            string ngay = dtTuNgay.Value.Date.ToShortDateString();
            if (checkNgay.Checked)
            {
                _timchuoi += "THOIGIAN like '%" + dtTuNgay.Value.Day + "%'";
            }
            if (checkThang.Checked)
            {
                if (_timchuoi != null)
                    _timchuoi += "and THOIGIAN like '%" + dtTuNgay.Value.Month + "%'";
                else
                    _timchuoi += "THOIGIAN like'%" + dtTuNgay.Value.Month + "%'";
            }
            if (checkNam.Checked)
            {
                if (_timchuoi != null)
                    _timchuoi += "and THOIGIAN like '%" + dtTuNgay.Value.Year + "%'";
                else
                    _timchuoi += "THOIGIAN like '%" + dtTuNgay.Value.Year + "%'";
            }

            if (checkNhanVien.Checked)
            {
                if (_timchuoi != null)
                    _timchuoi += "and TAIKHOAN='" + cmbTaikhoan.SelectedValue.ToString() + "'";
                else
                    _timchuoi += "TAIKHOAN='" + cmbTaikhoan.SelectedValue.ToString() + "'";
            }
            if (_timchuoi != null)
            {
                _timchuoi = "select * from NhatKy where " + _timchuoi;
                new CNhatKyCtr().HienThiTimKiemTuyChon(_timchuoi,dataGridView1);
            }
            else
            {
                new CNhatKyCtr().HienThiTimKiemTatCa(dataGridView1);
            }
        }

        private void btTimTuyChon_Click(object sender, EventArgs e)
        {
            Timkiem();
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.Rows[i].Cells[0].Value = (i + 1);
                }
                else
                {
                    dataGridView1.Rows[0].Cells[0].Value = null;
                }
            }
        }
    }
}