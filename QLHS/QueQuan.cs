using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QLHS
{
    public partial class QueQuan : Form
    {
        MyDataTable dataTable = new MyDataTable();
        string maQueQuan = "";

        public QueQuan()
        {
            InitializeComponent();
            dataTable.OpenConnection();
        }

		private void BatTat(bool giaTri)
        {
            txtMaQueQuan.Enabled = giaTri;
			txtTenQueQuan.Enabled = giaTri;

			btnLuu.Enabled = giaTri;
			btnHuyBo.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
			btnSua.Enabled = !giaTri;
			btnXoa.Enabled = !giaTri;
		}

		private void LayDuLieu()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM QueQuan");
            dataTable.Fill(cmd);

            BindingSource binding = new BindingSource();
            binding.DataSource = dataTable;

			// Hiển thị dữ liệu vào DataGridView
			dataGridView.DataSource = binding;

			// Liên kết dữ liệu từ DataGridView lên các control
			txtMaQueQuan.DataBindings.Clear();
			txtTenQueQuan.DataBindings.Clear();
			txtMaQueQuan.DataBindings.Add("Text", binding, "MaQueQuan");
			txtTenQueQuan.DataBindings.Add("Text", binding, "TenQueQuan");
		}

        private void QueQuan_Load(object sender, EventArgs e)
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