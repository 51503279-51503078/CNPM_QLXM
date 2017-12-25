using System;

using QLCuaHangXe.DataLayer;
using QLCuaHangXe.Repost;

namespace QLCuaHangXe
{
    public partial class FinPNhap : DevComponents.DotNetBar.Office2007Form
    {
        private string _maHd;
        NhapHangData _nhap=new NhapHangData();
        public FinPNhap(string ma)
        {
            InitializeComponent();
            _maHd = ma;
        }

        private void fInPNhap_Load(object sender, EventArgs e)
        {
            rptpnhap r = new rptpnhap();
            r.SetDataSource(_nhap.View(_maHd));
            crystalReportViewer1.ReportSource = r;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(@"Tạm ngưng phục vụ vì deadline dí quá làm không kiệp");
        }
    }
}