using System;

using System.Data;
using System.Windows.Forms;


using QLCuaHangXe.DataLayer;



namespace QLCuaHangXe
{
    public partial class FDangnhap : DevComponents.DotNetBar.Office2007Form
    {

        public FDangnhap()
        {
            InitializeComponent();
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btok_Click(object sender, EventArgs e)
        {
            Dangnhap();
        }

        public void Dangnhap()
        {
            DataTable admin = new CDangnhapdata().Quyenadmin(txttendn.Text, txtmatkhau.Text);
            DataTable nv = new CDangnhapdata().Quyennhanvien(txttendn.Text, txtmatkhau.Text);
            DataTable quanly = new CDangnhapdata().Quyenquanly(txttendn.Text, txtmatkhau.Text);
            if (txttendn.Text == "" || txtmatkhau.Text == "")
            {
                MessageBox.Show(@"Bạn Chưa Nhập Tên Hoặc Mật Khẩu");
            }
            else if (admin.Rows.Count == 1)
            {
                MessageBox.Show(@"Đăng Nhập Thành Công Với Quyền Admin");
                new FMain().Show();
                Hide();
                DateTime ngay = DateTime.Now;
                new CNhatKyData().Nhatky(txttendn.Text.Trim(), ngay, "Đăng Nhập Hệ Thống", "Đăng Nhập");
            }
            else if (nv.Rows.Count == 1)
            {
                MessageBox.Show(@"Đăng Nhập Thành Công Với Quyền Nhân Viên");
                FMain n = new FMain();
                n.Nhanvien();
                n.Show();
                Hide();
                DateTime ngay = DateTime.Now;
                new CNhatKyData().Nhatky(txttendn.Text.Trim(), ngay, "Đăng Nhập Quyền Nhân Viên", "Đăng Nhập");
            }
            else if (quanly.Rows.Count == 1)
            {
                MessageBox.Show(@"Đăng Nhập Thành Công Với Quyền Quản Lý");
                FMain q = new FMain();
                q.Quanly();
                q.Show();
                Hide();
                DateTime ngay = DateTime.Now;
                new CNhatKyData().Nhatky(txttendn.Text.Trim(), ngay, "Đăng Nhập Quyền Quan Lý", "Đăng Nhập");
            }
            else
                MessageBox.Show(@"Tài Khoản Không Hợp Lệ");
        }

        private void timer_Clock_Tick(object sender, EventArgs e)
        {
            lblClock.Text = @"Bây giờ là: " + DateTime.Now.ToLongTimeString();
                //progressBarX1.Visible = true;
                //progressBarX1.Value = progressBarX1.Value + 5;
                //if (progressBarX1.Value == 100)
                //    this.Close();
        }

        private void fDangnhap_Load_1(object sender, EventArgs e)
        {
            DataService.OpenConnection();
            //progressBarX1.Visible = false;
        }        
    }
}