
using System;
using System.Data;
using System.Data.SqlClient;

namespace QLCuaHangXe.DataLayer
{
    class HangBanChayData
    {
        readonly DataService _mDs = new DataService();


        public bool InsertData(string ma, string ten, int sl, DateTime date)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into HangBanCHay values('" + ma + "'," +
                                                "N'" + ten + "'," + sl + ",'" +
                                                date + "')");
                _mDs.Load(cmd);
                return true;

            }
            catch (SqlException )
            {
                return false;
            }

        }

        public DataTable Hangbanchay(string thang, string nam)
        {
            SqlCommand cmd = new SqlCommand(" select  * " +
                                            "from v_hangbanchay where Tháng='" + thang + "'" +
                                            "and Năm='" + nam + "'");
            _mDs.Load(cmd);
            return _mDs;
        }        
    }
}
