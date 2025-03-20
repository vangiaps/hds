using Microsoft.Data.SqlClient;
using System.Data;

namespace QuanLyPhongTro
{
    class Database
    {
        private string connectionString = "Server=FV1X1J3\\SQLEXPRESS;Database=QuanLyPhongTro;Integrated Security=True;TrustServerCertificate=True";

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

        public Database()
        {

        }

        public DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        //public void GetData()
        //{
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        try
        //        {
        //            connection.Open();
        //            string query = "SELECT * FROM PhongTro";
        //            SqlCommand cmd = new SqlCommand(query, connection);
        //            SqlDataReader reader = cmd.ExecuteReader();

        //            while (reader.Read())
        //            {
        //                MessageBox.Show("Dữ liệu: " + reader[0].ToString());
        //            }

        //            reader.Close();
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Lỗi lấy dữ liệu: " + ex.Message);
        //        }
        //    }
        //}
    }
}
