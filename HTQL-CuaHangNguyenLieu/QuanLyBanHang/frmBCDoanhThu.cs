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
    public partial class frmBCDoanhThu : Form
    {
        DataTable tblBCDoanhThu;
        public frmBCDoanhThu()
        {
            InitializeComponent();
        }

        private void frmBCDoanhThu_Load(object sender, EventArgs e)
        {
            btnTaoBC.Enabled = true;
            LoadDataGridView();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtNam.Text == "" || txtThang.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đầy đủ tháng năm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            LoadDataGridView();
        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "select MaHDBan, NgayBan, TongTien from tblHDBan WHERE 1=1";
            if (txtThang.Text != "")
                sql = sql + " AND MONTH(NgayBan) =" + txtThang.Text;
            if (txtNam.Text != "")
                sql = sql + " AND YEAR(NgayBan) =" + txtNam.Text;

            tblBCDoanhThu = Functions.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            dgvBCHangTon.DataSource = tblBCDoanhThu;
            dgvBCHangTon.Columns[0].HeaderText = "Mã hóa đơn";
            dgvBCHangTon.Columns[1].HeaderText = "Ngày bán";
            dgvBCHangTon.Columns[2].HeaderText = "Tiền hàng";

            dgvBCHangTon.Columns[0].Width = 140;
            dgvBCHangTon.Columns[1].Width = 140;
            dgvBCHangTon.Columns[2].Width = 140;

            dgvBCHangTon.AllowUserToAddRows = false;
            dgvBCHangTon.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnTaoBC_Click(object sender, EventArgs e)
        {
            if (txtNam.Text == "" || txtThang.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đầy đủ tháng năm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // Khởi động chương trình Excel
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable tblBCDT;
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
            exRange.Range["C2:E2"].Value = "BÁO CÁO DOANH THU THÁNG " + txtThang.Text +"-" + txtNam.Text;

            sql = "select MaHDBan, NgayBan, TongTien from tblHDBan WHERE 1=1"
            + " AND MONTH(NgayBan) =" + txtThang.Text
            + " AND YEAR(NgayBan) =" + txtNam.Text;
            
            //Tạo dòng tiêu đề bảng
            exRange.Range["A5:F5"].Font.Bold = true;
            exRange.Range["A5:F5"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C5:F5"].ColumnWidth = 16;
            exRange.Range["B5:B5"].ColumnWidth = 20;
            exRange.Range["C5:C5"].ColumnWidth = 20;
            exRange.Range["A5:A5"].Value = "STT";
            exRange.Range["B5:B5"].Value = "Mã hóa đơn";
            exRange.Range["C5:C5"].Value = "Ngày bán";
            exRange.Range["D5:D5"].Value = "Tổng tiền";

            for (hang = 0; hang < tblBCDoanhThu.Rows.Count; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 6
                exSheet.Cells[1][hang + 6] = hang + 1;
                for (cot = 0; cot < tblBCDoanhThu.Columns.Count; cot++)
                //Điền thông tin hàng từ cột thứ 2, dòng 6
                {
                    exSheet.Cells[cot + 2][hang + 6] = tblBCDoanhThu.Rows[hang][cot].ToString();
                    if (cot == 3) exSheet.Cells[cot + 2][hang + 6] = tblBCDoanhThu.Rows[hang][cot].ToString();
                }
            }
            exRange = exSheet.Cells[cot][hang + 7];
            exRange.Range["B1:C1"].MergeCells = true;
            exRange.Range["B1:C1"].Font.Italic = true;
            exRange.Range["B1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            DateTime d = DateTime.Now;
            exRange.Range["B1:C1"].Value = "Hà Nội, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
            exRange.Range["B2:C2"].MergeCells = true;
            exRange.Range["B2:C2"].Font.Italic = true;
            exRange.Range["B2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["B2:C2"].Value = "Người lập báo cáo";
            exSheet.Name = "Báo cáo doanh thu tháng" + txtThang.Text + "-" + txtNam.Text;
            exApp.Visible = true;
        }
    }
}
