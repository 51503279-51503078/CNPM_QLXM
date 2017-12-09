using System;

using QLCuaHangXe.Repost;
using QLCuaHangXe.DataLayer;

namespace QLCuaHangXe
{
    public partial class FBaoCaoXuatHang : DevComponents.DotNetBar.Office2007Form
    {
        public FBaoCaoXuatHang()
        {
            InitializeComponent();
        }

        public void Gancombo()
        {
            for (int i = 1; i <= 12; i++)
            {
                cmbThang.Items.Add(i);
            }
            for (int j = 2009; j <= 2099; j++)
                cmbNam.Items.Add(j);
            cmbNam.SelectedIndex = 0;
            cmbThang.SelectedIndex = 0;
        }

        private void fBaoCaoXuatHang_Load(object sender, EventArgs e)
        {
            Gancombo();
        }

        readonly XuatHangData _data = new XuatHangData();
        readonly rptBaoCaoXuatHang _report = new rptBaoCaoXuatHang();
        
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
            crtReportView1.ReportSource = _report;
            crtReportView1.Refresh();
        }

        private void btnXem_Click_1(object sender, EventArgs e)
        {
            rptBaoCaoXuatHang f = new rptBaoCaoXuatHang();
            f.SetDataSource(_data.load_dshangxuat(cmbThang.Text, cmbNam.Text));
            crtReportView1.ReportSource = f;
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbThang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}