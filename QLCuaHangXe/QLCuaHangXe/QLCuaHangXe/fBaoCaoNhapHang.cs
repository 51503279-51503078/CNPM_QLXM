using System;

using QLCuaHangXe.Repost;
using QLCuaHangXe.DataLayer;

namespace QLCuaHangXe
{
    public partial class FBaoCaoNhapHang : DevComponents.DotNetBar.Office2007Form
    {
        public FBaoCaoNhapHang()
        {
            InitializeComponent();
        }

        public void Gancombo()
        {
            for (int i = 1; i <= 12; i++)
            {
                cmbThang.Items.Add(i);
            }
            for (int j = 2009; j <= 2017; j++)
                cmbNam.Items.Add(j);
            cmbNam.SelectedIndex = 0;
            cmbThang.SelectedIndex = 0;
        }

        private void fBaoCaoNhapHang_Load(object sender, EventArgs e)
        {
            Gancombo();
        }

        readonly NhapHangData _data = new NhapHangData();
        readonly rptBaoCaoNhapHang _report = new rptBaoCaoNhapHang();
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

        private void btnXem_Click_1(object sender, EventArgs e)
        {
            rptBaoCaoNhapHang f = new rptBaoCaoNhapHang();
            f.SetDataSource(_data.load_dshangnhap(cmbThang.Text, cmbNam.Text));
            crtReportView1.ReportSource = f;
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbNam_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}