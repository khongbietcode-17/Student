using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BC = BCrypt.Net.BCrypt;
namespace QLHS
{
    public partial class TaiKhoan : Form
    {
        MyDataTable dataTable = new MyDataTable();
        string maTaiKhoan = "";

        public TaiKhoan()
        {
            InitializeComponent();
            dataTable.OpenConnection();
        }

        private void BatTat(bool giaTri)
        {
            txtMaTaiKhoan.Enabled = giaTri;
            txtHoVaTen.Enabled = giaTri;
            txtGhiChu.Enabled = giaTri;
            txtTenDangNhap.Enabled = giaTri;
            txtMatKhau.Enabled = giaTri;
            cboQuyenHan.Enabled = giaTri;

            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        public void LayDuLieu()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM TaiKhoan");
            dataTable.Fill(cmd);

            BindingSource binding = new BindingSource();
            binding.DataSource = dataTable;

            // Hiển thị dữ liệu vào DataGridView
            dataGridView.DataSource = binding;

            // Liên kết dữ liệu từ DataGridView lên các control
            txtMaTaiKhoan.DataBindings.Clear();
            txtHoVaTen.DataBindings.Clear();
            txtGhiChu.DataBindings.Clear();
            txtTenDangNhap.DataBindings.Clear();
            txtMatKhau.DataBindings.Clear();
            cboQuyenHan.DataBindings.Clear();

            txtMaTaiKhoan.DataBindings.Add("Text", binding, "MaTaiKhoan");
            txtHoVaTen.DataBindings.Add("Text", binding, "HoVaTen");
            txtGhiChu.DataBindings.Add("Text", binding, "GhiChu");
            txtTenDangNhap.DataBindings.Add("Text", binding, "TenDangNhap");
            txtMatKhau.DataBindings.Add("Text", binding, "MatKhau");
            cboQuyenHan.DataBindings.Add("Text", binding, "QuyenHan");
        }

        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            LayDuLieu();
            BatTat(false);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Đánh dấu là Thêm mới
            maTaiKhoan = "";

            // Xóa trắng các trường
            txtMaTaiKhoan.Clear();
            txtHoVaTen.Clear();
            txtGhiChu.Clear();
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            cboQuyenHan.Text = "";
            txtMaTaiKhoan.Focus();

			// Bật/Tắt các controls
			BatTat(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult kq;
            kq = MessageBox.Show("Bạn có muốn xoá tài khoản " + txtHoVaTen.Text + " không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                string sql = @"DELETE FROM TaiKhoan WHERE MaTaiKhoan = @MaTaiKhoan";
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.Add("@MaTaiKhoan", SqlDbType.NVarChar, 4).Value = txtMaTaiKhoan.Text;
                dataTable.Update(cmd);

                // Tải lại form
                TaiKhoan_Load(sender, e);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaTaiKhoan.Text.Trim() == "")
                MessageBox.Show("Mã tài khoản không được rỗng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtHoVaTen.Text.Trim() == "")
                MessageBox.Show("Họ và tên không được rỗng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtTenDangNhap.Text.Trim() == "")
                MessageBox.Show("Tên đăng nhập không được rỗng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtMatKhau.Text.Trim() == "")
                MessageBox.Show("Mật khẩu không được rỗng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (cboQuyenHan.Text.Trim() == "")
                MessageBox.Show("Quyền hạn không được rỗng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    // Thêm mới
                    if (maTaiKhoan == "")
                    {
                        string sql = @"INSERT INTO TaiKhoan
                                       VALUES(@MaTaiKhoan, @HoVaTen, @TenDangNhap, @MatKhau, @QuyenHan, @GhiChu)";
                        SqlCommand cmd = new SqlCommand(sql);
                        cmd.Parameters.Add("@MaTaiKhoan", SqlDbType.NVarChar, 4).Value = txtMaTaiKhoan.Text;
                        cmd.Parameters.Add("@HoVaTen", SqlDbType.NVarChar, 50).Value = txtHoVaTen.Text;
                        cmd.Parameters.Add("@TenDangNhap", SqlDbType.NVarChar, 20).Value = txtTenDangNhap.Text;
                        cmd.Parameters.Add("@MatKhau", SqlDbType.NVarChar, 100).Value = BC.HashPassword(txtMatKhau.Text);
                        cmd.Parameters.Add("@QuyenHan", SqlDbType.NVarChar, 10).Value = cboQuyenHan.Text;
                        cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar).Value = txtGhiChu.Text;
                        dataTable.Update(cmd);
                    }
                    else // Sửa
                    {
                        string sql = @"UPDATE	TaiKhoan
									   SET		MaTaiKhoan = @MaTaiKhoanMoi,
												HoVaTen = @HoVaTen,
												TenDangNhap = @TenDangNhap,
												MatKhau = @MatKhau,
												QuyenHan = @QuyenHan,
												GhiChu = @GhiChu
									   WHERE	MaTaiKhoan = @MaTaiKhoanCu";
                        SqlCommand cmd = new SqlCommand(sql);
                        cmd.Parameters.Add("@MaTaiKhoanMoi", SqlDbType.NVarChar, 4).Value = txtMaTaiKhoan.Text;
                        cmd.Parameters.Add("@MaTaiKhoanCu", SqlDbType.NVarChar, 4).Value = maTaiKhoan;
                        cmd.Parameters.Add("@HoVaTen", SqlDbType.NVarChar, 50).Value = txtHoVaTen.Text;
                        cmd.Parameters.Add("@TenDangNhap", SqlDbType.NVarChar, 20).Value = txtTenDangNhap.Text;
                        cmd.Parameters.Add("@MatKhau", SqlDbType.NVarChar, 100).Value = BC.HashPassword(txtMatKhau.Text);
                        cmd.Parameters.Add("@QuyenHan", SqlDbType.NVarChar, 10).Value = cboQuyenHan.Text;
                        cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar).Value = txtGhiChu.Text;
                        dataTable.Update(cmd);
                    }

                    // Tải lại form
                    TaiKhoan_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Đánh dấu là Cập nhật
            maTaiKhoan = txtMaTaiKhoan.Text;

            // Bật/Tắt các controls
            BatTat(true);
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            // Tải lại form
            TaiKhoan_Load(sender, e);
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == "MatKhau")
            {
                e.Value = "*****";
            }
        }
    }
}