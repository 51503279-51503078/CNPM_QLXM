using System;

using System.Data;

using System.Windows.Forms;
using QLCuaHangXe.DataLayer;


namespace QLCuaHangXe.Controller
{
    public class CThogntinSpcTr
    {
        readonly CThigntinSPdata _data = new CThigntinSPdata();

        public void HienthicmbNcc(ComboBox cmb)
        {
            DataTable tbl = _data.load_cmb();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "TENNHACUNGCAP";
            cmb.ValueMember = "MANHACUNGCAP";
        }

        public void Hienthisanpham(DataGridView dg)
        {
            BindingSource bs = new BindingSource();
            DataTable tb = _data.HienthiSanPham();
            bs.DataSource = tb;
            dg.DataSource = bs;
        }

        public void Hienthitree(DataGridView dg, string ten)
        {
            BindingSource bs = new BindingSource();
            DataTable tb = _data.Hienthitreeview(ten);
            bs.DataSource = tb;
            dg.DataSource = bs;
        }

        readonly CThigntinSPdata _data1 = new CThigntinSPdata();
        readonly CThigntinSPdata _data2 = new CThigntinSPdata();
        public void Treeview(TreeView tree)
        {
            DataTable ncc = _data1.load_cmb();
            Console.WriteLine(@"ncc.Rows.Count" + ncc.Rows.Count);
            for (int i = 0; i < ncc.Rows.Count; i++)
            {
                Console.WriteLine(@"ncc.Rows.Count" + ncc.Rows.Count);
            }
            for (int i = 0; i < ncc.Rows.Count; i++)
            {
                string tenncc = ncc.Rows[i]["TENNHACUNGCAP"].ToString();
                string mancc = ncc.Rows[i]["MANHACUNGCAP"].ToString();
                Console.WriteLine(tenncc + "" + mancc);
                tree.Nodes.Add(tenncc);
                tree.Nodes[i].ImageIndex = 0;
                DataTable sp = _data2.Sanpham(mancc);
                if (sp.Rows.Count == 0)
                {
                    continue;
                }
                for (int j = 0; j < sp.Rows.Count; j++)
                {
                    string tensp = sp.Rows[j]["TENHANG"].ToString();
                    Console.WriteLine(tenncc);
                    tree.Nodes[i].Nodes.Add(tensp);
                    tree.Nodes[i].Nodes[j].ImageIndex = 1;
                }
            }
        }
    }
}
