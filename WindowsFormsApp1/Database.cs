using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Database
    {
        private string connectionString = "Server=DESKTOP-SLR8F9M\\SQLEXPRESS;Database=QuanLyPhongTro;Integrated Security=True";

        public void Connect()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Kết nối SQL Server thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối: " + ex.Message);
                }
            }
        }

        public void GetData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM TenBang"; // Thay "TenBang" bằng tên bảng thật
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        MessageBox.Show("Dữ liệu: " + reader[0].ToString());
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi lấy dữ liệu: " + ex.Message);
                }
            }
        }
    }
}
