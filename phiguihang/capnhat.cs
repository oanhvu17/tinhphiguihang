using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phiguihang
{
    public partial class capnhat : Form
    {
        public capnhat()
        {
            InitializeComponent();
        }

        private void capnhat_Load(object sender, EventArgs e)
        {
            txtsohieubg.Text = Danhsachbuugui.mabg;
            txtmangdung.Text = Danhsachbuugui.mand;
            DataTable dt = kn.GetData("select * from Danhsachbuugui where Mabg='"+txtsohieubg.Text+"'");
            cmdichvu.Text = dt.Rows[0]["Dichvu"].ToString();
            txthotenng.Text= dt.Rows[0]["Tennguoigui"].ToString();
            txtdiaching.Text= dt.Rows[0]["Diaching"].ToString();
            txthotennn.Text= dt.Rows[0]["Tennn"].ToString();
            mtbsdtng.Text= dt.Rows[0]["sdtgui"].ToString();
            mtbsdtnn.Text= dt.Rows[0]["sdtnn"].ToString();
            dateTimePicker1.Text= String.Format("{0:dd/MM/yyyy}", dt.Rows[0]["Ngaynhangui"].ToString());
            txttien.Text= dt.Rows[0]["Sotienthuho"].ToString();
            txttrongluong.Text= dt.Rows[0]["Khoiluong"].ToString();
            string []s = dt.Rows[0]["Diachinn"].ToString().Split('-');
            txttinh.Text = s[2];
            cmbhuyen.Text = s[1];
            txtsonha.Text = s[0];

        }
        CSDL kn = new CSDL();
        private void btncapnhat_Click(object sender, EventArgs e)
        {
            if (cmdichvu.Text!="" && txthotenng.Text != "" && txtdiaching.Text != "" && txthotennn.Text != "" && txtsonha.Text != "" && txttrongluong.Text != "" && mtbsdtnn.Text!="" && mtbsdtng.Text!="")
                try
                {
                    SqlConnection con = new SqlConnection(kn.chuoiketnoi);
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "CapNhatBuuGui";
                    cmd.Parameters.Add("@mabg", SqlDbType.VarChar, 50).Value = txtsohieubg.Text;
                    cmd.Parameters.Add("@mand", SqlDbType.VarChar, 50).Value = txtmangdung.Text;
                    cmd.Parameters.Add("@dichvu", SqlDbType.NVarChar, 100).Value = cmdichvu.Text;
                    cmd.Parameters.Add("@tenng", SqlDbType.NVarChar, 50).Value = txthotenng.Text;
                    cmd.Parameters.Add("@dcng", SqlDbType.NVarChar, 100).Value = txtdiaching.Text;
                    cmd.Parameters.Add("@sdtgui", SqlDbType.VarChar, 10).Value = mtbsdtng.Text;
                    cmd.Parameters.Add("@tennh", SqlDbType.NVarChar, 50).Value = txthotennn.Text;
                    cmd.Parameters.Add("@dcnn", SqlDbType.NVarChar, 100).Value = txtsonha.Text + " - " + cmbhuyen.Text + " - " + txttinh.Text;
                    cmd.Parameters.Add("@sdtnn", SqlDbType.VarChar, 10).Value = mtbsdtnn.Text;
                    cmd.Parameters.Add("@ngay", SqlDbType.Date).Value = dateTimePicker1.Text;
                    cmd.Parameters.Add("@khoiluong", SqlDbType.Float).Value = float.Parse(txttrongluong.Text);
                    cmd.Parameters.Add("@cuocchinh", SqlDbType.Float).Value = float.Parse(txtcuocchinh.Text);
                    cmd.Parameters.Add("@phuphi", SqlDbType.Float).Value = float.Parse(txtxang.Text);
                    cmd.Parameters.Add("@phathanhtt", SqlDbType.Float).Value = float.Parse(txtphtt.Text);
                    cmd.Parameters.Add("@tienthuho", SqlDbType.Float).Value = float.Parse(txttien.Text);
                    cmd.Parameters.Add("@tongcuoc", SqlDbType.Float).Value = float.Parse(txttongcuoc.Text);
                    cmd.Parameters.Add("@tongtien", SqlDbType.Float).Value = float.Parse(txttongcong.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    LoadDSBuuGui();
                    MessageBox.Show("Cập nhật thành công", "Thông báo");
                }
                catch
                {
                    MessageBox.Show("Cập nhật thất bại", "Thông báo");
                }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
        }
        public void LoadDSBuuGui()
        {
            Danhsachbuugui.dsach.Items.Clear();
            DataTable dt = kn.GetData("select * from Danhsachbuugui");
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
                Danhsachbuugui.dsach.Items.Add(it);
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txttrongluong_TextChanged(object sender, EventArgs e)
        {
            float phuphixangdau = 3000, phathanhthanhtien = 5000;
            float cuocchinh = 0;
            float trongluong, tienthuho;
            if (float.TryParse(txttrongluong.Text, out trongluong) && float.TryParse(txttien.Text, out tienthuho))
            {

                if (trongluong > 0 && trongluong <= 300)
                    cuocchinh = 13000;
                else if (trongluong > 300 && trongluong <= 600)
                    cuocchinh = 15000;
                else if (trongluong > 600 && trongluong <= 900)
                    cuocchinh = 17000;
                else if (trongluong > 900 && trongluong <= 1500)
                    cuocchinh = 19000;
                else if (trongluong > 1500)
                    cuocchinh = 22000;
                float tongcuoc = cuocchinh + phuphixangdau + phathanhthanhtien;
                float tongtien = tienthuho + tongcuoc;
                txtphtt.Text = phathanhthanhtien.ToString();
                txtxang.Text = phuphixangdau.ToString();
                txttongcuoc.Text = String.Format("{0:#,##0}", tongcuoc);
                txttongcong.Text = String.Format("{0:#,##0}", tongtien);
                txttienthuho.Text = String.Format("{0:#,##0}", float.Parse(txttien.Text));
                txtcuocchinh.Text = String.Format("{0:#,##0}", cuocchinh);
                txtcuocthuho.Text = String.Format("{0:#,##0}", tongcuoc);
            }
            else
                MessageBox.Show("Số tiền thu hộ và Trọng lượng phải là số", "Thông báo");
        }
    }
}
