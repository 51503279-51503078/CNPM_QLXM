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
    public partial class fInPXuat : DevComponents.DotNetBar.Office2007Form
    {
        string mapx = "";
        XuatHangData xuat = new XuatHangData();
        public fInPXuat(string ma)
        {
            InitializeComponent();
            mapx = ma;
        }

        private void fInPXuat_Load(object sender, EventArgs e)
        {
            rptpxuat r = new rptpxuat();
            r.SetDataSource(xuat.View(mapx));
            crystalReportViewer1.ReportSource = r;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(@"Tạm ngưng hoạt động vì deadline dí quá !!! thầy thông cảm T_T");
        }
    }
}