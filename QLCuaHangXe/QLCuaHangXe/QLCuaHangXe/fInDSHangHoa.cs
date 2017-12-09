using System;

using QLCuaHangXe.Repost;

namespace QLCuaHangXe
{
    public partial class FInDsHangHoa : DevComponents.DotNetBar.Office2007Form
    {
        public FInDsHangHoa()
        {
            InitializeComponent();
        }

        private void fInDSHangHoa_Load(object sender, EventArgs e)
        {
            rptInDSHangHoa r = new rptInDSHangHoa();
            crtReportView1.ReportSource = r;
            Connect();
        }

        rptInDSHangHoa _report = new rptInDSHangHoa();
        private void Connect()
        {
            CrystalDecisions.Shared.TableLogOnInfo tliCurrent = new CrystalDecisions.Shared.TableLogOnInfo();
            foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in _report.Database.Tables)
            {
                tliCurrent = tbCurrent.LogOnInfo;
                tliCurrent.ConnectionInfo.ServerName = QLCuaHangXe.Properties.Settings.Default.servername;
                tliCurrent.ConnectionInfo.UserID = QLCuaHangXe.Properties.Settings.Default.username;
                tliCurrent.ConnectionInfo.Password = QLCuaHangXe.Properties.Settings.Default.pass;
                tliCurrent.ConnectionInfo.DatabaseName = QLCuaHangXe.Properties.Settings.Default.databasename;
                tbCurrent.ApplyLogOnInfo(tliCurrent);
            }
            crtReportView1.ReportSource = _report;
            crtReportView1.Refresh();
        }
    }
}