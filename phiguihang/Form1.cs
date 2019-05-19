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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        CSDL kn = new CSDL();
        private void Form1_Load(object sender, EventArgs e)
        {
            txtsohieubg.Text = maTuTang();
            txtmangdung.Text = DangNhap.mand;
           
        }
        private string maTuTang()
        {
            string sql = "SELECT Mabg FROM Danhsachbuugui";
            // Lấy DataTable từ câu truy vấn truyền vào (Apdapter Fill DataTable)
            DataTable tb = kn.GetData(sql);
            int[] arrCode = new int[tb.Rows.Count];
            int code;
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                code = int.Parse(tb.Rows[i]["Mabg"].ToString().Remove(0, 2));
                arrCode[i] = code;
            }
            code = arrCode.Max() + 1;
            return "BK00" + code;
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            string mabg = maTuTang();
            if(cmbhuyen.Text!="" && cmbdichvu.Text!="" && txthotenng.Text!="" && txtdiaching.Text!="" && txthotennn.Text != "" && txtsonha.Text != "" && txttrongluong.Text!="" && txttien.Text!="" && mtbsdtng.Text!="" && mtbsdtnn.Text!="")
               try
                {
                    
                    SqlConnection con = new SqlConnection(kn.chuoiketnoi);
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "ThemBuuGui";
                    cmd.Parameters.Add("@mabg", SqlDbType.VarChar, 50).Value = mabg;
                    cmd.Parameters.Add("@mand", SqlDbType.VarChar, 50).Value = txtmangdung.Text;
                    cmd.Parameters.Add("@dichvu", SqlDbType.NVarChar, 100).Value = cmbdichvu.Text;
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
                    MessageBox.Show("Thêm thành công", "Thông báo");
                }
                catch
                {
                   MessageBox.Show("Thêm thất bại", "Thông báo");
                }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
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
            if(float.TryParse(txttrongluong.Text, out trongluong) && float.TryParse(txttien.Text, out tienthuho))
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
                txttienthuho.Text= String.Format("{0:#,##0}", float.Parse(txttien.Text));
                txtcuocchinh.Text= String.Format("{0:#,##0}", cuocchinh);
                txtcuocthuho.Text= String.Format("{0:#,##0}", tongcuoc);
            }
            else
                MessageBox.Show("Số tiền thu hộ và Trọng lượng phải là số", "Thông báo");
        }
    }
}
