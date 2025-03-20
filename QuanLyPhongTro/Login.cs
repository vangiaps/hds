namespace QuanLyPhongTro
{
    public partial class Login : Form
    {
        private userDAO userDAO = new userDAO();

        public Login()
        {
            InitializeComponent();
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtTK.Text.Trim();
            string password = txtMK.Text.Trim();

            if (userDAO.Login(username, password))
            {
                frmMain f = new frmMain();
                this.Hide();
                f.Show();

                f.btQlPhongTro_Click(sender, e);
                f.FormClosed += (s, args) => this.Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!");
            }
        }

        private void ckMK_CheckedChanged(object sender, EventArgs e)
        {
            if (ckMK.Checked)
            {
                txtMK.PasswordChar = '\0';
            }
            else
            {
                txtMK.PasswordChar = '*';
            }
        }

        private void txtMK_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btDangNhap_Click(sender, e);
            }
        }

        private void txtTK_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtMK.Focus();
            }
        }
    }
}
