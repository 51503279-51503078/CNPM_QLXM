using System;
using System.Windows.Forms;
using QLCuaHangXe.Repost;

namespace QLCuaHangXe
{
    public partial class FTtHang : DevComponents.DotNetBar.Office2007Form
    {
        public FTtHang()
        {
            InitializeComponent();
        }

        private void fTonKho_Load(object sender, EventArgs e)
        {
            rpthangTon f = new rpthangTon();
            crtReportView1.ReportSource = f;
            Connect();
        }

        rpthangTon _report = new rpthangTon();
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

        private void crtReportView1_Load(object sender, EventArgs e)
        {
            MessageBox.Show(@"Chức năng này sẽ được cập nhật vào bản kế tiếp !!! Vui lòng trả tiền cho em làm thêm");
        }
    }
}