
using System.Data;
using System.Data.SqlClient;


namespace QLCuaHangXe.DataLayer
{
    public class NhapHangData
    {
        readonly DataService _mDs = new DataService();

        public DataTable Hienthiphieunhap(string ma)
        {
            SqlCommand cmd = new SqlCommand("select CTPNhap.MaPn [Mã Phiếu Nhập], ngaynhaphang [Ngày Nhập], tennhanvien [Nhân Viên], tennhacungcap [Nhà Cung Cấp],tenhang [Tên Hàng], slnhap [Số Lượng],dongianhap [Đơn Giá],thue [Thuế], (slnhap*dongianhap)+(thue*0.01*slnhap*dongianhap) as [Thành Tiền] from ((nhanvien inner join ctpnhap on ctpnhap.manhanvien=nhanvien.manhanvien)inner join nhacungcap on nhacungcap.manhacungcap=ctpnhap.manhacungcap)inner join mathang on mathang.mahang=ctpnhap.mahang where ctpnhap.mapn='" + ma + "'");
            _mDs.Load(cmd);
            return _mDs;
        }

        public DataTable View(string mapn)
        {
            SqlCommand cmd =new SqlCommand( "select * from v_PNhap where Mapn='" + mapn + "'");
            _mDs.Load(cmd);
            return _mDs;
        }

        public bool XoaCtpNhap(Businessobject.ChiTietPn objec)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("delete from CTPNhap where MAPN='" + objec.MaPn + "'");
                _mDs.ExecuteNoneQuery(cmd);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool InsertCtpn(Businessobject.ChiTietPn ctpn)
        {
            SqlCommand cmd = new SqlCommand("insert into CTPNhap values('" + ctpn.MaPn + "','" + 
                                                                               ctpn.MaHang + "','" + 
                                                                               ctpn.SoLuong + "','" + 
                                                                               ctpn.DonGia + "','" + 
                                                                               ctpn.Thue + "','" + 
                                                                               ctpn.Ngaynhap + "','" + 
                                                                               ctpn.Manhanvien + "','" + 
                                                                               ctpn.Manhacungcap + "')");

            _mDs.ExecuteNoneQuery(cmd);
            return true;
        }


        public DataTable Matutang()
        {
            SqlCommand cmd = new SqlCommand("select MAPN from CTPNhap order by MAPN");
            _mDs.Load(cmd);
            return _mDs;
        }

        public DataTable CmbNv()
        {
            SqlCommand cmd = new SqlCommand("select MANHANVIEN,TENNHANVIEN from NhanVien");
            _mDs.Load(cmd);
            return _mDs;
        }

        public DataTable CmbNcc()
        {
            SqlCommand cmd = new SqlCommand("select MANHACUNGCAP,TENNHACUNGCAP from NhaCungCap");
            _mDs.Load(cmd);
            return _mDs;
        }

        public DataTable CmbHang()
        {
            SqlCommand cmd = new SqlCommand("select MAHANG,TENHANG from MatHang");
            _mDs.Load(cmd);
            return _mDs;
        }

        public DataTable load_dshangnhap(string thang, string nam)
        {
            SqlCommand cmd = new SqlCommand(" select * from v_DanhSachPNhap where Tháng='" + thang + "' and Năm ='" + nam + "'");
            _mDs.Load(cmd);
            return _mDs;
        }
    }
}
