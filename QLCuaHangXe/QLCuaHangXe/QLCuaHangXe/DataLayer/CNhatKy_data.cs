using System;

using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;


namespace QLCuaHangXe.DataLayer
{
    public class CNhatKyData
    {
        readonly DataService _mDs = new DataService();
        public DataTable load_nhatky()
        {
                SqlCommand cmd =new SqlCommand ("select * from NhatKy");
                _mDs.Load(cmd);
                return _mDs; 
        }

        public void DeleteNhatKy()
        {
            SqlCommand cmd = new SqlCommand("delete NhatKy ");

            try
            {
                _mDs.Load(cmd);
            }
            catch
            {
                MessageBox.Show(@"Không thay đổi được!");
            }
        }

        public DataTable Cmbtaikhoan()
        {
            SqlCommand cmd = new SqlCommand("SELECT TAIKHOAN,MATKHAU FROM TaiKhoan");
            _mDs.Load(cmd);
            return _mDs;
        }

        public DataTable TimKiemTatca()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM NhatKy");
            _mDs.Load(cmd);
            return _mDs;
        }

        public DataTable TimKiemTuyChon(String timchuoi)
        {
            SqlCommand cmd = new SqlCommand(timchuoi);
            _mDs.Load(cmd);
            return _mDs;
        }

        public DataTable Nhatky(string taikhoan, DateTime date, string noidung, string lydo)
        {

            string dt = date.ToString(CultureInfo.InvariantCulture);
            SqlCommand cmd = new SqlCommand( 
                                            "insert into NhatKy(TAIKHOAN,THOIGIAN,GHICHU,LYDO) values(N'" + taikhoan 
                                            + "',N'" + dt + "',N'" + noidung + "',N'" + 
                                                lydo + "')");
            _mDs.ExecuteNoneQuery(cmd);
            return _mDs;
        }
    }
}
