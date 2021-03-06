using System;

using System.Windows.Forms;

using DevComponents.DotNetBar.Rendering;
using DevComponents.DotNetBar;
using QLCuaHangXe.DataLayer;
using QLCuaHangXe.Businessobject;

namespace QLCuaHangXe
{
    public partial class FMain : DevComponents.DotNetBar.Office2007Form
    {
        public FMain()
        {
            InitializeComponent();
        }

        private void btNCC_Click(object sender, EventArgs e)
        {
            FNcc d = new FNcc();
            d.MdiParent = this;
            d.Show();
            CNhatKy objec = new CNhatKy();
            DateTime ngay = DateTime.Now;
            new CNhatKyData().Nhatky(objec.TaiKhoan, ngay, "Đăng Nhập", "Xem Nhà Cung Cấp");
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            fGioiThieu f = new fGioiThieu();
            f.MdiParent = this;
            f.Show();
        }

        private void btKhach_Click(object sender, EventArgs e)
        {
            FKhachhang kh = new FKhachhang();
            kh.MdiParent = this;
            kh.Show();
            CNhatKy objec = new CNhatKy();
            DateTime ngay = DateTime.Now;
            new CNhatKyData().Nhatky(objec.TaiKhoan, ngay, "Đăng Nhập", "Xem Khách Hàng");
        }

        private void timer_marquee_Tick(object sender, EventArgs e)
        {
            lblMenu_marquee.Text = lblMenu_marquee.Text.Substring(1, lblMenu_marquee.Text.Length - 1) + lblMenu_marquee.Text.Substring(0, 1);
            lbdh.Text = DateTime.Now.ToLongTimeString();
        }

        private void btNV_Click(object sender, EventArgs e)
        {
            fNhanvien nv = new fNhanvien();
            nv.MdiParent = this;
            nv.Show();
            CNhatKy objec = new CNhatKy();
            DateTime ngay = DateTime.Now;
            new CNhatKyData().Nhatky(objec.TaiKhoan, ngay, "Đăng Nhập Hệ Thống", "Xem Nhân Viên");
        }

        private void btHang_Click(object sender, EventArgs e)
        {
            FHangHoa tt = new FHangHoa { MdiParent = this};
            tt.Show();
            CNhatKy objec = new CNhatKy();
            DateTime ngay = DateTime.Now;
            new CNhatKyData().Nhatky(objec.TaiKhoan, ngay, "Đăng Nhập", "Xem Hàng");
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            DataService.OpenConnection();
        }

        private void btHangTon_Click(object sender, EventArgs e)
        {
            FTtHang ht = new FTtHang();
            ht.MdiParent = this;
            ht.Show();
            CNhatKy objec = new CNhatKy();
            DateTime ngay = DateTime.Now;
            new CNhatKyData().Nhatky(objec.TaiKhoan, ngay, @"Đăng Nhập", @"Thông Tin Hàng");
        }

        private void btnQuanTri_Click(object sender, EventArgs e)
        {
            fQuantri qt = new fQuantri();
            qt.MdiParent = this;
            qt.Show();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            FXuatHang x = new FXuatHang();
            x.MdiParent = this;
            x.Show();
            CNhatKy objec = new CNhatKy();
            DateTime ngay = System.DateTime.Now;
            new CNhatKyData().Nhatky(objec.TaiKhoan, ngay, "Đăng Nhập", "Xuất Hàng");
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            FDoiMk d = new FDoiMk();
            d.MdiParent = this;
            d.Show();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult dx = new DialogResult();
            dx = MessageBox.Show(@"Bạn Có Thực Sự Muốn Đăng Xuất", @"Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dx.ToString() == @"OK")
            {
                FDangnhap fr = new FDangnhap();
                fr.Show();
                this.Hide();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult th = new DialogResult();
            th = MessageBox.Show(@"Bạn Có Thực Sự Muốn Thoát", @"Thong Bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (th.ToString() == @"OK")
                Application.Exit();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            FNhapHang n = new FNhapHang();
            n.MdiParent = this;
            n.Show();
            CNhatKy objec = new CNhatKy();
            DateTime ngay = System.DateTime.Now;
            new CNhatKyData().Nhatky(objec.TaiKhoan, ngay, "Đăng Nhập", "Nhập Hàng");
        }        

        private void buttonItem2_Click(object sender, EventArgs e)
        {
            FDoiMk d = new FDoiMk();
            d.MdiParent = this;
            d.Show();
            CNhatKy objec = new CNhatKy();
            DateTime ngay = System.DateTime.Now;
            new CNhatKyData().Nhatky(objec.TaiKhoan, ngay, "Đăng Nhập", "Đổi Mật Khẩu");
        }

        private void buttonItem3_Click(object sender, EventArgs e)
        {
            DialogResult th = new DialogResult();
            th = MessageBox.Show(@"Bạn Có Thực Sự Muốn Thoát", @"Thong Bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (th.ToString() == @"OK")
                Application.Exit();
        }

        private void buttonItem6_Click(object sender, EventArgs e)
        {
            fPhucHoiDL ph = new fPhucHoiDL();
            ph.MdiParent = this;
            ph.Show();
            CNhatKy objec = new CNhatKy();
            DateTime ngay = DateTime.Now;
            new CNhatKyData().Nhatky(objec.TaiKhoan, ngay, "Đăng Nhập Hệ Thống", "Phục Hồi Dữ Liệu");
        }

        private void buttonItem7_Click(object sender, EventArgs e)
        {
            FNhatKy nk = new FNhatKy();
            nk.MdiParent = this;
            nk.Show();
            CNhatKy objec = new CNhatKy();
            DateTime ngay = System.DateTime.Now;
            new CNhatKyData().Nhatky(objec.TaiKhoan, ngay, "Đăng Nhập", "Xem Nhật Ký");
        }

        private void buttonItem8_Click(object sender, EventArgs e)
        {
            CNhatKyData xoa = new CNhatKyData();
            if (MessageBox.Show(@"Bạn có chắc chắn xóa tất cả nhật ký hoạt động của chương trình không?", @"Thong Bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                xoa.DeleteNhatKy();
            }
        }

        private eOffice2007ColorScheme _mBaseColorScheme = eOffice2007ColorScheme.Black;
        private void colorPickerDropDown2_SelectedColorChanged(object sender, EventArgs e)
        {
            colorPickerDropDown1.CommandParameter = colorPickerDropDown1.SelectedColor;
        }

        private void colorPickerDropDown2_ColorPreview(object sender, ColorPreviewEventArgs e)
        {
            RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(this, _mBaseColorScheme, e.Color);
        }

        private void buttonItem7_Click_1(object sender, EventArgs e)
        {
            DialogResult th = new DialogResult();
            th = MessageBox.Show("Bạn Có Thực Sự Muốn Thoát", "Thong Bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (th.ToString() == "OK")
                Application.Exit();
        }

        private void buttonItem8_Click_1(object sender, EventArgs e)
        {
            DialogResult dx = new DialogResult();
            dx = MessageBox.Show("Bạn Có Thực Sự Muốn Đăng Xuất", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dx.ToString() == "OK")
            {
                FDangnhap fr = new FDangnhap();
                fr.Show();
                this.Hide();
            }
        }

        private void btsaoluu_Click(object sender, EventArgs e)
        {           
            fSaoLuuDL sl = new fSaoLuuDL();
            sl.MdiParent = this;
            sl.Show();
            CNhatKy objec = new CNhatKy();
            DateTime ngay = System.DateTime.Now;
            new CNhatKyData().Nhatky(objec.TaiKhoan, ngay, "Đăng Nhập Hệ Thống", "Sao Lưu Dữ Liệu");
        }

        private void btdanhthu_Click(object sender, EventArgs e)
        {
            FDanhthu dt = new FDanhthu();
            dt.MdiParent = this;
            dt.Show();
            CNhatKy objec = new CNhatKy();
            DateTime ngay = System.DateTime.Now;
            new CNhatKyData().Nhatky(objec.TaiKhoan, ngay, "Đăng Nhập", "Báo Cáo Danh Thu");
        }

        private void thoátToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hiệnToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Show();
            WindowState = FormWindowState.Normal;
        }

        private void ẩnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            WindowState = FormWindowState.Normal;
        }

        private void buttonItem9_Click(object sender, EventArgs e)
        {
            FBaoCaoXuatHang f = new FBaoCaoXuatHang();
            f.MdiParent = this;
            f.Show();
            CNhatKy objec = new CNhatKy();
            DateTime ngay = System.DateTime.Now;
            new CNhatKyData().Nhatky(objec.TaiKhoan, ngay, "Đăng Nhập", "Danh sách hàng xuất");
        }

        private void buttonItem10_Click(object sender, EventArgs e)
        {
            FBaoCaoNhapHang n = new FBaoCaoNhapHang();
            n.MdiParent = this;
            n.Show();
            CNhatKy objec = new CNhatKy();
            DateTime ngay = System.DateTime.Now;
            new CNhatKyData().Nhatky(objec.TaiKhoan, ngay, "Đăng Nhập", "Danh sách hàng nhập");
        }

        private void buttonItem6_Click_1(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "QLCuaHangXe.chm");
        }

        public void Nhanvien()
        {
            btNV.Enabled = false;
            btnQuanTri.Enabled = false;
            btsaoluu.Enabled = false;
            btphuchoi.Enabled = false;
            btnhatky.Enabled = false;
            btxoanhatky.Enabled = false;
        }

        public void Quanly()
        {
            btnQuanTri.Enabled = false;
            btsaoluu.Enabled = false;
            btphuchoi.Enabled = false;
            btxoanhatky.Enabled = false;
        }

        private void btnhatky_Click(object sender, EventArgs e)
        {
            FNhatKy nk = new FNhatKy();
            nk.MdiParent = this;
            nk.Show();
            CNhatKy objec = new CNhatKy();
            DateTime ngay = System.DateTime.Now;
            new CNhatKyData().Nhatky(objec.TaiKhoan, ngay, "Đăng Nhập", "Xem Nhật Ký");
        }

        private void btxoanhatky_Click(object sender, EventArgs e)
        {
            CNhatKyData xoa = new CNhatKyData();
            if (MessageBox.Show(@"Bạn có chắc chắn xóa tất cả nhật ký hoạt động của chương trình không?", "Thong Bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                xoa.DeleteNhatKy();
            }
        }

        private void lblMenu_marquee_Click(object sender, EventArgs e)
        {

        }

        private void btHangBanChay_Click(object sender, EventArgs e)
        {
            FHangBanChay f = new FHangBanChay();
            f.MdiParent = this;
            f.Show();
        }


        private void buttonItem5_Click_1(object sender, EventArgs e)
        {
            FXuatHang _fXuatHang = new FXuatHang();
            _fXuatHang.MdiParent = this;
            _fXuatHang.Show();
        }

        private void HoaDon_Click(object sender, EventArgs e)
        {

        }
    }
}