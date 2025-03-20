using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace QuanLyPhongTro
{
    public class userDAO
    {
        private Database db = new Database();

        public bool Login(string username, string password)
        {
            string query = "SELECT COUNT(*) FROM NguoiDung WHERE Username = @Username AND Password = @Password";
            SqlParameter[] parameters = {
                new SqlParameter("@Username", username),
                new SqlParameter("@Password", password)
            };

            DataTable result = db.ExecuteQuery(query, parameters);
            return result.Rows[0][0].ToString() == "1";
        }
    }
}
