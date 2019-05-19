using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phiguihang
{
    public partial class Danhsachbuugui : Form
    {
        CSDL kn = new CSDL();
        public Danhsachbuugui()
        {
            InitializeComponent();
        }
        public static string mand, mabg;

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (dsbuugui.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Bạn chưa chọn bưu gửi cần xóa", "Thông báo");
            }
            else
            {
                if(MessageBox.Show("Bạn có muốn xóa không?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                    try
                    {
                        kn.Execute("delete from Danhsachbuugui where Mabg='"+mabg+"'");
                        LoadDSBuuGui();
                        MessageBox.Show("Xóa thành công", "Thông báo");
                    }
                    catch
                    {
                        MessageBox.Show("Xóa thất bại", "Thông báo");
                    }
                
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            foreach (ListViewItem item in dsbuugui.SelectedItems)
            {

                mabg = item.SubItems[1].Text;
                mand = item.SubItems[2].Text;
               
            }
        }

        private void Danhsachbuugui_Load(object sender, EventArgs e)
        {
            LoadDSBuuGui();
        }
        public static ListView dsach = new ListView();
        public void LoadDSBuuGui()
        {
            dsbuugui.Items.Clear();
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
                it.SubItems.Add(String.Format("{0:dd/MM/yyyy}",dt.Rows[i][9]));
                it.SubItems.Add(dt.Rows[i][10].ToString());
                it.SubItems.Add(String.Format("{0:#,##0}", float.Parse(dt.Rows[i][15].ToString())));
                it.SubItems.Add(String.Format("{0:#,##0}",float.Parse(dt.Rows[i][16].ToString())));
                dsbuugui.Items.Add(it);
                dsach = dsbuugui;
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnxuat_Click(object sender, EventArgs e)
        {
            string filePath = "";
            // tạo SaveFileDialog để lưu file excel
            SaveFileDialog dialog = new SaveFileDialog();

            // chỉ lọc ra các file có định dạng Excel
            dialog.Filter = "Excel | *.xlsx | Excel 2003 | *.xls";

            // Nếu mở file và chọn nơi lưu file thành công sẽ lưu đường dẫn lại dùng
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filePath = dialog.FileName;
            }

            // nếu đường dẫn null hoặc rỗng thì báo không hợp lệ và return hàm
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Đường dẫn báo cáo không hợp lệ");
                return;
            }

            try
            {
                using (ExcelPackage p = new ExcelPackage())
                {
                    // đặt tên người tạo file
                    p.Workbook.Properties.Author = "Oanh";

                    // đặt tiêu đề cho file
                    p.Workbook.Properties.Title = "DANH SÁCH BƯU GỬI";

                    //Tạo một sheet để làm việc trên đó
                    p.Workbook.Worksheets.Add("Danh sach sheet");

                    // lấy sheet vừa add ra để thao tác
                    ExcelWorksheet ws = p.Workbook.Worksheets[1];

                    // đặt tên cho sheet
                    ws.Name = "DSBG sheet";
                    // fontsize mặc định cho cả sheet
                    ws.Cells.Style.Font.Size = 11;
                    // font family mặc định cho cả sheet
                    ws.Cells.Style.Font.Name = "Calibri";

                    // Tạo danh sách các column header
                    string[] arrColumnHeader = {
                                                "Mã bưu gửi",
                                                "Mã người dùng",
                                                "Dịch vụ",
                                                "Tên người gửi",
                                                "Địa chỉ người gửi",
                                                "Số điện thoại người gửi",
                                                "Tên người nhận",
                                                "Địa chỉ người nhận",
                                                "Số điện thoại người nhận",
                                                "Ngày nhận gửi",
                                                "Khối lượng",
                                                "Cước chính",
                                                "Phụ phí xăng dầu",
                                                "Phát hành thu tiền",
                                                "Số tiền thu hộ",
                                                "Tổng cước",
                                                "Tổng tiền"

                };

                    // lấy ra số lượng cột cần dùng dựa vào số lượng header
                    var countColHeader = arrColumnHeader.Count();

                    // merge các column lại từ column 1 đến số column header
                    // gán giá trị cho cell vừa merge là Danh sách bưu gửi
                    ws.Cells[1, 1].Value = "DANH SÁCH BƯU GỬI";
                    ws.Cells[1, 1, 1, countColHeader].Merge = true;
                    // in đậm
                    ws.Cells[1, 1, 1, countColHeader].Style.Font.Bold = true;
                    // căn giữa
                    ws.Cells[1, 1, 1, countColHeader].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                    int colIndex = 1;
                    int rowIndex = 2;

                    //tạo các header từ column header đã tạo từ bên trên
                    foreach (var item in arrColumnHeader)
                    {
                        var cell = ws.Cells[rowIndex, colIndex];

                        //set màu thành gray
                        var fill = cell.Style.Fill;
                        fill.PatternType = ExcelFillStyle.Solid;
                        fill.BackgroundColor.SetColor(System.Drawing.Color.LightBlue);

                        //căn chỉnh các border
                        var border = cell.Style.Border;
                        border.Bottom.Style =
                            border.Top.Style =
                            border.Left.Style =
                            border.Right.Style = ExcelBorderStyle.Thin;

                        //gán giá trị
                        cell.Value = item;

                        colIndex++;
                    }

                    // lấy ra danh sách UserInfo từ ItemSource của DataGrid
                    DataTable dt = kn.GetData("select * from Danhsachbuugui");

                    // với mỗi item trong danh sách sẽ ghi trên 1 dòng
                    foreach (DataRow item in dt.Rows)
                    {
                        // bắt đầu ghi từ cột 1. Excel bắt đầu từ 1 không phải từ 0
                        colIndex = 1;

                        // rowIndex tương ứng từng dòng dữ liệu
                        rowIndex++;

                        //gán giá trị cho từng cell                      
                        ws.Cells[rowIndex, colIndex++].Value = item["Mabg"];
                        ws.Cells[rowIndex, colIndex++].Value = item["MaND"];
                        ws.Cells[rowIndex, colIndex++].Value = item["Dichvu"];
                        ws.Cells[rowIndex, colIndex++].Value = item["Tennguoigui"];
                        ws.Cells[rowIndex, colIndex++].Value = item["Diaching"];
                        ws.Cells[rowIndex, colIndex++].Value = item["sdtgui"];
                        ws.Cells[rowIndex, colIndex++].Value = item["Tennn"];
                        ws.Cells[rowIndex, colIndex++].Value = item["Diachinn"];
                        ws.Cells[rowIndex, colIndex++].Value = item["sdtnn"];
                        ws.Cells[rowIndex, colIndex++].Value = String.Format("{0:dd/MM/yyyy}", item["Ngaynhangui"]);
                        ws.Cells[rowIndex, colIndex++].Value = item["Khoiluong"];
                        ws.Cells[rowIndex, colIndex++].Value = item["Cuocchinh"];
                        ws.Cells[rowIndex, colIndex++].Value = item["Phuphixangdau"];
                        ws.Cells[rowIndex, colIndex++].Value = item["Phathanhthutien"];
                        ws.Cells[rowIndex, colIndex++].Value = item["Sotienthuho"];
                        ws.Cells[rowIndex, colIndex++].Value = item["Tongcuoc"];
                        ws.Cells[rowIndex, colIndex++].Value = item["Tongtien"];

                    }

                    //Lưu file lại
                    Byte[] bin = p.GetAsByteArray();
                    File.WriteAllBytes(filePath, bin);
                }
                MessageBox.Show("Xuất excel thành công!");
            }
            catch (Exception EE)
            {
                MessageBox.Show("Có lỗi khi lưu file!");
            }

        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            if (dsbuugui.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Bạn chưa chọn bưu gửi cần sửa", "Thông báo");
            }
            else
            {
                capnhat frm = new capnhat();
                frm.ShowDialog();
                
            }
        }
    }
}
