using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLCuaHangXe.DataLayer
{
    class HangBanChay_Data
    {
        DataService m_ds = new DataService();

        public DataTable hangbanchay(string thang, string nam)
        {
            SqlCommand cmd = new SqlCommand(" select * from v_hangbanchay where Tháng='" + thang + "' and Năm ='" + nam + "'");
            m_ds.Load(cmd);
            return m_ds;
        }        
    }
}
