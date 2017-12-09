
using System.Data;

using System.Windows.Forms;
using QLCuaHangXe.DataLayer;


namespace QLCuaHangXe.Controller
{
    public class NhapHangCtr
    {
        readonly NhapHangData _data = new NhapHangData();
        public void HienthidatagridPn(DataGridView dg,string ma)
        {
            BindingSource bs = new BindingSource();
            DataTable tbl = new NhapHangData().Hienthiphieunhap(ma);
            bs.DataSource = tbl;
            dg.DataSource = bs;
        }

        public void HienthicmbNv(ComboBox cmb)
        {
            DataTable tbl = _data.CmbNv();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "TENNHANVIEN";
            cmb.ValueMember = "MANHANVIEN";
        }

        public void HienthicmbNcc(ComboBox cmb)
        {
            DataTable tbl = _data.CmbNcc();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "TENNHACUNGCAP";
            cmb.ValueMember = "MANHACUNGCAP";
        }

        public void HienthicmbHang(ComboBox cmb)
        {
            DataTable tbl = _data.CmbHang();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "TENHANG";
            cmb.ValueMember = "MAHANG";
        }
    }
}
