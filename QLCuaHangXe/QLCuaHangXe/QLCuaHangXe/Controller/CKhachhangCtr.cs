
using System;
using System.Data;

using System.Windows.Forms;
using QLCuaHangXe.DataLayer;


namespace QLCuaHangXe.Controller
{
    public class CKhachhangCtr
    {
        public bool Hienthikhachhang(DataGridView dg)
        {
            try
            {
                BindingSource bs = new BindingSource();
                DataTable tb = new CKhachhangdata().Hienthikh();
                bs.DataSource = tb;
                dg.DataSource = bs;
               
                return true;
            }
            catch (ArgumentOutOfRangeException)
            {
                return false;
            }

        }

        public bool Hienthidatagridviewtheoten(DataGridView dg, string ten)
        {
            try
            {
                BindingSource bs = new BindingSource();
                DataTable tbl = new CKhachhangdata().Timtheoten(ten);
                bs.DataSource = tbl;
                dg.DataSource = bs;
                return true;
            }
            catch (ArgumentException)
            {
                return false;
            }

        }

        public bool Hienthidatagridviewtheoma(DataGridView dg, string ma)
        {
            try
            {
                BindingSource bs = new BindingSource();
                DataTable tbl = new CKhachhangdata().Timtheoma(ma);
                bs.DataSource = tbl;
                dg.DataSource = bs;
                return true;
            }
            catch (ArgumentException)
            {
                return false;
            }
            
        }

        
        public bool KiemTraEmail(String email)
        {
            if (email == "")
            {
                //MessageBox.Show(@"Bạn chưa nhập email");
                return false;
            }
            else if (email != "")
            {
                if ((!email.Contains("~") && (!email.Contains("%") && (!email.Contains("|") && (!email.Contains(" ") && (!email.Contains("^") && (!email.Contains(":") && (!email.Contains("'") && (!email.Contains("&") && (!email.Contains(";") && (!email.Contains("!") && (!email.Contains("*") && (!email.Contains("\"")) && (!email.Contains("#")) && (!email.Contains("(")) && (!email.Contains("'")) && (!email.Contains("<")) && (!email.Contains(",")) && (!email.Contains(">")) && (!email.Contains("/")) && (!email.Contains("\\")) && (!email.Contains("+")) && (!email.Contains("-")) && (!email.Contains("$")) && (!email.Contains(")")) && (!email.Contains("?"))))))))))))))
                {
                    string[] array = email.Split('@');//tach email boi dau @
                    if (array.Length > 1)
                    {
                        if (array.Length == 2)
                        {
                            try
                            {
                                int phone = Convert.ToInt32(array[0].Substring(0, 1));
                                
                                MessageBox.Show(@"Nick khong duoc bat dau tu so", @"Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                
                                //txtemail.Focus();
                                return false;
                            }
                            catch
                            {
                                //Kiem tra sau dau @
                                if (array[1].Length >= 5)
                                {
                                    if (array[1].Split('.').Length >= 2)
                                    {
                                        string[] subArrray = array[1].Split('.');
                                        foreach (string s in subArrray)
                                        {
                                            if (s.Length < 2)
                                            {
                                                MessageBox.Show(@"Email không hợp lệ", @"Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                
                                                //txtemail.Focus();
                                                return false;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show(@"Email thieu dau cham", @"Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        
                                        //txtemail.Focus();
                                        return false;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show(@"Phan sau email phai co 5 ky tu", @"Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    
                                    //txtemail.Focus();
                                    return false;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show(@"Email chi duoc mot dau @", @"Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            
                            //txtemail.Focus();
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show(@"Email khong dau @", @"Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        
                        //txtemail.Focus();
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show(@"Email khong chua nhung ky tu dat biet", @"Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                    //txtemail.Focus();
                    return false;
                }
            }
            return true;
        }

        public bool KiemTra(TextBox txttenkh, TextBox txtdc,TextBox txtdt,TextBox txtemail)
        {
            if (txttenkh.Text == "")
            {
                MessageBox.Show(@"Khong Duoc Bo Trong Ten Khach", @"Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txttenkh.Focus();
                return false;
            }
            if (txtdc.Text == "")
            {
                MessageBox.Show(@"Khong Duoc Bo Trong Dia Chi Khach", @"Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdc.Focus();
                return false;
            }
            if ( txtdt.Text == "")
            {
                MessageBox.Show(@"Số điện thoại ko hợp lệ", @"Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdt.Focus();
                return false;
            }
            if (!Kiemtradt(txtdt))
            {
                MessageBox.Show(@"Bạn Chưa nhập số điện thoại", @"Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdt.Focus();
                return false;
            }

            if (txtemail.Text == "")
            {
                MessageBox.Show(@"Khong Duoc Bo Trong Email", @"Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtemail.Focus();
                return false;
            }
            if (txtdt.Text.Length != 10 && txtdt.Text.Length != 11)
            {
                MessageBox.Show(@"Bạn nhập số DT Không đúng với thực tế", @"Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtdt.Focus();
                return false;
            }
            if (KiemTraEmail(txtemail.Text,txtemail) == false)
            {
                MessageBox.Show(@"Có lỗi khi nhập Email", @"Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        public bool KiemTraEmail(String email, TextBox txtEmail)
        {
            txtEmail.Focus();
            return new CKhachhangCtr().KiemTraEmail(email);

        }

        public bool Kiemtradt(TextBox txtdt)
        {
            
            if (Convert.ToInt32(txtdt.Text.Substring(0, 1)) != 0 || txtdt.Text.Length != 10 && txtdt.Text.Length != 11)
                return false;
            return true;
        }

    }
}
