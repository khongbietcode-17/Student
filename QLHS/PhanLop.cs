using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLHS
{
    public partial class PhanLop : Form
    {
        MyDataTable dataTable = new MyDataTable();
		string maHocSinh = "";
		string maLop = "";

		public PhanLop()
        {
            InitializeComponent();
            dataTable.OpenConnection();
        }

		private void BatTat(bool giaTri)
		{
			cboHocSinh.Enabled = giaTri;
			cboLop.Enabled = giaTri;
			cboNamHoc.Enabled = giaTri;

			btnLuu.Enabled = giaTri;
			btnHuyBo.Enabled = giaTri;

			btnThem.Enabled = !giaTri;
			btnSua.Enabled = !giaTri;
			btnXoa.Enabled = !giaTri;
		}

		public void LayDuLieu()
        {
			// Lấy dữ liệu vào cboHocSinh
			MyDataTable hocSinh = new MyDataTable();
			hocSinh.OpenConnection();
			string sqlHocSinh = "SELECT * FROM HocSinh";
			SqlCommand commandHocSinh = new SqlCommand(sqlHocSinh);
			hocSinh.Fill(commandHocSinh);
			cboHocSinh.DataSource = hocSinh;
			cboHocSinh.DisplayMember = "HoVaTen";
			cboHocSinh.ValueMember = "MaHocSinh";

			// Lấy dữ liệu vào cboLop
			MyDataTable lopHoc = new MyDataTable();
			lopHoc.OpenConnection();
			string sqlLopHoc = "SELECT * FROM LopHoc";
			SqlCommand commandLopHoc = new SqlCommand(sqlLopHoc);
			lopHoc.Fill(commandLopHoc);
			cboLop.DataSource = lopHoc;
			cboLop.DisplayMember = "TenLop";
			cboLop.ValueMember = "MaLop";

			// Lấy dữ liệu vào DataGridView
			SqlCommand cmd = new SqlCommand(@"SELECT P.*, H.HoVaTen, L.TenLop 
											  FROM PhanLop P, HocSinh H, LopHoc L
											  WHERE P.MaHocSinh = H.MaHocSinh AND P.MaLop = L.MaLop");
            dataTable.Fill(cmd);
            BindingSource binding = new BindingSource();
            binding.DataSource = dataTable;
            dataGridView.DataSource = binding;

            // Liên kết dữ liệu từ DataGridView lên các control
            cboHocSinh.DataBindings.Clear();
            cboLop.DataBindings.Clear();
            cboNamHoc.DataBindings.Clear();
            cboHocSinh.DataBindings.Add("SelectedValue", binding, "MaHocSinh");
            cboLop.DataBindings.Add("SelectedValue", binding, "MaLop");
            cboNamHoc.DataBindings.Add("Text", binding, "NamHoc");
        }

        private void PhanLop_Load(object sender, EventArgs e)
        {
			dataGridView.AutoGenerateColumns = false;

            LayDuLieu();
			BatTat(false);
		}

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}