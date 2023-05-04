using QuanLyBanHang.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class frmDMNhaCungCap : Form
    {
        DataTable tblCL;
        public frmDMNhaCungCap()
        {
            InitializeComponent();
        }
        private void frmDMChatLieu_Load(object sender, EventArgs e)
        {
            txtMaNhaCungCap.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            LoadDataGridView();
        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT MaNhaCungCap, TenNhaCungCap FROM tblNhaCungCap";
            tblCL = Functions.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            dgvChatLieu.DataSource = tblCL; //Nguồn dữ liệu            
            dgvChatLieu.Columns[0].HeaderText = "Mã nhà cung cấp";
            dgvChatLieu.Columns[1].HeaderText = "Tên nhà cung cấp";
            dgvChatLieu.Columns[0].Width = 100;
            dgvChatLieu.Columns[1].Width = 300;
            dgvChatLieu.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgvChatLieu.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }
        private void dgvChatLieu_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNhaCungCap.Focus();
                return;
            }
            if (tblCL.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaNhaCungCap.Text = dgvChatLieu.CurrentRow.Cells["MaNhaCungCap"].Value.ToString();
            txtTenNhaCungCap.Text = dgvChatLieu.CurrentRow.Cells["TenNhaCungCap"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoQua.Enabled = true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValue(); //Xoá trắng các textbox
            txtMaNhaCungCap.Enabled = true; //cho phép nhập mới
            txtMaNhaCungCap.Focus();
        }
        private void ResetValue()
        {
            txtMaNhaCungCap.Text = "";
            txtTenNhaCungCap.Text = "";
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql; //Lưu lệnh sql
            if (txtMaNhaCungCap.Text.Trim().Length == 0) //Nếu chưa nhập mã chất liệu
            {
                MessageBox.Show("Bạn phải nhập mã chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNhaCungCap.Focus();
                return;
            }
            if (txtTenNhaCungCap.Text.Trim().Length == 0) //Nếu chưa nhập tên chất liệu
            {
                MessageBox.Show("Bạn phải nhập tên chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenNhaCungCap.Focus();
                return;
            }
            sql = "Select MaNhaCungCap From tblNhaCungCap where MaNhaCungCap=N'" + txtMaNhaCungCap.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã chất liệu này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNhaCungCap.Focus();
                return;
            }

            sql = "INSERT INTO tblNhaCungCap VALUES(N'" +
                txtMaNhaCungCap.Text + "',N'" + txtTenNhaCungCap.Text + "')";
            Functions.RunSQL(sql); //Thực hiện câu lệnh sql
            LoadDataGridView(); //Nạp lại DataGridView
            ResetValue();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaNhaCungCap.Enabled = false;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql; //Lưu câu lệnh sql
            if (tblCL.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaNhaCungCap.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenNhaCungCap.Text.Trim().Length == 0) //nếu chưa nhập tên chất liệu
            {
                MessageBox.Show("Bạn chưa nhập tên chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "UPDATE tblNhaCungCap SET TenNhaCungCap=N'" +
                txtTenNhaCungCap.Text.ToString() +
                "' WHERE MaNhaCungCap=N'" + txtMaNhaCungCap.Text + "'";
            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValue();
            btnBoQua.Enabled = false;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblCL.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaNhaCungCap.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblNhaCungCap WHERE MaNhaCungCap=N'" + txtMaNhaCungCap.Text + "'";
                Functions.RunSQL(sql);
                LoadDataGridView();
                ResetValue();
            }
        }
        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValue();
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaNhaCungCap.Enabled = false;
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtMaNhaCungCap_KeyUp(object sender, KeyEventArgs e)
        {
                if (e.KeyCode == Keys.Enter)
                    SendKeys.Send("{TAB}"); 
        }
    }
}
