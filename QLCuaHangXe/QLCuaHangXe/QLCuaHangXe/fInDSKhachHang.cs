using System;

using QLCuaHangXe.Repost;

namespace QLCuaHangXe
{
    public partial class fInDSKhachHang : DevComponents.DotNetBar.Office2007Form
    {
        public fInDSKhachHang()
        {
            InitializeComponent();
        }

        private void fInDSKhachHang_Load(object sender, EventArgs e)
        {
            //DataService.OpenConnection();
            rptKhachHang r = new rptKhachHang();
            //crystalReportViewer1.ReportSource = r;
            Connect();
        }

        rptKhachHang report = new rptKhachHang();
        private void Connect()
        {
            CrystalDecisions.Shared.TableLogOnInfo tliCurrent = new CrystalDecisions.Shared.TableLogOnInfo();
            foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in report.Database.Tables)
            {
                tliCurrent = tbCurrent.LogOnInfo;
                tliCurrent.ConnectionInfo.ServerName = QLCuaHangXe.Properties.Settings.Default.servername;
                tliCurrent.ConnectionInfo.UserID = QLCuaHangXe.Properties.Settings.Default.username;
                tliCurrent.ConnectionInfo.Password = QLCuaHangXe.Properties.Settings.Default.pass;
                tliCurrent.ConnectionInfo.DatabaseName = QLCuaHangXe.Properties.Settings.Default.databasename;
                tbCurrent.ApplyLogOnInfo(tliCurrent);
            }
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Refresh();
        }

    }
}