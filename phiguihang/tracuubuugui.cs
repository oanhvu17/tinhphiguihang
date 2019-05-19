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
    public partial class tracuubuugui : Form
    {
        CSDL kn = new CSDL();
        public tracuubuugui()
        {
            InitializeComponent();
        }

        private void btnthoattracuu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tracuubuugui_Load(object sender, EventArgs e)
        {
            loadMaBG();

        }
        public void loadMaBG()
        {
            DataTable dt = kn.GetData("select * from Danhsachbuugui");
            cmbmabg.DataSource = dt;
            cmbmabg.DisplayMember = "Mabg";
            cmbmabg.ValueMember = "Mabg";
           
        }

        private void cmbmabg_SelectedIndexChanged(object sender, EventArgs e)
        {
            dsbuugui.Items.Clear();
            DataTable dt = kn.GetData("select * from Danhsachbuugui where Mabg='"+cmbmabg.Text.Trim()+"'");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem it = new ListViewItem((i + 1).ToString());
                it.SubItems.Add(dt.Rows[i][0].ToString());
                it.SubItems.Add(dt.Rows[i][1].ToString());
                it.SubItems.Add(dt.Rows[i][3].ToString());
                it.SubItems.Add(dt.Rows[i][4].ToString());
                it.SubItems.Add(dt.Rows[i][6].ToString());
                it.SubItems.Add(dt.Rows[i][7].ToString());
                it.SubItems.Add(dt.Rows[i][9].ToString());
                it.SubItems.Add(dt.Rows[i][10].ToString());
                it.SubItems.Add(String.Format("{0:#,##0}", float.Parse(dt.Rows[i][15].ToString())));
                it.SubItems.Add(String.Format("{0:#,##0}", float.Parse(dt.Rows[i][16].ToString())));
                dsbuugui.Items.Add(it);
            }
        }
    }
}
