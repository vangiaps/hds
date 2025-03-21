using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongTro
{
    public partial class frmHoaDon : Form
    {
        private BindingSource bindingSource = new BindingSource();
        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            hoaDonDAO hoaDonDAO = new hoaDonDAO();
            bindingSource.DataSource = hoaDonDAO.GetHoaDon();
            dataGridView1.DataSource = bindingSource;

        }
        public frmHoaDon()
        {
            InitializeComponent();
            BindingSource bindingSource = new BindingSource();
            this.Load += new EventHandler(frmHoaDon_Load);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hoaDonDAO hoaDonDAO = new hoaDonDAO();
            bindingSource.DataSource = hoaDonDAO.GetHoaDon();
            dataGridView1.DataSource = bindingSource;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtMaHoaDon.Text = row.Cells[0].Value.ToString();
                txtMaPhong.Text = row.Cells[1].Value.ToString();
                txtNgayLap.Text = row.Cells[2].Value.ToString();
                txtTienPhong.Text = row.Cells[3].Value.ToString();
                txtTienDien.Text = row.Cells[4].Value.ToString();
                txtTienNuoc.Text = row.Cells[5].Value.ToString();
                txtTienDV.Text = row.Cells[6].Value.ToString();
                txtTong.Text = row.Cells[7].Value.ToString();

            }
        }

        private void btnTimKIem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == ""||txtTimKiem.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Vui lòng nhập mã phòng cần tìm");
                return;
            }
            else
            {
                hoaDonDAO hoaDonDAO = new hoaDonDAO();
                bindingSource.DataSource = hoaDonDAO.GetHoaDonbyMaPhong(int.Parse(txtTimKiem.Text));
                dataGridView1.DataSource = bindingSource;
            }            
   
        }

        
    }
}
