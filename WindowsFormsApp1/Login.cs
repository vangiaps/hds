using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    
    public partial class Login: Form
    {
        Database db = new Database();

        public Login()
        {
            InitializeComponent();
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
           db.Connect();
        }
    }
}
