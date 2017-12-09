using System;

using QLCuaHangXe.Repost;
using QLCuaHangXe.DataLayer;

namespace QLCuaHangXe
{
    public partial class FHangBanChay : DevComponents.DotNetBar.Office2007Form
    {
        public FHangBanChay()
        {
            InitializeComponent();
        }

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

        private void fHangBanChay_Load(object sender, EventArgs e)
        {
            Gancombo();
        }

        HangBanChayData _data = new HangBanChayData();
        private void btbaocao_Click(object sender, EventArgs e)
        {
            rptHangBanChay f = new rptHangBanChay();
            f.SetDataSource(_data.Hangbanchay(cmbthang.Text, cmbnam.Text));
            
            crystalReportViewer1.ReportSource = f;
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbnam_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}