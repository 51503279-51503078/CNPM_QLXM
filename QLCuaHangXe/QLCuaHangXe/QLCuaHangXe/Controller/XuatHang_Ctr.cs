

using System.Data;

using System.Windows.Forms;
using QLCuaHangXe.DataLayer;


namespace QLCuaHangXe.Controller
{
    public class XuatHangCtr
    {
        readonly XuatHangData _data = new XuatHangData();
        public void HienthidatagridPx(DataGridView dg, string ma,int sl)
        {
            BindingSource bs = new BindingSource();
            DataTable tbl = new XuatHangData().DatagridPx(ma, sl);
            bs.DataSource = tbl;
            dg.DataSource = bs;
        }

        public void HienthidatagridPx(DataGridView dg, string ma)
        {
            BindingSource bs = new BindingSource();
            DataTable tbl = new XuatHangData().DatagridPx(ma);
            bs.DataSource = tbl;
            dg.DataSource = bs;
        }

        public void HienthicmbHang(ComboBox cmb)
        {
            DataTable tbl = _data.CmbHang();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "TENHANG";
            cmb.ValueMember = "MAHANG";
        }

        public void HienthicmbNv(ComboBox cmb)
        {
            DataTable tbl = _data.CmbNv();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "TENNHANVIEN";
            cmb.ValueMember = "MANHANVIEN";
        }

        public void HienthicmbKh(ComboBox cmb)
        {
            DataTable tbl = _data.CmbKh();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "TENKHACHHANG";
            cmb.ValueMember = "MAKHACHHANG";
        }

      

    }
}
