using System;

using System.Windows.Forms;
using QLCuaHangXe.DataLayer;
using System.Data;

namespace QLCuaHangXe.Controller
{
    public class CNhatKyCtr
    {
        CNhatKyData _nv = new CNhatKyData();
        public void DatagridNhatky(DataGridView dg, Label lbhienthi)
        {
            DataTable tbl = new CNhatKyData().load_nhatky();
            dg.DataSource = tbl;
            lbhienthi.Text = @"Tống số lượt: " + dg.Rows.Count.ToString();
        }

        public void HienThiComboBox(ComboBox cmb)
        {
            cmb.DataSource = _nv.Cmbtaikhoan();
            cmb.DisplayMember = "TEAIKHOAN";
            cmb.ValueMember = "TAIKHOAN";
        }
        public void HienThiTimKiemTatCa(DataGridView dg)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = _nv.TimKiemTatca();
            dg.DataSource = bs;
        }
        public void HienThiTimKiemTuyChon(String timchuoi, DataGridView dg)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = _nv.TimKiemTuyChon(timchuoi);
            dg.DataSource = bs;
        }
    }
}
