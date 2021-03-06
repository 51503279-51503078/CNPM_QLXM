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
    public class XuatHang_Data
    {
        DataService m_ds = new DataService();
        //in hoa don theo ma
        public DataTable view(string mapx)
        {
            SqlCommand cmd = new SqlCommand("select * from v_PXuat where Mapx='" + mapx + "'");
            m_ds.Load(cmd);
            return m_ds;
        }

        public DataTable datagridPX(string ma)
        {
            SqlCommand cmd = new SqlCommand("select CTPXuat.MaPX [Mã Phiếu Xuất], ngayxuathang[Ngày Xuất], tennhanvien [Nhân Viên], tenkhachhang [Khách Hàng],tenhang [Tên Hàng], slxuat [Số Lượng Xuất],dongiaxuat [Đơn Giá Xuất],thue[Thuế], slxuat*dongiaxuat as [Thành Tiền] from ((nhanvien inner join ctpxuat on ctpxuat.manhanvien=nhanvien.manhanvien)inner join khachhang on khachhang.makhachhang=ctpxuat.makhachhang)inner join mathang on mathang.mahang=ctpxuat.mahang where ctpxuat.mapx='" + ma + "'");
            m_ds.Load(cmd);
            return m_ds;
        }

        public DataTable cmbHang()
        {
            SqlCommand cmd = new SqlCommand("select MAHANG,TENHANG from MatHang");
            m_ds.Load(cmd);
            return m_ds;
        }

        public DataTable cmbNV()
        {
            SqlCommand cmd = new SqlCommand("select MANHANVIEN,TENNHANVIEN from NhanVien");
            m_ds.Load(cmd);
            return m_ds;
        }

        public DataTable cmbKH()
        {
            SqlCommand cmd = new SqlCommand("select MAKHACHHANG,TENKHACHHANG from KhachHang");
            m_ds.Load(cmd);
            return m_ds;
        }

        public DataTable matutang()
        {
            SqlCommand cmd = new SqlCommand("select MAPX from CTPXuat order by MAPX");
            m_ds.Load(cmd);
            return m_ds;
        }

        public bool insertCTPX(Businessobject.ChiTietPX ctpx)
        {
            SqlCommand cmd = new SqlCommand("insert into CTPXuat values('" + ctpx.MaPX + "','" + 
                                                                                 ctpx.MaHang + "','" +  
                                                                                 ctpx.SoLuong + "',N'" + 
                                                                                 ctpx.NgayXuat +"','" +  
                                                                                 ctpx.DonGia + "','" + 
                                                                                 ctpx.Thue + "',N'" +
                                                                                 ctpx.Manhanvien +"',N'" +
                                                                                 ctpx.Makhachhang +"')");

            m_ds.ExecuteNoneQuery(cmd);
            return true;
        }
        public int soluong(string ma)
        {
            SqlCommand cmd = new SqlCommand("select soluong from MatHang where mahang='"+ma+"'");
            Object obj = m_ds.ExecuteScalar(cmd);
            return Convert.ToInt32(obj);
            
        }
        public bool XoaCTPXuat(Businessobject.ChiTietPX objec)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("delete from CTPXuat where MAPX='" + objec.MaPX + "'");
                m_ds.ExecuteNoneQuery(cmd);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public long layGiaBan(string ma)
        {
            long a=0;
            SqlCommand select = new SqlCommand("select DGBAN from MatHang where MAHANG='" + ma + "'");
            m_ds.Load(select);
            try
            {
                a = Convert.ToInt64(m_ds.Rows[0][0]);
            }
            catch
            {
            }
            return a;
        }

        public DataTable load_dshangxuat(string thang, string nam)
        {
            SqlCommand cmd = new SqlCommand(" select * from v_DanhSachPXuat where Tháng='" + thang + "' and Năm ='" + nam + "'");
            m_ds.Load(cmd);
            return m_ds;
        }
    }
}
