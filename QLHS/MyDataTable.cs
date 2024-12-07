using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLHS
{
    internal class MyDataTable : DataTable
    {
        // Biến toàn cục
        SqlConnection connection;
        SqlDataAdapter adapter;
        SqlCommand command;

        // Lấy chuỗi kết nối
        public string ConnectionString()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder["Server"] = ".\\SQLEXPRESS";
            builder["Database"] = "QLHS";
            builder["Integrated Security"] = "True";
            return builder.ConnectionString;
        }

        // Mở kết nối
        public bool OpenConnection()
        {
            try
            {
                if (connection == null)
                    connection = new SqlConnection(ConnectionString());
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                return true;
            }
            catch
            {
                connection.Close();
                return false;
            }
        }

        // Thực thi câu lệnh Select
        public void Fill(SqlCommand selectCommand)
        {
            command = selectCommand;
            try
            {
                command.Connection = connection;

                adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;

                this.Clear();
                adapter.Fill(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể thực thi câu lệnh SQL này!\nLỗi: " + ex.Message, "Lỗi truy vấn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

		// Thực thi câu lệnh Insert, Update, Delete
		public int Update(SqlCommand insertUpdateDeleteCommand)
        {
            int result = 0;
            SqlTransaction transaction = null;
            try
            {
                transaction = connection.BeginTransaction();

                insertUpdateDeleteCommand.Connection = connection;
                insertUpdateDeleteCommand.Transaction = transaction;
                result = insertUpdateDeleteCommand.ExecuteNonQuery();

                this.AcceptChanges();
                transaction.Commit();
            }
            catch (Exception e)
            {
                if (transaction != null)
                    transaction.Rollback();
                MessageBox.Show("Không thể thực thi câu lệnh SQL này!\nLỗi: " + e.Message, "Lỗi truy vấn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
    }
}