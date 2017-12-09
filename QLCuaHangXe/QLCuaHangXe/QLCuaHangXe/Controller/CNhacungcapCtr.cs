
using System;
using System.Data;

using System.Windows.Forms;
using QLCuaHangXe.DataLayer;


namespace QLCuaHangXe.Controller
{
    public class CNhacungcapCtr
    {
        public void Hienthidatagridviewtheoten(DataGridView dg, string ten)
        {
            BindingSource bs = new BindingSource();
            DataTable tbl = new NhaCungCapData().Timtheoten(ten);
            bs.DataSource = tbl;
            dg.DataSource = bs;
        }

        public void Hienthidatagridviewtheoma(DataGridView dg, string ma)
        {
            BindingSource bs = new BindingSource();
            DataTable tbl = new NhaCungCapData().Timtheoma(ma);
            bs.DataSource = tbl;
            dg.DataSource = bs;
        }

        public void Hienthidatagridview(DataGridView dg)
        {
            BindingSource bs = new BindingSource();
            DataTable tb = new NhaCungCapData().Hienthidatagri();
            bs.DataSource = tb;
            dg.DataSource = bs;
        }

        public bool KiemTraEmail(string email, TextBox txtEmailNcc)
        {
            if (email != "")
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
                                int i = Convert.ToInt32(array[0].Substring(0, 1));
                                MessageBox.Show(@"Nick khong duoc bat dau tu so", @"Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                txtEmailNcc.Focus();
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
                                                txtEmailNcc.Focus();
                                                return false;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show(@"Email thieu dau cham", @"Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        txtEmailNcc.Focus();
                                        return false;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show(@"Phan sau email phai co 5 ky tu", @"Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    txtEmailNcc.Focus();
                                    return false;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show(@"Email chi duoc mot dau @", @"Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtEmailNcc.Focus();
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show(@"Email khong dau @", @"Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtEmailNcc.Focus();
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show(@"Email khong chua nhung ky tu dat biet", @"Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtEmailNcc.Focus();
                    return false;
                }
            }
            return true;
        }

        public bool KiemTraLuu()
        {
            if (txtTenNCC.Text == "")
            {
                MessageBox.Show(@"Khong Duoc Bo Trong Ten NCC", @"Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenNCC.Focus();
                return false;
            }
            else if (txtDCNCC.Text == "")
            {
                MessageBox.Show(@"Khong Duoc Bo Trong Dia Chi NCC", @"Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDCNCC.Focus();
                return false;
            }
            else if (Kiemtradt() == false || txtDTNCC.Text == "")
            {
                MessageBox.Show(@"Số điện thoại ko hợp lệ", @"Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDTNCC.Focus();
                return false;
            }
            else if (txtEmailNCC.Text == "")
            {
                MessageBox.Show(@"Khong Duoc Bo Trong Email", @"Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmailNCC.Focus();
                return false;
            }
            else if (txtDTNCC.Text.Length != 10 && txtDTNCC.Text.Length != 11)
            {
                MessageBox.Show(@"Bạn nhập số DT Không đúng với thực tế", @"Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDTNCC.Focus();
                return false;
            }
            else if (KiemTraEmail(txtEmailNCC.Text, this.txtEmailNCC) == false)
            {
                MessageBox.Show(@"Có lỗi khi nhập Email", @"Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

    }
}
