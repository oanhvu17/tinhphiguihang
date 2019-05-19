using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phiguihang
{
    public partial class doimatkhau : Form
    {
        public doimatkhau()
        {
            InitializeComponent();
        }
        CSDL kn = new CSDL();
        private void btndoimk_Click(object sender, EventArgs e)
        {
            if (txtmkcu.Text != "" && txtmkmoi.Text != "" && txtnhaplaimk.Text != "")
            {
                DataTable dt = kn.GetData("select * from Dangnhap where MaND='"+DangNhap.mand+"' and MatKhau='"+txtmkcu.Text.Trim()+"'");
                if(dt.Rows.Count>0)
                {
                    if (txtmkmoi.Text.Trim() == txtnhaplaimk.Text.Trim())
                        try
                        {
                            kn.Execute("update Dangnhap set MatKhau='"+txtmkmoi.Text.Trim()+"' where MaND='"+DangNhap.mand+"'");
                            MessageBox.Show("Đổi mật khẩu thành công", "Thông báo");
                        }
                        catch
                        {
                            MessageBox.Show("Đổi mật khẩu thất bại", "Thông báo");
                        }
                    else
                    {
                        MessageBox.Show("Mật khẩu nhập lại không khớp", "Thông báo");
                        txtnhaplaimk.Text = "";
                        txtnhaplaimk.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu cũ không đúng", "Thông báo");
                    txtmkcu.SelectAll();
                    txtmkcu.Focus();
                }
            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
        }
    }
}
