
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLCuaHangXe.Controller;
namespace UnitTestProject1
{
    /// <summary>
    /// Summary description for TestClassNhanVien
    /// </summary>
    [TestClass]
    public class TestClassNhanVien
    {
        private CNhanvienCtr _nhanvien;
        [TestMethod]
        public void TestMethod1()
        {
            _nhanvien = new CNhanvienCtr();
            TextBox txttennv = new TextBox();
            TextBox txtten = new TextBox();
            TextBox txtns = new TextBox();
            TextBox txtdc = new TextBox();
            TextBox txtdt = new TextBox();
            TextBox txtchv = new TextBox();
            TextBox txtluong = new TextBox();

            txttennv.Text = @"";
            txtten.Text = @"";
            txtns.Text = @"";
            txtdc.Text = @"";
            txtdt.Text = @"";
            txtchv.Text = @"";
            txtluong.Text = @"";

            bool test = _nhanvien.KiemTraLuu(txttennv, txtten, txtns, txtdc, txtdt, txtchv, txtluong);
            Assert.AreEqual(false,test);
        }


        [TestMethod]
        public void TestMethod2()
        {
            _nhanvien = new CNhanvienCtr();
            TextBox txttennv = new TextBox();
            TextBox txtten = new TextBox();
            TextBox txtns = new TextBox();
            TextBox txtdc = new TextBox();
            TextBox txtdt = new TextBox();
            TextBox txtchv = new TextBox();
            TextBox txtluong = new TextBox();

            txttennv.Text = @"Nam";
            txtten.Text = @"";
            txtns.Text = @"";
            txtdc.Text = @"";
            txtdt.Text = @"";
            txtchv.Text = @"";
            txtluong.Text = @"";

            bool test = _nhanvien.KiemTraLuu(txttennv, txtten, txtns, txtdc, txtdt, txtchv, txtluong);
            Assert.AreEqual(false, test);
        }

        [TestMethod]
        public void TestMethod3()
        {
            _nhanvien = new CNhanvienCtr();
            TextBox txttennv = new TextBox();
            TextBox txtten = new TextBox();
            TextBox txtns = new TextBox();
            TextBox txtdc = new TextBox();
            TextBox txtdt = new TextBox();
            TextBox txtchv = new TextBox();
            TextBox txtluong = new TextBox();

            txttennv.Text = @"Nam";
            txtten.Text = @"Nam";
            txtns.Text = @"";
            txtdc.Text = @"";
            txtdt.Text = @"";
            txtchv.Text = @"";
            txtluong.Text = @"";

            bool test = _nhanvien.KiemTraLuu(txttennv, txtten, txtns, txtdc, txtdt, txtchv, txtluong);
            Assert.AreEqual(false, test);
        }

        [TestMethod]
        public void TestMethod4()
        {
            _nhanvien = new CNhanvienCtr();
            TextBox txttennv = new TextBox();
            TextBox txtten = new TextBox();
            TextBox txtns = new TextBox();
            TextBox txtdc = new TextBox();
            TextBox txtdt = new TextBox();
            TextBox txtchv = new TextBox();
            TextBox txtluong = new TextBox();

            txttennv.Text = @"Nam";
            txtten.Text = @"Nam";
            txtns.Text = @"Nam";
            txtdc.Text = @"";
            txtdt.Text = @"";
            txtchv.Text = @"";
            txtluong.Text = @"";

            bool test = _nhanvien.KiemTraLuu(txttennv, txtten, txtns, txtdc, txtdt, txtchv, txtluong);
            Assert.AreEqual(false, test);
        }

        [TestMethod]
        public void TestMethod5()
        {
            _nhanvien = new CNhanvienCtr();
            TextBox txttennv = new TextBox();
            TextBox txtten = new TextBox();
            TextBox txtns = new TextBox();
            TextBox txtdc = new TextBox();
            TextBox txtdt = new TextBox();
            TextBox txtchv = new TextBox();
            TextBox txtluong = new TextBox();

            txttennv.Text = @"Nam";
            txtten.Text = @"Nam";
            txtns.Text = @"Nam";
            txtdc.Text = @"Nam";
            txtdt.Text = @"";
            txtchv.Text = @"";
            txtluong.Text = @"";

            bool test = _nhanvien.KiemTraLuu(txttennv, txtten, txtns, txtdc, txtdt, txtchv, txtluong);
            Assert.AreEqual(false, test);
        }

        [TestMethod]
        public void TestMethod6()
        {
            _nhanvien = new CNhanvienCtr();
            TextBox txttennv = new TextBox();
            TextBox txtten = new TextBox();
            TextBox txtns = new TextBox();
            TextBox txtdc = new TextBox();
            TextBox txtdt = new TextBox();
            TextBox txtchv = new TextBox();
            TextBox txtluong = new TextBox();

            txttennv.Text = @"Nam";
            txtten.Text = @"Nam";
            txtns.Text = @"Nam";
            txtdc.Text = @"Nam";
            txtdt.Text = @"096";
            txtchv.Text = @"Nam";
            txtluong.Text = @"";

            bool test = _nhanvien.KiemTraLuu(txttennv, txtten, txtns, txtdc, txtdt, txtchv, txtluong);
            Assert.AreEqual(false, test);
        }

        [TestMethod]
        public void TestMethod7()
        {
            _nhanvien = new CNhanvienCtr();
            TextBox txttennv = new TextBox();
            TextBox txtten = new TextBox();
            TextBox txtns = new TextBox();
            TextBox txtdc = new TextBox();
            TextBox txtdt = new TextBox();
            TextBox txtchv = new TextBox();
            TextBox txtluong = new TextBox();

            txttennv.Text = @"Nam";
            txtten.Text = @"Nam";
            txtns.Text = @"Nam";
            txtdc.Text = @"Nam";
            txtdt.Text = @"0961563317";
            txtchv.Text = @"Nam";
            txtluong.Text = @"Nam";

            bool test = _nhanvien.KiemTraLuu(txttennv, txtten, txtns, txtdc, txtdt, txtchv, txtluong);
            Assert.AreEqual(true, test);
        }

        [TestMethod]
        public void TestMethod8()
        {
            _nhanvien = new CNhanvienCtr();
            TextBox txttennv = new TextBox();
            TextBox txtten = new TextBox();
            TextBox txtns = new TextBox();
            TextBox txtdc = new TextBox();
            TextBox txtdt = new TextBox();
            TextBox txtchv = new TextBox();
            TextBox txtluong = new TextBox();

            txttennv.Text = @"Nam";
            txtten.Text = @"Nam";
            txtns.Text = @"Nam";
            txtdc.Text = @"Nam";
            txtdt.Text = @"0000";
            txtchv.Text = @"Nam";
            txtluong.Text = @"";

            bool test = _nhanvien.KiemTraLuu(txttennv, txtten, txtns, txtdc, txtdt, txtchv, txtluong);
            Assert.AreEqual(false, test);
        }

        [TestMethod]
        public void TestMethod9()
        {
            _nhanvien = new CNhanvienCtr();
            TextBox txttennv = new TextBox();
            TextBox txtten = new TextBox();
            TextBox txtns = new TextBox();
            TextBox txtdc = new TextBox();
            TextBox txtdt = new TextBox();
            TextBox txtchv = new TextBox();
            TextBox txtluong = new TextBox();

            txttennv.Text = @"Nam";
            txtten.Text = @"Nam";
            txtns.Text = @"Nam";
            txtdc.Text = @"Nam";
            txtdt.Text = @"0000";
            txtchv.Text = @"XkxkX";
            txtluong.Text = @"1131";

            bool test = _nhanvien.KiemTraLuu(txttennv, txtten, txtns, txtdc, txtdt, txtchv, txtluong);
            Assert.AreEqual(false, test);
        }
        [TestMethod]

        public void TestGridView_1()
        {
            _nhanvien = new CNhanvienCtr();
            DataGridView dg = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)(dg)).BeginInit();
            _nhanvien.Hienthidatagridviewtheoma(dg," ");
        }

        [TestMethod]

        public void TestGridView_2()
        {
            _nhanvien = new CNhanvienCtr();
            DataGridView dg = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)(dg)).BeginInit();
            _nhanvien.Hienthidatagridviewtheoma(dg, "NV01");
        }
        [TestMethod]

        public void TestGridView_3()
        {
            _nhanvien = new CNhanvienCtr();
            DataGridView dg = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)(dg)).BeginInit();
            _nhanvien.Hienthinv(dg);
        }
    }
    
}
