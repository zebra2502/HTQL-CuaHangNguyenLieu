using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyBanHang.Class;
using COMExcel = Microsoft.Office.Interop.Excel;

namespace QuanLyBanHang
{
    public partial class frmBCHangTon : Form
    {
        DataTable tblBCHangTon;
        public frmBCHangTon()
        {
            InitializeComponent();
        }

        private void frmBCHangTon_Load(object sender, EventArgs e)
        {
            btnTaoBC.Enabled = true;
            LoadDataGridView();
        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "select MaHang, tenhang, soluong, dongianhap, DonGianhap*SoLuong AS ThanhTien from tblHang";
            tblBCHangTon = Functions.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            dgvBCHangTon.DataSource = tblBCHangTon;
            dgvBCHangTon.Columns[0].HeaderText = "Mã hàng";
            dgvBCHangTon.Columns[1].HeaderText = "Tên hàng";
            dgvBCHangTon.Columns[2].HeaderText = "Số lượng";
            dgvBCHangTon.Columns[3].HeaderText = "Đơn giá nhập";
            dgvBCHangTon.Columns[4].HeaderText = "Thành tiền";

            dgvBCHangTon.Columns[0].Width = 80;
            dgvBCHangTon.Columns[1].Width = 140;
            dgvBCHangTon.Columns[2].Width = 70;
            dgvBCHangTon.Columns[3].Width = 90;
            dgvBCHangTon.Columns[4].Width = 90;

            dgvBCHangTon.AllowUserToAddRows = false;
            dgvBCHangTon.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTaoBC_Click(object sender, EventArgs e)
        {
            // Khởi động chương trình Excel
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable tblBCHT;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            // Định dạng chung
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:Z300"].Font.Name = "Times new roman"; //Font chữ
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "Shop Phan Anh";
            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "Bạch Mai - Hà Nội";
            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: 0989 250202";
            exRange.Range["C2:E2"].Font.Size = 16;
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "BÁO CÁO HÀNG TỒN";
            //Lấy thông tin các mặt hàng
            sql = "select MaHang, tenhang, soluong, DonGiaNhap, DonGianhap*SoLuong AS ThanhTien from tblHang";
            //Tạo dòng tiêu đề bảng
            exRange.Range["A5:F5"].Font.Bold = true;
            exRange.Range["A5:F5"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C5:F5"].ColumnWidth = 10;
            exRange.Range["B5:B5"].ColumnWidth = 12;
            exRange.Range["C5:C5"].ColumnWidth = 20;
            exRange.Range["A5:A5"].Value = "STT";
            exRange.Range["B5:B5"].Value = "Mã hàng";
            exRange.Range["C5:C5"].Value = "Tên hàng";
            exRange.Range["D5:D5"].Value = "Số lượng";
            exRange.Range["E5:E5"].Value = "Đơn giá nhập";
            exRange.Range["F5:F5"].Value = "Thành tiền";
            for (hang = 0; hang < tblBCHangTon.Rows.Count; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 6
                exSheet.Cells[1][hang + 6] = hang + 1;
                for (cot = 0; cot < tblBCHangTon.Columns.Count; cot++)
                //Điền thông tin hàng từ cột thứ 2, dòng 6
                {
                    exSheet.Cells[cot + 2][hang + 6] = tblBCHangTon.Rows[hang][cot].ToString();
                    if (cot == 3) exSheet.Cells[cot + 2][hang + 6] = tblBCHangTon.Rows[hang][cot].ToString();
                }
            }
            exRange = exSheet.Cells[cot-1][hang + 7];
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            DateTime d = DateTime.Now;
            exRange.Range["A1:C1"].Value = "Hà Nội, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].Font.Italic = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:C2"].Value = "Người lập báo cáo";
            exSheet.Name = "Báo cáo hàng tồn";
            exApp.Visible = true;
        }
    }
}
