namespace QLHS
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQueQuan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLopHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHocSinh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPhanLop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaoCaoThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDanhSachHocSinh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHuongDan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongTin = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblTrangThai = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.btnDangNhap = new System.Windows.Forms.ToolStripButton();
            this.btnDangXuat = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnQueQuan = new System.Windows.Forms.ToolStripButton();
            this.btnLopHoc = new System.Windows.Forms.ToolStripButton();
            this.btnHocSinh = new System.Windows.Forms.ToolStripButton();
            this.btnPhanLop = new System.Windows.Forms.ToolStripButton();
            this.btnTaiKhoan = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnThoat = new System.Windows.Forms.ToolStripButton();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHeThong,
            this.mnuQuanLy,
            this.mnuBaoCaoThongKe,
            this.mnuTroGiup});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip.Size = new System.Drawing.Size(719, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // mnuHeThong
            // 
            this.mnuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDangNhap,
            this.mnuDangXuat,
            this.mnuThoat});
            this.mnuHeThong.Name = "mnuHeThong";
            this.mnuHeThong.Size = new System.Drawing.Size(69, 22);
            this.mnuHeThong.Text = "&Hệ thống";
            // 
            // mnuDangNhap
            // 
            this.mnuDangNhap.Image = global::QLHS.Properties.Resources.login16;
            this.mnuDangNhap.Name = "mnuDangNhap";
            this.mnuDangNhap.Size = new System.Drawing.Size(146, 22);
            this.mnuDangNhap.Text = "Đăng &nhập...";
            this.mnuDangNhap.Click += new System.EventHandler(this.mnuDangNhap_Click);
            // 
            // mnuDangXuat
            // 
            this.mnuDangXuat.Image = global::QLHS.Properties.Resources.logout16;
            this.mnuDangXuat.Name = "mnuDangXuat";
            this.mnuDangXuat.Size = new System.Drawing.Size(146, 22);
            this.mnuDangXuat.Text = "Đăng &xuất";
            this.mnuDangXuat.Click += new System.EventHandler(this.mnuDangXuat_Click);
            // 
            // mnuThoat
            // 
            this.mnuThoat.Image = global::QLHS.Properties.Resources.exit16;
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuThoat.Size = new System.Drawing.Size(146, 22);
            this.mnuThoat.Text = "&Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // mnuQuanLy
            // 
            this.mnuQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQueQuan,
            this.mnuLopHoc,
            this.mnuHocSinh,
            this.mnuPhanLop,
            this.mnuTaiKhoan});
            this.mnuQuanLy.Name = "mnuQuanLy";
            this.mnuQuanLy.Size = new System.Drawing.Size(60, 22);
            this.mnuQuanLy.Text = "&Quản lý";
            // 
            // mnuQueQuan
            // 
            this.mnuQueQuan.Image = global::QLHS.Properties.Resources.earth16;
            this.mnuQueQuan.Name = "mnuQueQuan";
            this.mnuQueQuan.Size = new System.Drawing.Size(135, 22);
            this.mnuQueQuan.Text = "Q&uê quán...";
            this.mnuQueQuan.Click += new System.EventHandler(this.mnuQueQuan_Click);
            // 
            // mnuLopHoc
            // 
            this.mnuLopHoc.Image = global::QLHS.Properties.Resources.block32;
            this.mnuLopHoc.Name = "mnuLopHoc";
            this.mnuLopHoc.Size = new System.Drawing.Size(135, 22);
            this.mnuLopHoc.Text = "&Lớp học...";
            this.mnuLopHoc.Click += new System.EventHandler(this.mnuLopHoc_Click);
            // 
            // mnuHocSinh
            // 
            this.mnuHocSinh.Image = global::QLHS.Properties.Resources.users32;
            this.mnuHocSinh.Name = "mnuHocSinh";
            this.mnuHocSinh.Size = new System.Drawing.Size(135, 22);
            this.mnuHocSinh.Text = "&Học sinh...";
            this.mnuHocSinh.Click += new System.EventHandler(this.mnuHocSinh_Click);
            // 
            // mnuPhanLop
            // 
            this.mnuPhanLop.Image = global::QLHS.Properties.Resources.blocks32;
            this.mnuPhanLop.Name = "mnuPhanLop";
            this.mnuPhanLop.Size = new System.Drawing.Size(135, 22);
            this.mnuPhanLop.Text = "&Phân lớp...";
            this.mnuPhanLop.Click += new System.EventHandler(this.mnuPhanLop_Click);
            // 
            // mnuTaiKhoan
            // 
            this.mnuTaiKhoan.Image = global::QLHS.Properties.Resources.user32_2;
            this.mnuTaiKhoan.Name = "mnuTaiKhoan";
            this.mnuTaiKhoan.Size = new System.Drawing.Size(135, 22);
            this.mnuTaiKhoan.Text = "&Tài khoản...";
            this.mnuTaiKhoan.Click += new System.EventHandler(this.mnuTaiKhoan_Click);
            // 
            // mnuBaoCaoThongKe
            // 
            this.mnuBaoCaoThongKe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDanhSachHocSinh});
            this.mnuBaoCaoThongKe.Name = "mnuBaoCaoThongKe";
            this.mnuBaoCaoThongKe.Size = new System.Drawing.Size(121, 22);
            this.mnuBaoCaoThongKe.Text = "&Báo cáo - Thống kê";
            // 
            // mnuDanhSachHocSinh
            // 
            this.mnuDanhSachHocSinh.Image = global::QLHS.Properties.Resources.chart32;
            this.mnuDanhSachHocSinh.Name = "mnuDanhSachHocSinh";
            this.mnuDanhSachHocSinh.Size = new System.Drawing.Size(186, 22);
            this.mnuDanhSachHocSinh.Text = "&Danh sách học sinh...";
            this.mnuDanhSachHocSinh.Click += new System.EventHandler(this.mnuDanhSachHocSinh_Click);
            // 
            // mnuTroGiup
            // 
            this.mnuTroGiup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHuongDan,
            this.mnuThongTin});
            this.mnuTroGiup.Name = "mnuTroGiup";
            this.mnuTroGiup.Size = new System.Drawing.Size(62, 22);
            this.mnuTroGiup.Text = "&Trợ giúp";
            // 
            // mnuHuongDan
            // 
            this.mnuHuongDan.Image = global::QLHS.Properties.Resources.help16;
            this.mnuHuongDan.Name = "mnuHuongDan";
            this.mnuHuongDan.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.mnuHuongDan.Size = new System.Drawing.Size(241, 22);
            this.mnuHuongDan.Text = "&Hướng dẫn sử dụng";
            this.mnuHuongDan.Click += new System.EventHandler(this.mnuHuongDan_Click);
            // 
            // mnuThongTin
            // 
            this.mnuThongTin.Image = global::QLHS.Properties.Resources.star32;
            this.mnuThongTin.Name = "mnuThongTin";
            this.mnuThongTin.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F2)));
            this.mnuThongTin.Size = new System.Drawing.Size(241, 22);
            this.mnuThongTin.Text = "Thông tin &phần mềm...";
            this.mnuThongTin.Click += new System.EventHandler(this.mnuThongTin_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTrangThai,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip.Location = new System.Drawing.Point(0, 332);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(719, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(146, 17);
            this.lblTrangThai.Text = "Thiết kế bởi Nguyễn Tùng.";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(413, 17);
            this.toolStripStatusLabel2.Spring = true;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.IsLink = true;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(145, 17);
            this.toolStripStatusLabel3.Text = "https://www.nhtung.id.vn";
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDangNhap,
            this.btnDangXuat,
            this.toolStripSeparator1,
            this.btnQueQuan,
            this.btnLopHoc,
            this.btnHocSinh,
            this.btnPhanLop,
            this.btnTaiKhoan,
            this.toolStripSeparator2,
            this.btnThoat});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip.Size = new System.Drawing.Size(719, 31);
            this.toolStrip.TabIndex = 3;
            this.toolStrip.Text = "toolStrip1";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Image = global::QLHS.Properties.Resources.login16;
            this.btnDangNhap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(93, 28);
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Image = global::QLHS.Properties.Resources.logout16;
            this.btnDangXuat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(89, 28);
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // btnQueQuan
            // 
            this.btnQueQuan.Image = global::QLHS.Properties.Resources.earth16;
            this.btnQueQuan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQueQuan.Name = "btnQueQuan";
            this.btnQueQuan.Size = new System.Drawing.Size(87, 28);
            this.btnQueQuan.Text = "Quê quán";
            this.btnQueQuan.Click += new System.EventHandler(this.btnQueQuan_Click);
            // 
            // btnLopHoc
            // 
            this.btnLopHoc.Image = global::QLHS.Properties.Resources.block32;
            this.btnLopHoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLopHoc.Name = "btnLopHoc";
            this.btnLopHoc.Size = new System.Drawing.Size(78, 28);
            this.btnLopHoc.Text = "Lớp học";
            this.btnLopHoc.Click += new System.EventHandler(this.btnLopHoc_Click);
            // 
            // btnHocSinh
            // 
            this.btnHocSinh.Image = global::QLHS.Properties.Resources.users32;
            this.btnHocSinh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHocSinh.Name = "btnHocSinh";
            this.btnHocSinh.Size = new System.Drawing.Size(82, 28);
            this.btnHocSinh.Text = "Học sinh";
            this.btnHocSinh.Click += new System.EventHandler(this.btnHocSinh_Click);
            // 
            // btnPhanLop
            // 
            this.btnPhanLop.Image = global::QLHS.Properties.Resources.blocks32;
            this.btnPhanLop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPhanLop.Name = "btnPhanLop";
            this.btnPhanLop.Size = new System.Drawing.Size(82, 28);
            this.btnPhanLop.Text = "Phân lớp";
            this.btnPhanLop.Click += new System.EventHandler(this.btnPhanLop_Click);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.Image = global::QLHS.Properties.Resources.user32_2;
            this.btnTaiKhoan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(85, 28);
            this.btnTaiKhoan.Text = "Tài khoản";
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::QLHS.Properties.Resources.exit16;
            this.btnThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(65, 28);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 354);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý học sinh";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThong;
        private System.Windows.Forms.ToolStripMenuItem mnuDangNhap;
        private System.Windows.Forms.ToolStripMenuItem mnuDangXuat;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLy;
        private System.Windows.Forms.ToolStripMenuItem mnuQueQuan;
        private System.Windows.Forms.ToolStripMenuItem mnuLopHoc;
        private System.Windows.Forms.ToolStripMenuItem mnuHocSinh;
        private System.Windows.Forms.ToolStripMenuItem mnuPhanLop;
        private System.Windows.Forms.ToolStripMenuItem mnuBaoCaoThongKe;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhSachHocSinh;
        private System.Windows.Forms.ToolStripMenuItem mnuTroGiup;
        private System.Windows.Forms.ToolStripMenuItem mnuHuongDan;
        private System.Windows.Forms.ToolStripMenuItem mnuThongTin;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblTrangThai;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton btnDangNhap;
        private System.Windows.Forms.ToolStripButton btnDangXuat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnQueQuan;
        private System.Windows.Forms.ToolStripButton btnLopHoc;
        private System.Windows.Forms.ToolStripButton btnHocSinh;
        private System.Windows.Forms.ToolStripButton btnPhanLop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnThoat;
        private System.Windows.Forms.ToolStripMenuItem mnuTaiKhoan;
        private System.Windows.Forms.ToolStripButton btnTaiKhoan;
    }
}