
using System.Data;

using System.Data.SqlClient;

namespace QLCuaHangXe.DataLayer
{
    public class DanhThuData
    {
        readonly DataService _mDs = new DataService();
        public DataTable Doanhthu(string thang,string nam)
        {
            SqlCommand cmd = new SqlCommand(" select * from v_dthu where Tháng='" + thang + "' and Năm ='" + nam + "'");
            _mDs.Load(cmd);
            return _mDs;
        }
    }
}
