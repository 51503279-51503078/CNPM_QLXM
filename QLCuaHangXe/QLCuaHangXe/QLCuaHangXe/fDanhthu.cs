using System;

using QLCuaHangXe.Repost;
using QLCuaHangXe.DataLayer;

namespace QLCuaHangXe
{
    public partial class FDanhthu : DevComponents.DotNetBar.Office2007Form
    {
        public FDanhthu()
        {
            InitializeComponent();
        }

        readonly DanhThuData _data = new DanhThuData();
        public void Gancombo()
        {
            for (int i = 1; i <= 12; i++)
            {
                cmbthang.Items.Add(i);
            }
            for (int j = 2009; j <= 2099; j++)
                cmbnam.Items.Add(j);
            cmbnam.SelectedIndex = 0;
            cmbthang.SelectedIndex = 0;
        }

        private void fDanhthu_Load(object sender, EventArgs e)
        {
            Gancombo();
            
        }

        readonly rptDanhThu1 _report = new rptDanhThu1();
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

        private void btbaocao_Click_1(object sender, EventArgs e)
        {
            rptDanhThu1 f = new rptDanhThu1();
            f.SetDataSource(_data.Doanhthu(cmbthang.Text, cmbnam.Text));
            crystalReportViewer1.ReportSource = f;
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbnam_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}