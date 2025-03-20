using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //string connectionString = "Server=localhost;Database=TenCSDL;User Id=;Password=;";
            //string connectionString = "Server=DESKTOP-SLR8F9M\\SQLEXPRESS;Database=QuanLyPhongTro;Integrated Security=True";

            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    try
            //    {
            //        connection.Open();
            //        //MessageBox.Show("Kết nối SQL Server thành công!");
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Lỗi kết nối: " + ex.Message);
            //    }
            //}

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
