
using System;
using System.Security.Policy;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLCuaHangXe.Controller;
namespace UnitTestProject1
{
    /// <summary>
    /// Summary description for TestClassNhaCungCap
    /// </summary>
    [TestClass]
    public class TestClassNhaCungCap
    {
        private CNhacungcapCtr nhacungcap;
        private DataGridView dg;
        private TextBox box;
        [TestMethod]
        
        public void TestEmail_1()
        {
            nhacungcap = new CNhacungcapCtr();
            box = new TextBox();
            bool test = nhacungcap.KiemTraEmail("123", box);
            Assert.AreEqual(false,test);
        }
        [TestMethod]

        public void TestEmail_2()
        {
            nhacungcap = new CNhacungcapCtr();
            box = new TextBox();
            bool test = nhacungcap.KiemTraEmail("123@", box);
            Assert.AreEqual(false, test);
        }
        [TestMethod]

        public void TestEmail_3()
        {
            nhacungcap = new CNhacungcapCtr();
            box = new TextBox();
            bool test = nhacungcap.KiemTraEmail("123.", box);
            Assert.AreEqual(false, test);
        }
        [TestMethod]

        public void TestEmail_4()
        {
            nhacungcap = new CNhacungcapCtr();
            box = new TextBox();
            bool test = nhacungcap.KiemTraEmail("123@@", box);
            Assert.AreEqual(false, test);
        }
        [TestMethod]

        public void TestEmail_5()
        {
            nhacungcap = new CNhacungcapCtr();
            box = new TextBox();
            bool test = nhacungcap.KiemTraEmail("123..", box);
            Assert.AreEqual(false, test);
        }
        [TestMethod]

        public void TestEmail_6()
        {
            nhacungcap = new CNhacungcapCtr();
            box = new TextBox();
            bool test = nhacungcap.KiemTraEmail("123~", box);
            Assert.AreEqual(false, test);
        }
        [TestMethod]

        public void TestEmail_7()
        {
            nhacungcap = new CNhacungcapCtr();
            box = new TextBox();
            bool test = nhacungcap.KiemTraEmail("!", box);
            Assert.AreEqual(false, test);
        }
        [TestMethod]

        public void TestEmail_8()
        {
            nhacungcap = new CNhacungcapCtr();
            box = new TextBox();
            bool test = nhacungcap.KiemTraEmail("", box);
            Assert.AreEqual(true, test);
        }
        [TestMethod]

        public void TestEmail_9()
        {
            nhacungcap = new CNhacungcapCtr();
            box = new TextBox();
            bool test = nhacungcap.KiemTraEmail(" ", box);
            Assert.AreEqual(false, test);
        }
        [TestMethod]

        public void TestEmail_10()
        {
            nhacungcap = new CNhacungcapCtr();
            box = new TextBox();
            bool test = nhacungcap.KiemTraEmail(" '", box);
            Assert.AreEqual(false, test);
        }
        [TestMethod]

        public void TestEmail_11()
        {
            nhacungcap = new CNhacungcapCtr();
            box = new TextBox();
            bool test = nhacungcap.KiemTraEmail("1", box);
            Assert.AreEqual(false, test);
        }
        [TestMethod]

        public void TestEmail_12()
        {
            nhacungcap = new CNhacungcapCtr();
            box = new TextBox();
            bool test = nhacungcap.KiemTraEmail("0961563317@gmail.com", box);
            Assert.AreEqual(false, test);
        }

        [TestMethod]

        public void TestEmail_13()
        {
            nhacungcap = new CNhacungcapCtr();
            box = new TextBox();
            bool test = nhacungcap.KiemTraEmail("#", box);
            Assert.AreEqual(false, test);
        }

        [TestMethod]

        public void TestEmail_14()
        {
            nhacungcap = new CNhacungcapCtr();
            box = new TextBox();
            bool test = nhacungcap.KiemTraEmail("$", box);
            Assert.AreEqual(false, test);
        }
        [TestMethod]

        public void TestEmail_15()
        {
            nhacungcap = new CNhacungcapCtr();
            box = new TextBox();
            bool test = nhacungcap.KiemTraEmail("%", box);
            Assert.AreEqual(false, test);
        }

        [TestMethod]

        public void TestEmail_16()
        {
            nhacungcap = new CNhacungcapCtr();
            box = new TextBox();
            bool test = nhacungcap.KiemTraEmail("^", box);
            Assert.AreEqual(false, test);
        }

        [TestMethod]

        public void TestEmail_17()
        {
            nhacungcap = new CNhacungcapCtr();
            box = new TextBox();
            bool test = nhacungcap.KiemTraEmail("*", box);
            Assert.AreEqual(false, test);
        }

        [TestMethod]

        public void TestEmail_18()
        {
            nhacungcap = new CNhacungcapCtr();
            box = new TextBox();
            bool test = nhacungcap.KiemTraEmail("(", box);
            Assert.AreEqual(false, test);
        }

        [TestMethod]

        public void TestEmail_19()
        {
            nhacungcap = new CNhacungcapCtr();
            box = new TextBox();
            bool test = nhacungcap.KiemTraEmail(";", box);
            Assert.AreEqual(false, test);
        }

        [TestMethod]

        public void TestEmail_20()
        {
            nhacungcap = new CNhacungcapCtr();
            box = new TextBox();
            bool test = nhacungcap.KiemTraEmail(")", box);
            Assert.AreEqual(false, test);
        }

        [TestMethod]

        public void TestEmail_21()
        {
            nhacungcap = new CNhacungcapCtr();
            box = new TextBox();
            bool test = nhacungcap.KiemTraEmail("\"", box);
            Assert.AreEqual(false, test);
        }

        [TestMethod]

        public void TestEmail_22()
        {
            nhacungcap = new CNhacungcapCtr();
            box = new TextBox();
            bool test = nhacungcap.KiemTraEmail(",", box);
            Assert.AreEqual(false, test);
        }
        [TestMethod]

        public void TestEmail_23()
        {
            nhacungcap = new CNhacungcapCtr();
            box = new TextBox();
            bool test = nhacungcap.KiemTraEmail("nam@ggggggggg.com", box);
            Assert.AreEqual(true, test);
        }

        [TestMethod]

        public void TestEmail_24()
        {
            nhacungcap = new CNhacungcapCtr();
            box = new TextBox();
            bool test = nhacungcap.KiemTraEmail("...", box);
            Assert.AreEqual(false, test);
        }

        [TestMethod]
        
        public void TestGridView_1()
        {
            nhacungcap = new CNhacungcapCtr();
            DataGridView dg = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)(dg)).BeginInit();
            nhacungcap.Hienthidatagridview(dg);
        }

        [TestMethod]
        public void TestKiemTra_0()
        {
            nhacungcap = new CNhacungcapCtr();
            TextBox txtTenNcc = new TextBox();
            TextBox txtDcncc = new TextBox();
            TextBox tdtDt = new TextBox();
            TextBox txtEmailNcc = new TextBox();

            txtTenNcc.Text = "";
            txtDcncc.Text = "";
            tdtDt.Text = "";
            txtEmailNcc.Text = "";
            bool test =nhacungcap.KiemTraLuu(txtTenNcc, txtDcncc, tdtDt, txtEmailNcc);
            Assert.AreEqual(false,test);
        }

        [TestMethod]
        public void TestKiemTra_1()
        {
            nhacungcap = new CNhacungcapCtr();
            TextBox txtTenNcc = new TextBox();
            TextBox txtDcncc = new TextBox();
            TextBox tdtDt = new TextBox();
            TextBox txtEmailNcc = new TextBox();

            txtTenNcc.Text = @"Nam";
            txtDcncc.Text = @"";
            tdtDt.Text = @"";
            txtEmailNcc.Text = @"";
            bool test = nhacungcap.KiemTraLuu(txtTenNcc, txtDcncc, tdtDt, txtEmailNcc);
            Assert.AreEqual(false, test);
        }
        [TestMethod]
        public void TestKiemTra_2()
        {
            nhacungcap = new CNhacungcapCtr();
            TextBox txtTenNcc = new TextBox();
            TextBox txtDcncc = new TextBox();
            TextBox tdtDt = new TextBox();
            TextBox txtEmailNcc = new TextBox();

            txtTenNcc.Text = @"Nam";
            txtDcncc.Text = @"Nam";
            tdtDt.Text = @"";
            txtEmailNcc.Text = @"";
            bool test = nhacungcap.KiemTraLuu(txtTenNcc, txtDcncc, tdtDt, txtEmailNcc);
            Assert.AreEqual(false, test);
        }

        [TestMethod]
        public void TestKiemTra_3()
        {
            nhacungcap = new CNhacungcapCtr();
            TextBox txtTenNcc = new TextBox();
            TextBox txtDcncc = new TextBox();
            TextBox tdtDt = new TextBox();
            TextBox txtEmailNcc = new TextBox();

            txtTenNcc.Text = @"Nam";
            txtDcncc.Text = @"Nam";
            tdtDt.Text = @"096";
            txtEmailNcc.Text = @"";
            bool test = nhacungcap.KiemTraLuu(txtTenNcc, txtDcncc, tdtDt, txtEmailNcc);
            Assert.AreEqual(false, test);
        }

        [TestMethod]
        public void TestKiemTra_4()
        {
            nhacungcap = new CNhacungcapCtr();
            TextBox txtTenNcc = new TextBox();
            TextBox txtDcncc = new TextBox();
            TextBox tdtDt = new TextBox();
            TextBox txtEmailNcc = new TextBox();

            txtTenNcc.Text = @"Nam";
            txtDcncc.Text = @"Nam";
            tdtDt.Text = @"096345678246";
            txtEmailNcc.Text = @"";
            bool test = nhacungcap.KiemTraLuu(txtTenNcc, txtDcncc, tdtDt, txtEmailNcc);
            Assert.AreEqual(false, test);
        }

        [TestMethod]
        public void TestKiemTra_5()
        {
            nhacungcap = new CNhacungcapCtr();
            TextBox txtTenNcc = new TextBox();
            TextBox txtDcncc = new TextBox();
            TextBox tdtDt = new TextBox();
            TextBox txtEmailNcc = new TextBox();

            txtTenNcc.Text = @"Nam";
            txtDcncc.Text = @"Nam";
            tdtDt.Text = @"0961563317";
            txtEmailNcc.Text = @"";
            bool test = nhacungcap.KiemTraLuu(txtTenNcc, txtDcncc, tdtDt, txtEmailNcc);
            Assert.AreEqual(false, test);
        }

        [TestMethod]
        public void TestKiemTra_6()
        {
            nhacungcap = new CNhacungcapCtr();
            TextBox txtTenNcc = new TextBox();
            TextBox txtDcncc = new TextBox();
            TextBox tdtDt = new TextBox();
            TextBox txtEmailNcc = new TextBox();

            txtTenNcc.Text = @"Nam";
            txtDcncc.Text = @"Nam";
            tdtDt.Text = @"0961563317";
            txtEmailNcc.Text = @".";
            bool test = nhacungcap.KiemTraLuu(txtTenNcc, txtDcncc, tdtDt, txtEmailNcc);
            Assert.AreEqual(false, test);
        }
        [TestMethod]
        public void TestKiemTra_7()
        {
            nhacungcap = new CNhacungcapCtr();
            TextBox txtTenNcc = new TextBox();
            TextBox txtDcncc = new TextBox();
            TextBox tdtDt = new TextBox();
            TextBox txtEmailNcc = new TextBox();

            txtTenNcc.Text = @"Nam";
            txtDcncc.Text = @"Nam";
            tdtDt.Text = @"0961563317";
            txtEmailNcc.Text = @"00000000000000";
            bool test = nhacungcap.KiemTraLuu(txtTenNcc, txtDcncc, tdtDt, txtEmailNcc);
            Assert.AreEqual(false, test);
        }
        [TestMethod]
        public void TestKiemTra_8()
        {
            nhacungcap = new CNhacungcapCtr();
            TextBox txtTenNcc = new TextBox();
            TextBox txtDcncc = new TextBox();
            TextBox tdtDt = new TextBox();
            TextBox txtEmailNcc = new TextBox();

            txtTenNcc.Text = @"Nam";
            txtDcncc.Text = @"Nam";
            tdtDt.Text = @"0961563317";
            txtEmailNcc.Text = @"Nam@nam.com";
            bool test = nhacungcap.KiemTraLuu(txtTenNcc, txtDcncc, tdtDt, txtEmailNcc);
            Assert.AreEqual(true, test);
        }
    }
}
