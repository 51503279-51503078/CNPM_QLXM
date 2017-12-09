using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QLCuaHangXe.DataLayer;
using QLCuaHangXe.Repost;

namespace QLCuaHangXe
{
    public partial class fInPNhap : DevComponents.DotNetBar.Office2007Form
    {
        string maHD = "";
        NhapHangData nhap=new NhapHangData();
        public fInPNhap(string ma)
        {
            InitializeComponent();
            maHD = ma;
        }

        private void fInPNhap_Load(object sender, EventArgs e)
        {
            rptpnhap r = new rptpnhap();
            r.SetDataSource(nhap.View(maHD));
            crystalReportViewer1.ReportSource = r;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            MessageBox.Show(@"Tạm ngưng phục vụ vì deadline dí quá làm không kiệp");
        }
    }
}