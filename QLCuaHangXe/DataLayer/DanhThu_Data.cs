using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

using System.Data.SqlClient;

namespace QLCuaHangXe.DataLayer
{
    public class DanhThu_Data
    {
        DataService m_ds = new DataService();
        public DataTable doanhthu(string thang,string nam)
        {
            SqlCommand cmd = new SqlCommand(" select * from v_dthu where Tháng='" + thang + "' and Năm ='" + nam + "'");
            m_ds.Load(cmd);
            return m_ds;
        }
    }
}
