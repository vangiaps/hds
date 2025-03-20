using System;
using System.Collections.Generic;
using System.ComponentModel;
namespace QuanLyPhongTro
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Cửa sổ không thể thay đổi kích thước

        }

        private void btnSlide_Click(object sender, EventArgs e)
        {
            if (Menu.Width == 350)
            {
                Menu.Width = 70;
            }
            else
            {
                Menu.Width = 350;
            }
        }

        public void btQlPhongTro_Click(object sender, EventArgs e)
        {
            frmQLPhong qLPhong = new frmQLPhong();
            qLPhong.TopLevel = false;
            qLPhong.FormBorderStyle = FormBorderStyle.None;
            qLPhong.Dock = DockStyle.Fill;

            panel2.Controls.Clear();
            panel2.Controls.Add(qLPhong);
            qLPhong.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnQLKhachThue_Click(object sender, EventArgs e)
        {
            frmQLKhachThue qLKhachThue = new frmQLKhachThue();
            qLKhachThue.TopLevel = false;
            qLKhachThue.FormBorderStyle = FormBorderStyle.None;
            qLKhachThue.Dock = DockStyle.Fill;

            panel2.Controls.Clear();
            panel2.Controls.Add(qLKhachThue);
            qLKhachThue.Show();
        }
    }
}
