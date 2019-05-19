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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        CSDL kn = new CSDL();
        private void label1_Click(object sender, EventArgs e)
        {

        }
        public static string mand = "";
        private void btndangnhap_Click(object sender, EventArgs e)
        {
            if(txttendn.Text!="" && txtmk.Text!="")
            {
                string s = "select MaND from Dangnhap where TenDN='"+txttendn.Text.Trim()+"' and MatKhau='"+txtmk.Text.Trim()+"'";
                DataTable dt = kn.GetData(s);
                if (dt.Rows.Count>0)
                {
                    mand = dt.Rows[0][0].ToString();
                    Form_main frm = new Form_main();
                    frm.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Đăng nhập thất bại", "Thông báo");
            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            txttendn.Focus();
        }
    }
}
