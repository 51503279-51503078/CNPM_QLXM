
using System;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLCuaHangXe.Controller;

namespace UnitTestProject1
{
    /// <summary>
    /// Summary description for TestNhatKy
    /// </summary>
    [TestClass]
    public class TestNhatKy
    {
        private CNhatKyCtr nhatky;

        [TestMethod]
        public void TestMethod1()
        {
            Label label = new Label();
            nhatky = new CNhatKyCtr();
            DataGridView dg = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)(dg)).BeginInit();
            nhatky.DatagridNhatky(dg,label);
        }
        

        [TestMethod]
        public void TestMethod3()
        {
            //Label label = new Label();
            nhatky = new CNhatKyCtr();
            DataGridView dg = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)(dg)).BeginInit();
            nhatky.HienThiTimKiemTatCa(dg);
        }
        [TestMethod]
        public void TestMethod4()
        {
            //Label label = new Label();
            nhatky = new CNhatKyCtr();
            ComboBox box = new ComboBox();
            nhatky.HienThiComboBox(box);
        }
    }
}
