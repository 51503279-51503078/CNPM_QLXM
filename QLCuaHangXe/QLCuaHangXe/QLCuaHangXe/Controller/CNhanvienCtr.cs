
using System.Data;

using System.Windows.Forms;
using QLCuaHangXe.DataLayer;


namespace QLCuaHangXe.Controller
{
    public class CNhanvienCtr
    {
        CNhanviendata _nv = new CNhanviendata();
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
    }
}
