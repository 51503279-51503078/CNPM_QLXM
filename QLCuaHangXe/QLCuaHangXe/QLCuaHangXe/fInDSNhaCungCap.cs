using System;

using QLCuaHangXe.Repost;

namespace QLCuaHangXe
{
    public partial class FInDsNhaCungCap : DevComponents.DotNetBar.Office2007Form
    {
        public FInDsNhaCungCap()
        {
            InitializeComponent();
        }

        private void fInDSNhaCungCap_Load(object sender, EventArgs e)
        {
            rptNhaCungCap r = new rptNhaCungCap();
            crystalReportViewer1.ReportSource = r;
            Connect();
        }

       

        rptNhaCungCap _report = new rptNhaCungCap();
        private void Connect()
        {
            CrystalDecisions.Shared.TableLogOnInfo tliCurrent = new CrystalDecisions.Shared.TableLogOnInfo();
            foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in _report.Database.Tables)
            {
                tliCurrent = tbCurrent.LogOnInfo;
                tliCurrent.ConnectionInfo.ServerName = Properties.Settings.Default.servername;
                tliCurrent.ConnectionInfo.UserID = Properties.Settings.Default.username;
                tliCurrent.ConnectionInfo.Password = Properties.Settings.Default.pass;
                tliCurrent.ConnectionInfo.DatabaseName = Properties.Settings.Default.databasename;
                tbCurrent.ApplyLogOnInfo(tliCurrent);
            }
            crystalReportViewer1.ReportSource = _report;
            crystalReportViewer1.Refresh();
        }
    }
}