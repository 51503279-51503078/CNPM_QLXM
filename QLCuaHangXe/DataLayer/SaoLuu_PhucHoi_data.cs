using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Security.Cryptography;
using DevComponents.DotNetBar;

namespace QLCuaHangXe.DataLayer
{
    class SaoLuu_PhucHoi_data
    {
        DataService m_ds = new DataService();
        public bool SaoLuuDuLieu(string duongDan)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(" backup database QLXe to disk = '" + duongDan + "'");
                m_ds.Load(cmd);
                MessageBox.Show("Sao lưu thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch
            {
                MessageBox.Show("Có lỗi khi sao lưu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
        }

        public bool PhucHoiDuLieu(string duongDan)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(" use master restore database QLXe from disk = '" + duongDan + "' with REPLACE");
                m_ds.Load(cmd);
                MessageBox.Show("Phục hồi thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch
            {
                MessageBox.Show("Không thể phục hồi CSDL", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
        }
    }
}
