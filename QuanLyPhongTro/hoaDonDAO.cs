using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace QuanLyPhongTro
{
    internal class hoaDonDAO
    {
        string connectionString = "Data Source=DESKTOP-85PII9M\\SQLEXPRESS;Initial Catalog=QuanLyPhongTro;Integrated Security=True;TrustServerCertificate=True";

        public hoaDonDAO()
        {
        }
        public List<hoaDon> GetHoaDon()
        {
            List<hoaDon> danhSachHoaDon = new List<hoaDon>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM HoaDon";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            hoaDon hd = new hoaDon();
                            hd.MaHoaDon = reader.GetInt32(0);
                            hd.MaPhong = reader.IsDBNull(1) ? null : reader.GetInt32(1);
                            hd.NgayLap = reader.GetDateTime(2);

                            // Loại bỏ số 0 thừa sau dấu phẩy
                            hd.TienPhong = decimal.Parse(reader.GetDecimal(3).ToString("0.##"));
                            hd.TienDien = reader.IsDBNull(4) ? null : (decimal?)decimal.Parse(reader.GetDecimal(4).ToString("0.##"));
                            hd.TienNuoc = reader.IsDBNull(5) ? null : (decimal?)decimal.Parse(reader.GetDecimal(5).ToString("0.##"));
                            hd.TienDV = reader.IsDBNull(6) ? null : (decimal?)decimal.Parse(reader.GetDecimal(6).ToString("0.##"));
                            hd.Tong = reader.IsDBNull(7) ? null : (decimal?)decimal.Parse(reader.GetDecimal(7).ToString("0.##"));

                            hd.TrangThaiThanhToan = reader.IsDBNull(8) ? null : reader.GetString(8);
                            danhSachHoaDon.Add(hd);
                        }
                    }
                }
            }
            return danhSachHoaDon;
        }
        public List<hoaDon> GetHoaDonbyMaPhong(int maPhong)
        {
          List<hoaDon> danhSachHoaDon = new List<hoaDon>();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM HoaDon WHERE MaPhong = @MaPhong";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MaPhong", maPhong);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    hoaDon hd = new hoaDon();
                    hd.MaHoaDon = reader.GetInt32(0);
                    hd.MaPhong = reader.IsDBNull(1) ? null : reader.GetInt32(1);
                    hd.NgayLap = reader.GetDateTime(2);
                    hd.TienPhong = decimal.Parse(reader.GetDecimal(3).ToString("0.##"));
                    hd.TienDien = reader.IsDBNull(4) ? null : (decimal?)decimal.Parse(reader.GetDecimal(4).ToString("0.##"));
                    hd.TienNuoc = reader.IsDBNull(5) ? null : (decimal?)decimal.Parse(reader.GetDecimal(5).ToString("0.##"));
                    hd.TienDV = reader.IsDBNull(6) ? null : (decimal?)decimal.Parse(reader.GetDecimal(6).ToString("0.##"));
                    hd.Tong = reader.IsDBNull(7) ? null : (decimal?)decimal.Parse(reader.GetDecimal(7).ToString("0.##"));
                    hd.TrangThaiThanhToan = reader.IsDBNull(8) ? null : reader.GetString(8);
                    danhSachHoaDon.Add(hd);
                }
            }
            return danhSachHoaDon;
        }


    }

}
