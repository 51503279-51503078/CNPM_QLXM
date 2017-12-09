
using System.Data;

using System.Windows.Forms;
using QLCuaHangXe.DataLayer;


namespace QLCuaHangXe.Controller
{
    public class CQuantriCtr
    {
        readonly CQuantridata _data = new CQuantridata();
        public void Hienthicmbquyen(ComboBox cmb)
        {
            DataTable tbl = _data.Hienthicmb();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "QUYEN";
            cmb.ValueMember = "TAIKHOAN";
        }
    }
}
