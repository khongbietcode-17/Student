using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QLHS
{
    public partial class LopHoc : Form
    {
        MyDataTable dataTable = new MyDataTable();
        string maLop;

        public LopHoc()
        {
            InitializeComponent();
            dataTable.OpenConnection();
        }

		private void BatTat(bool giaTri)
		{
			txtMaLop.Enabled = giaTri;
			txtTenLop.Enabled = giaTri;

			btnLuu.Enabled = giaTri;
			btnHuyBo.Enabled = giaTri;

			btnThem.Enabled = !giaTri;
			btnSua.Enabled = !giaTri;
			btnXoa.Enabled = !giaTri;
		}

		public void LayDuLieu()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM LopHoc");
            dataTable.Fill(cmd);

            BindingSource binding = new BindingSource();
            binding.DataSource = dataTable;

			// Hiển thị dữ liệu vào DataGridView
			dataGridView.DataSource = binding;

			// Liên kết dữ liệu từ DataGridView lên các control
			txtMaLop.DataBindings.Clear();
			txtTenLop.DataBindings.Clear();
			txtMaLop.DataBindings.Add("Text", binding, "MaLop");
			txtTenLop.DataBindings.Add("Text", binding, "TenLop");
		}

        private void LopHoc_Load(object sender, EventArgs e)
        {
            LayDuLieu();
            BatTat(false);
        }

		private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
	}
}