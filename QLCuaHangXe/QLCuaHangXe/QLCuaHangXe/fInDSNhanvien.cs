using System;
/*
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
 * */
using QLCuaHangXe.Repost;

namespace QLCuaHangXe
{
    public partial class FInDsNhanvien : DevComponents.DotNetBar.Office2007Form
    {
        public FInDsNhanvien()
        {
            InitializeComponent();
        }

        private void fInDSNhanvien_Load(object sender, EventArgs e)
        {
            rptNhanVien r = new rptNhanVien();
            crystalReportViewer1.ReportSource = r;
            Connect();
        }

        readonly rptNhanVien _report = new rptNhanVien();
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
            crystalReportViewer1.ReportSource = _report;
            crystalReportViewer1.Refresh();
        }

    }
}