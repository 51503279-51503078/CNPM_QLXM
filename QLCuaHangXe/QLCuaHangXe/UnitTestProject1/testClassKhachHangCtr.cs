

using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLCuaHangXe.Controller;

namespace UnitTestProject1
{
    [TestClass]
    public class TestClassKhachHangCtr
    {
        private CKhachhangCtr _khachhangCtr;
       
        


        [TestMethod]
        public void TestKiemTraEmail_1()
        {
            _khachhangCtr = new CKhachhangCtr();
            
            bool test = _khachhangCtr.KiemTraEmail("1234");
            Assert.AreEqual(false, test);

        }
        [TestMethod]
        public void TestKiemTraEmail_2()
        {
            _khachhangCtr = new CKhachhangCtr();
            
            bool test = _khachhangCtr.KiemTraEmail("1234@");
            Assert.AreEqual(false, test);

        }
        [TestMethod]
        public void TestKiemTraEmail_3()
        {
            _khachhangCtr = new CKhachhangCtr();
            
            bool test = _khachhangCtr.KiemTraEmail("1234@dot");
            Assert.AreEqual(false, test);

        }
        [TestMethod]
        public void TestKiemTraEmail_4()
        {
            _khachhangCtr = new CKhachhangCtr();
            
            bool test = _khachhangCtr.KiemTraEmail("1234@@dot");
            Assert.AreEqual(false, test);

        }
        [TestMethod]
        public void TestKiemTraEmail_5()
        {
            _khachhangCtr = new CKhachhangCtr();
            
            bool test = _khachhangCtr.KiemTraEmail("1234@@dot.com");
            Assert.AreEqual(false, test);

        }
        [TestMethod]
        public void TestKiemTraEmail_6()
        {
            _khachhangCtr = new CKhachhangCtr();

            bool test = _khachhangCtr.KiemTraEmail("0961563317nam@gmail.com");
            Assert.AreEqual(false, test);

        }

        [TestMethod]
        public void TestKiemTraEmail_7()
        {
            _khachhangCtr = new CKhachhangCtr();

            bool test = _khachhangCtr.KiemTraEmail("");
            Assert.AreEqual(false, test);

        }
        [TestMethod]
        public void TestKiemTraEmail_8()
        {
            _khachhangCtr = new CKhachhangCtr();

            bool test = _khachhangCtr.KiemTraEmail(".");
            Assert.AreEqual(false, test);

        }
        [TestMethod]
        public void TestKiemTraEmail_9()
        {
            _khachhangCtr = new CKhachhangCtr();

            bool test = _khachhangCtr.KiemTraEmail("a(");
            Assert.AreEqual(false, test);

        }
        [TestMethod]
        public void TestKiemTraEmail_10()
        {
            _khachhangCtr = new CKhachhangCtr();

            bool test = _khachhangCtr.KiemTraEmail("a)");
            Assert.AreEqual(false, test);

        }
        [TestMethod]
        public void TestKiemTraEmail_11()
        {
            _khachhangCtr = new CKhachhangCtr();

            bool test = _khachhangCtr.KiemTraEmail("a~");
            Assert.AreEqual(false, test);

        }
        [TestMethod]
        public void TestKiemTraEmail_12()
        {
            _khachhangCtr = new CKhachhangCtr();

            bool test = _khachhangCtr.KiemTraEmail("a#");
            Assert.AreEqual(false, test);

        }
        [TestMethod]
        public void TestKiemTraEmail_13()
        {
            _khachhangCtr = new CKhachhangCtr();

            bool test = _khachhangCtr.KiemTraEmail("maichan@gmail.com");
            Assert.AreEqual(true, test);

        }
        [TestMethod]
        public void TestKiemTraEmail_14()
        {
            _khachhangCtr = new CKhachhangCtr();

            bool test = _khachhangCtr.KiemTraEmail("$");
            Assert.AreEqual(false, test);

        }
        [TestMethod]
        public void TestKiemTraEmail_15()
        {
            _khachhangCtr = new CKhachhangCtr();

            bool test = _khachhangCtr.KiemTraEmail("|");
            Assert.AreEqual(false, test);

        }
        [TestMethod]
        public void TestKiemTraEmail_16()
        {
            _khachhangCtr = new CKhachhangCtr();

            bool test = _khachhangCtr.KiemTraEmail("%");
            Assert.AreEqual(false, test);

        }
        [TestMethod]
        public void TestKiemTraEmail_17()
        {
            _khachhangCtr = new CKhachhangCtr();

            bool test = _khachhangCtr.KiemTraEmail("^");
            Assert.AreEqual(false, test);

        }
        [TestMethod]
        public void TestKiemTraEmail_18()
        {
            _khachhangCtr = new CKhachhangCtr();

            bool test = _khachhangCtr.KiemTraEmail(":");
            Assert.AreEqual(false, test);

        }
        [TestMethod]
        public void TestKiemTraEmail_19()
        {
            _khachhangCtr = new CKhachhangCtr();

            bool test = _khachhangCtr.KiemTraEmail(";");
            Assert.AreEqual(false, test);

        }
        [TestMethod]
        public void TestKiemTraEmail_21()
        {
            _khachhangCtr = new CKhachhangCtr();

            bool test = _khachhangCtr.KiemTraEmail("\"");
            Assert.AreEqual(false, test);

        }
        [TestMethod]
        public void TestKiemTraEmail_22()
        {
            _khachhangCtr = new CKhachhangCtr();

            bool test = _khachhangCtr.KiemTraEmail("'");
            Assert.AreEqual(false, test);

        }
        [TestMethod]
        public void TestKiemTraEmail_23()
        {
            _khachhangCtr = new CKhachhangCtr();

            bool test = _khachhangCtr.KiemTraEmail("!");
            Assert.AreEqual(false, test);

        }
        [TestMethod]
        public void TestKiemTraEmail_24()
        {
            _khachhangCtr = new CKhachhangCtr();

            bool test = _khachhangCtr.KiemTraEmail(" ");
            Assert.AreEqual(false, test);

        }
        [TestMethod]
        public void TestKiemTraEmail_25()
        {
            _khachhangCtr = new CKhachhangCtr();

            bool test = _khachhangCtr.KiemTraEmail("+");
            Assert.AreEqual(false, test);

        }
        //------------------------- End test kiem tra email ----------------------------------
        [TestMethod]
        public void TestKiemTraSDT_1()
        {
            _khachhangCtr = new CKhachhangCtr();
            TextBox phone = new TextBox();
            phone.Text = @"0123";
            bool testcase = _khachhangCtr.Kiemtradt(phone);
            Assert.AreEqual(false,testcase);
        }
        [TestMethod]
        public void TestKiemTraSDT_2()
        {
            _khachhangCtr = new CKhachhangCtr();
            TextBox phone = new TextBox();
            phone.Text = @"01111111111111111111111111111111111111111";
            bool testcase = _khachhangCtr.Kiemtradt(phone);
            Assert.AreEqual(false, testcase);
        }
        [TestMethod]
        public void TestKiemTraInfo_1()
        {
            _khachhangCtr = new CKhachhangCtr();
            TextBox phone = new TextBox();
            phone.Text = @"0961563317";
            bool testcase = _khachhangCtr.Kiemtradt(phone);
            Assert.AreEqual(true, testcase);
        }
        [TestMethod]
        public void TestKiemTraInfo_2()
        {
            _khachhangCtr = new CKhachhangCtr();
            TextBox phone = new TextBox();
            TextBox name = new TextBox();
            TextBox address = new TextBox();
            TextBox email = new TextBox();
            phone.Text = @"0961563317";
            name.Text = @"";
            address.Text = @"";
            email.Text = @"Ruby@gmail.com";
            bool testcase = _khachhangCtr.KiemTra(name, address, phone,email);
            Assert.AreEqual(false, testcase);
        }

        [TestMethod]
        public void TestKiemTraInfo_3()
        {
            _khachhangCtr = new CKhachhangCtr();
            TextBox phone = new TextBox();
            TextBox name = new TextBox();
            TextBox address = new TextBox();
            TextBox email = new TextBox();
            phone.Text = @"0961563317";
            name.Text = @"Nam";
            address.Text = @"";
            email.Text = @"Ruby@gmail.com";
            bool testcase = _khachhangCtr.KiemTra(name, address, phone, email);
            Assert.AreEqual(false, testcase);
        }
        [TestMethod]
        public void TestKiemTraInfo_4()
        {
            _khachhangCtr = new CKhachhangCtr();
            TextBox phone = new TextBox();
            TextBox name = new TextBox();
            TextBox address = new TextBox();
            TextBox email = new TextBox();
            phone.Text = @"0961563317";
            name.Text = @"";
            address.Text = @"Nam";
            email.Text = @"Ruby@gmail.com";
            bool testcase = _khachhangCtr.KiemTra(name, address, phone, email);
            Assert.AreEqual(false, testcase);
        }
        [TestMethod]
        public void TestKiemTraInfo_5()
        {
            _khachhangCtr = new CKhachhangCtr();
            TextBox phone = new TextBox();
            TextBox name = new TextBox();
            TextBox address = new TextBox();
            TextBox email = new TextBox();
            phone.Text = @"";
            name.Text = @"DaiNam";
            address.Text = @"HoChiMInh";
            email.Text = @"Ruby@gmail.com";
            bool testcase = _khachhangCtr.KiemTra(name, address, phone, email);
            Assert.AreEqual(false, testcase);
        }
        [TestMethod]
        public void TestKiemTraInfo_6()
        {
            _khachhangCtr = new CKhachhangCtr();
            TextBox phone = new TextBox();
            TextBox name = new TextBox();
            TextBox address = new TextBox();
            TextBox email = new TextBox();
            phone.Text = @"";
            name.Text = @"DaiNam";
            address.Text = @"HoChiMInh";
            email.Text = @"";
            bool testcase = _khachhangCtr.KiemTra(name, address, phone, email);
            Assert.AreEqual(false, testcase);
        }
        [TestMethod]
        public void TestKiemTraInfo_7()
        {
            _khachhangCtr = new CKhachhangCtr();
            TextBox phone = new TextBox();
            TextBox name = new TextBox();
            TextBox address = new TextBox();
            TextBox email = new TextBox();
            phone.Text = @"0961563317";
            name.Text = @"DaiNam";
            address.Text = @"HoChiMInh";
            email.Text = @"";
            bool testcase = _khachhangCtr.KiemTra(name, address, phone, email);
            Assert.AreEqual(false, testcase);
        }
        [TestMethod]
        public void TestKiemTraInfo_8()
        {
            _khachhangCtr = new CKhachhangCtr();
            TextBox phone = new TextBox();
            TextBox name = new TextBox();
            TextBox address = new TextBox();
            TextBox email = new TextBox();
            phone.Text = @"";
            name.Text = @"";
            address.Text = @"";
            email.Text = @"";
            bool testcase = _khachhangCtr.KiemTra(name, address, phone, email);
            Assert.AreEqual(false, testcase);
        }
        [TestMethod]
        public void TestKiemTraInfo_9()
        {
            _khachhangCtr = new CKhachhangCtr();
            TextBox phone = new TextBox();
            TextBox name = new TextBox();
            TextBox address = new TextBox();
            TextBox email = new TextBox();
            phone.Text = @"1111111111";
            name.Text = @"DaiNam";
            address.Text = @"HoChiMInh";
            email.Text = @"Ruby@gmail.com";
            bool testcase = _khachhangCtr.KiemTra(name, address, phone, email);
            Assert.AreEqual(false, testcase);
        }
        [TestMethod]
        public void TestKiemTraInfo_10()
        {
            _khachhangCtr = new CKhachhangCtr();
            TextBox phone = new TextBox();
            TextBox name = new TextBox();
            TextBox address = new TextBox();
            TextBox email = new TextBox();
            phone.Text = @"0961563317";
            name.Text = @"DaiNam";
            address.Text = @"HoChiMInh";
            email.Text = @"Ruby@gmail.com";
            bool testcase = _khachhangCtr.KiemTra(name, address, phone, email);
            Assert.AreEqual(true, testcase);
        }
        public void TestKiemTraInfo_11()
        {
            _khachhangCtr = new CKhachhangCtr();
            TextBox phone = new TextBox();
            TextBox name = new TextBox();
            TextBox address = new TextBox();
            TextBox email = new TextBox();
            phone.Text = @"0111111111111111";
            name.Text = @"DaiNam";
            address.Text = @"HoChiMInh";
            email.Text = @"Ruby@gmail.com";
            bool testcase = _khachhangCtr.KiemTra(name, address, phone, email);
            Assert.AreEqual(false, testcase);
        }

    }
}
