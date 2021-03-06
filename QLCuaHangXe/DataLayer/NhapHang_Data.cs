using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;
using QLCuaHangXe.Businessobject;

namespace QLCuaHangXe.DataLayer
{
    public class NhapHang_Data
    {
        DataService m_ds = new DataService();

        public DataTable hienthiphieunhap(string ma)
        {
            SqlCommand cmd = new SqlCommand("select CTPNhap.MaPn [Mã Phiếu Nhập], ngaynhaphang [Ngày Nhập], tennhanvien [Nhân Viên], tennhacungcap [Nhà Cung Cấp],tenhang [Tên Hàng], slnhap [Số Lượng],dongianhap [Đơn Giá],thue [Thuế], (slnhap*dongianhap)+(thue*0.01*slnhap*dongianhap) as [Thành Tiền] from ((nhanvien inner join ctpnhap on ctpnhap.manhanvien=nhanvien.manhanvien)inner join nhacungcap on nhacungcap.manhacungcap=ctpnhap.manhacungcap)inner join mathang on mathang.mahang=ctpnhap.mahang where ctpnhap.mapn='" + ma + "'");
            m_ds.Load(cmd);
            return m_ds;
        }

        public DataTable view(string mapn)
        {
            SqlCommand cmd =new SqlCommand( "select * from v_PNhap where Mapn='" + mapn + "'");
            m_ds.Load(cmd);
            return m_ds;
        }

        public bool XoaCTPNhap(Businessobject.ChiTietPN objec)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("delete from CTPNhap where MAPN='" + objec.MaPN + "'");
                m_ds.ExecuteNoneQuery(cmd);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool insertCTPN(Businessobject.ChiTietPN ctpn)
        {
            SqlCommand cmd = new SqlCommand("insert into CTPNhap values('" + ctpn.MaPN + "','" + 
                                                                               ctpn.MaHang + "','" + 
                                                                               ctpn.SoLuong + "','" + 
                                                                               ctpn.DonGia + "','" + 
                                                                               ctpn.Thue + "','" + 
                                                                               ctpn.Ngaynhap + "','" + 
                                                                               ctpn.Manhanvien + "','" + 
                                                                               ctpn.Manhacungcap + "')");

            m_ds.ExecuteNoneQuery(cmd);
            return true;
        }


        public DataTable matutang()
        {
            SqlCommand cmd = new SqlCommand("select MAPN from CTPNhap order by MAPN");
            m_ds.Load(cmd);
            return m_ds;
        }

        public DataTable cmbNV()
        {
            SqlCommand cmd = new SqlCommand("select MANHANVIEN,TENNHANVIEN from NhanVien");
            m_ds.Load(cmd);
            return m_ds;
        }

        public DataTable cmbNCC()
        {
            SqlCommand cmd = new SqlCommand("select MANHACUNGCAP,TENNHACUNGCAP from NhaCungCap");
            m_ds.Load(cmd);
            return m_ds;
        }

        public DataTable cmbHang()
        {
            SqlCommand cmd = new SqlCommand("select MAHANG,TENHANG from MatHang");
            m_ds.Load(cmd);
            return m_ds;
        }

        public DataTable load_dshangnhap(string thang, string nam)
        {
            SqlCommand cmd = new SqlCommand(" select * from v_DanhSachPNhap where Tháng='" + thang + "' and Năm ='" + nam + "'");
            m_ds.Load(cmd);
            return m_ds;
        }
    }
}
