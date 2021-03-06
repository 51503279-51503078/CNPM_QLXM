using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Security.Cryptography;
using QLCuaHangXe.Businessobject;
using System.Data.SqlClient;


namespace QLCuaHangXe.DataLayer
{
    public class CNhatKy_data
    {
        DataService m_ds = new DataService();
        public DataTable load_nhatky()
        {
                SqlCommand cmd =new SqlCommand ("select * from NhatKy");
                m_ds.Load(cmd);
                return m_ds; ;
        }

        public void DeleteNhatKy()
        {
            SqlCommand cmd = new SqlCommand("delete NhatKy ");

            try
            {
                m_ds.Load(cmd);
            }
            catch
            {
                MessageBox.Show("Không thay đổi được!");
            }
        }

        public DataTable cmbtaikhoan()
        {
            SqlCommand cmd = new SqlCommand("SELECT TAIKHOAN,MATKHAU FROM TaiKhoan");
            m_ds.Load(cmd);
            return m_ds;
        }

        public DataTable TimKiemTatca()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM NhatKy");
            m_ds.Load(cmd);
            return m_ds;
        }

        public DataTable TimKiemTuyChon(String timchuoi)
        {
            SqlCommand cmd = new SqlCommand(timchuoi);
            m_ds.Load(cmd);
            return m_ds;
        }

        public DataTable nhatky(string taikhoan, DateTime date, string noidung, string lydo)
        {

            string dt = date.ToString();
            SqlCommand cmd = new SqlCommand("insert into NhatKy values(N'" + taikhoan + "',N'" + dt + "',N'" + noidung + "',N'" + lydo + "')");
            m_ds.ExecuteNoneQuery(cmd);
            return m_ds;
        }
    }
}
