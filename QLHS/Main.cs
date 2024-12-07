using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BC = BCrypt.Net.BCrypt;
namespace QLHS
{
    public partial class Main : Form
    {
       
        public Main()
        {
            Flash flash = new Flash();
            flash.ShowDialog();

            InitializeComponent();
        }

        #region Biến toàn cục
        QueQuan queQuan = null;
        LopHoc lopHoc = null;
        HocSinh hocSinh = null;
        PhanLop phanLop = null;
        TaiKhoan taiKhoan = null;
        DangNhap dangNhap = null;
        string hovaten = "";
        #endregion

        #region Hệ thống
        private void mnuDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            foreach (Form child in MdiChildren)
            {
                child.Close();
            }
            ChuaDangNhap();
            DangNhap dangNhap=null;
          
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Quản lý
        private void mnuQueQuan_Click(object sender, EventArgs e)
        {
            if (queQuan == null || queQuan.IsDisposed)
            {
                queQuan = new QueQuan();
                queQuan.MdiParent = this;
                queQuan.Show();
            }
            else
                queQuan.Activate();
        }

        private void mnuLopHoc_Click(object sender, EventArgs e)
        {
            if (lopHoc == null || lopHoc.IsDisposed)
            {
                lopHoc = new LopHoc();
                lopHoc.MdiParent = this;
                lopHoc.Show();
            }
            else
                lopHoc.Activate();
        }

        private void mnuHocSinh_Click(object sender, EventArgs e)
        {
            if (hocSinh == null || hocSinh.IsDisposed)
            {
                hocSinh = new HocSinh();
                hocSinh.MdiParent = this;
                hocSinh.Show();
            }
            else
                hocSinh.Activate();
        }

        private void mnuPhanLop_Click(object sender, EventArgs e)
        {
            if (phanLop == null || phanLop.IsDisposed)
            {
                phanLop = new PhanLop();
                phanLop.MdiParent = this;
                phanLop.Show();
            }
            else
                phanLop.Activate();
        }

        private void mnuTaiKhoan_Click(object sender, EventArgs e)
        {
            if (taiKhoan == null || taiKhoan.IsDisposed)
            {
                taiKhoan = new TaiKhoan();
                taiKhoan.MdiParent = this;
                taiKhoan.Show();
            }
            else
                taiKhoan.Activate();
        }
        #endregion

        #region Báo cáo - Thống kê
        private void mnuDanhSachHocSinh_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Trợ giúp
        private void mnuHuongDan_Click(object sender, EventArgs e)
        {

        }

        private void mnuThongTin_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }
        #endregion

        #region Toolbar
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            mnuDangNhap_Click(sender, e);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            mnuDangXuat_Click(sender, e);
        }

        private void btnQueQuan_Click(object sender, EventArgs e)
        {
            mnuQueQuan_Click(sender, e);
        }

        private void btnLopHoc_Click(object sender, EventArgs e)
        {
            mnuLopHoc_Click(sender, e);
        }

        private void btnHocSinh_Click(object sender, EventArgs e)
        {
            mnuHocSinh_Click(sender, e);
        }

        private void btnPhanLop_Click(object sender, EventArgs e)
        {
            mnuPhanLop_Click(sender, e);
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            mnuTaiKhoan_Click(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            mnuThoat_Click(sender, e);
        }
        #endregion

        #region Đăng nhập
        public void ChuaDangNhap()
        {
            btnDangNhap.Enabled = true;
            btnDangXuat.Enabled = false;
            btnQueQuan.Enabled = false;
            btnLopHoc.Enabled = false;
            btnHocSinh.Enabled = false;
            btnPhanLop.Enabled = false;
            btnTaiKhoan.Enabled = false;
            mnuDangXuat.Enabled = false;
            mnuQueQuan.Enabled = false;
            mnuLopHoc.Enabled = false;
            mnuHocSinh.Enabled = false;
            mnuPhanLop.Enabled = false;
            mnuTaiKhoan.Enabled = false;
            mnuDanhSachHocSinh.Enabled = false;
            lblTrangThai.Text = "Chưa đăng nhập";
        }
        public void QuanTriVien()
        {
            btnDangNhap.Enabled = false;
            btnDangXuat.Enabled = true;
            btnQueQuan.Enabled = false;
            btnLopHoc.Enabled = false;
            btnHocSinh.Enabled = false;
            btnPhanLop.Enabled = false;
            btnTaiKhoan.Enabled = true; // Hiện Tài khoản
            mnuDangXuat.Enabled = true;
            mnuQueQuan.Enabled = false;
            mnuLopHoc.Enabled = false;
            mnuHocSinh.Enabled = false;
            mnuPhanLop.Enabled = false;
            mnuTaiKhoan.Enabled = true; // Hiện Tài khoản
            mnuDanhSachHocSinh.Enabled = false;
            lblTrangThai.Text = "Quản trị viên: " + hovaten;
        }
        public void NhanVien()
        {
            btnDangNhap.Enabled = false;
            btnDangXuat.Enabled = true;
            btnQueQuan.Enabled = true;
            btnLopHoc.Enabled = true;
            btnHocSinh.Enabled = true;
            btnPhanLop.Enabled = true;
            btnTaiKhoan.Enabled = false; // Ẩn Tài khoản
            mnuDangXuat.Enabled = true;
            mnuQueQuan.Enabled = true;
            mnuLopHoc.Enabled = true;
            mnuHocSinh.Enabled = true;
            mnuPhanLop.Enabled = true;
            mnuTaiKhoan.Enabled = false; // Ẩn Tài khoản
            mnuDanhSachHocSinh.Enabled = true;
            lblTrangThai.Text = "Nhân viên: " + hovaten;
        }
        public void DangNhap()
        {
          lamlai:
                if(dangNhap==null||dangNhap.IsDisposed)
            {
                dangNhap = new DangNhap();
            }
            if (dangNhap.ShowDialog() == DialogResult.OK)
            {
                if (dangNhap.txtTenDangNhap.Text.Trim() == "")
                {
                    MessageBox.Show("Tên đăng nhập không được bỏ trống!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dangNhap.txtTenDangNhap.Focus();
                    goto lamlai;
                }
                else if (dangNhap.txtMatKhau.Text.Trim() == "")
                {
                    MessageBox.Show("Mật khẩu không được bỏ trống!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dangNhap.txtTenDangNhap.Focus();
                    goto lamlai;
                }
                else
                {
                    MyDataTable dataTable = new MyDataTable();
                    dataTable.OpenConnection();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM TaiKhoan WHERE TenDangNhap = @TDN");
                    cmd.Parameters.Add("@TDN", SqlDbType.NVarChar, 20).Value = dangNhap.txtTenDangNhap.Text;
                    dataTable.Fill(cmd);
                    if(dataTable.Rows.Count > 0 )
                    {
                        if (BC.Verify(dangNhap.txtMatKhau.Text, dataTable.Rows[0]["MatKhau"].ToString()))
                        {
                            hovaten = dataTable.Rows[0]["HoVaTen"].ToString();
                            string quyenhan = dataTable.Rows[0]["QuyenHan"].ToString();
                            if (quyenhan == "admin")
                            {
                                QuanTriVien();
                            }
                            else if (quyenhan == "user")
                                NhanVien();
                            else
                                ChuaDangNhap();
                        }
                        else
                        {
                            MessageBox.Show(" mật khẩu không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dangNhap.txtTenDangNhap.Focus();
                            goto lamlai;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dangNhap.txtTenDangNhap.Focus();
                        goto lamlai;
                    }


                }
            }

        }
        #endregion

        private void Main_Load(object sender, EventArgs e)
        {
            ChuaDangNhap();
            DangNhap();
        }
    }
}