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
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doimatkhau frm = new doimatkhau();
            frm.MdiParent = this;
            frm.Show();
        }

        private void danhSáchBưuGửiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Danhsachbuugui frm = new Danhsachbuugui();
            frm.MdiParent = this;
            frm.Show();
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.MdiParent = this;
            frm.Show();
        }

        private void traCứuThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tracuubuugui frm = new tracuubuugui();
            frm.MdiParent = this;
            frm.Show();
        }

        private void đổiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
