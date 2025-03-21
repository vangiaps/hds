namespace QuanLyPhongTro
{
    partial class frmHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            labDaThanhToan = new Label();
            labTatCa = new Label();
            groupBox1 = new GroupBox();
            btnTimKIem = new Button();
            txtTienNuoc = new TextBox();
            txtTienDV = new TextBox();
            txtNgayLap = new TextBox();
            txtMaPhong = new TextBox();
            txtMaHoaDon = new TextBox();
            txtTienPhong = new TextBox();
            txtTienDien = new TextBox();
            txtTong = new TextBox();
            txtTimKiem = new TextBox();
            labTong = new Label();
            labTienNuoc = new Label();
            labTienDien = new Label();
            label3 = new Label();
            label2 = new Label();
            labNgayLap = new Label();
            labMaPhong = new Label();
            labMaHoaDon = new Label();
            panel2 = new Panel();
            button3 = new Button();
            button2 = new Button();
            btnTaoMoi = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(labDaThanhToan);
            panel1.Controls.Add(labTatCa);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(958, 158);
            panel1.TabIndex = 0;
            // 
            // labDaThanhToan
            // 
            labDaThanhToan.AutoSize = true;
            labDaThanhToan.Location = new Point(156, 7);
            labDaThanhToan.Name = "labDaThanhToan";
            labDaThanhToan.Size = new Size(87, 15);
            labDaThanhToan.TabIndex = 2;
            labDaThanhToan.Text = "Đã Thanh Toán";
            // 
            // labTatCa
            // 
            labTatCa.AutoSize = true;
            labTatCa.Location = new Point(68, 7);
            labTatCa.Name = "labTatCa";
            labTatCa.Size = new Size(39, 15);
            labTatCa.TabIndex = 1;
            labTatCa.Text = "Tất cả";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnTimKIem);
            groupBox1.Controls.Add(txtTienNuoc);
            groupBox1.Controls.Add(txtTienDV);
            groupBox1.Controls.Add(txtNgayLap);
            groupBox1.Controls.Add(txtMaPhong);
            groupBox1.Controls.Add(txtMaHoaDon);
            groupBox1.Controls.Add(txtTienPhong);
            groupBox1.Controls.Add(txtTienDien);
            groupBox1.Controls.Add(txtTong);
            groupBox1.Controls.Add(txtTimKiem);
            groupBox1.Controls.Add(labTong);
            groupBox1.Controls.Add(labTienNuoc);
            groupBox1.Controls.Add(labTienDien);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(labNgayLap);
            groupBox1.Controls.Add(labMaPhong);
            groupBox1.Controls.Add(labMaHoaDon);
            groupBox1.Location = new Point(10, 22);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(919, 134);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btnTimKIem
            // 
            btnTimKIem.Location = new Point(827, 93);
            btnTimKIem.Name = "btnTimKIem";
            btnTimKIem.Size = new Size(75, 23);
            btnTimKIem.TabIndex = 18;
            btnTimKIem.Text = "Tim kiem";
            btnTimKIem.UseVisualStyleBackColor = true;
            btnTimKIem.Click += btnTimKIem_Click;
            // 
            // txtTienNuoc
            // 
            txtTienNuoc.Location = new Point(617, 51);
            txtTienNuoc.Name = "txtTienNuoc";
            txtTienNuoc.Size = new Size(100, 23);
            txtTienNuoc.TabIndex = 17;
            // 
            // txtTienDV
            // 
            txtTienDV.Location = new Point(474, 51);
            txtTienDV.Name = "txtTienDV";
            txtTienDV.Size = new Size(100, 23);
            txtTienDV.TabIndex = 16;
            // 
            // txtNgayLap
            // 
            txtNgayLap.Location = new Point(175, 43);
            txtNgayLap.Name = "txtNgayLap";
            txtNgayLap.Size = new Size(147, 23);
            txtNgayLap.TabIndex = 15;
            // 
            // txtMaPhong
            // 
            txtMaPhong.Location = new Point(29, 45);
            txtMaPhong.Name = "txtMaPhong";
            txtMaPhong.Size = new Size(100, 23);
            txtMaPhong.TabIndex = 14;
            // 
            // txtMaHoaDon
            // 
            txtMaHoaDon.Location = new Point(30, 94);
            txtMaHoaDon.Name = "txtMaHoaDon";
            txtMaHoaDon.Size = new Size(100, 23);
            txtMaHoaDon.TabIndex = 13;
            // 
            // txtTienPhong
            // 
            txtTienPhong.Location = new Point(179, 96);
            txtTienPhong.Name = "txtTienPhong";
            txtTienPhong.Size = new Size(100, 23);
            txtTienPhong.TabIndex = 12;
            // 
            // txtTienDien
            // 
            txtTienDien.Location = new Point(345, 93);
            txtTienDien.Name = "txtTienDien";
            txtTienDien.Size = new Size(100, 23);
            txtTienDien.TabIndex = 11;
            // 
            // txtTong
            // 
            txtTong.Location = new Point(535, 96);
            txtTong.Name = "txtTong";
            txtTong.Size = new Size(100, 23);
            txtTong.TabIndex = 10;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(712, 93);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(100, 23);
            txtTimKiem.TabIndex = 9;
            // 
            // labTong
            // 
            labTong.AutoSize = true;
            labTong.Location = new Point(535, 78);
            labTong.Name = "labTong";
            labTong.Size = new Size(34, 15);
            labTong.TabIndex = 7;
            labTong.Text = "Tong";
            // 
            // labTienNuoc
            // 
            labTienNuoc.AutoSize = true;
            labTienNuoc.Location = new Point(617, 33);
            labTienNuoc.Name = "labTienNuoc";
            labTienNuoc.Size = new Size(57, 15);
            labTienNuoc.TabIndex = 6;
            labTienNuoc.Text = "tien nuoc";
            // 
            // labTienDien
            // 
            labTienDien.AutoSize = true;
            labTienDien.Location = new Point(345, 78);
            labTienDien.Name = "labTienDien";
            labTienDien.Size = new Size(60, 15);
            labTienDien.TabIndex = 5;
            labTienDien.Text = "tien ddien";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(474, 33);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 4;
            label3.Text = "TIEN DV";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(179, 78);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 3;
            label2.Text = "TIEN PHONG";
            // 
            // labNgayLap
            // 
            labNgayLap.AutoSize = true;
            labNgayLap.Location = new Point(175, 25);
            labNgayLap.Name = "labNgayLap";
            labNgayLap.Size = new Size(52, 15);
            labNgayLap.TabIndex = 2;
            labNgayLap.Text = "ngay lap";
            // 
            // labMaPhong
            // 
            labMaPhong.AutoSize = true;
            labMaPhong.Location = new Point(30, 27);
            labMaPhong.Name = "labMaPhong";
            labMaPhong.Size = new Size(62, 15);
            labMaPhong.TabIndex = 1;
            labMaPhong.Text = "ma phong";
            // 
            // labMaHoaDon
            // 
            labMaHoaDon.AutoSize = true;
            labMaHoaDon.Location = new Point(30, 76);
            labMaHoaDon.Name = "labMaHoaDon";
            labMaHoaDon.Size = new Size(71, 15);
            labMaHoaDon.TabIndex = 0;
            labMaHoaDon.Text = "ma hoa don";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(btnTaoMoi);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 173);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(958, 292);
            panel2.TabIndex = 1;
            // 
            // button3
            // 
            button3.Location = new Point(611, 16);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(82, 22);
            button3.TabIndex = 4;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(722, 16);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 22);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnTaoMoi
            // 
            btnTaoMoi.Location = new Point(837, 15);
            btnTaoMoi.Margin = new Padding(3, 2, 3, 2);
            btnTaoMoi.Name = "btnTaoMoi";
            btnTaoMoi.Size = new Size(82, 22);
            btnTaoMoi.TabIndex = 2;
            btnTaoMoi.Text = "Tao moi";
            btnTaoMoi.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 15);
            label1.Name = "label1";
            label1.Size = new Size(118, 15);
            label1.TabIndex = 1;
            label1.Text = "Danh sach hoa down";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 41);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(958, 251);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // frmHoaDon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(958, 465);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmHoaDon";
            Text = "frmHoaDon";
            Load += frmHoaDon_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private GroupBox groupBox1;
        private Label labDaThanhToan;
        private Label labTatCa;
        private Label labMaHoaDon;
        private DataGridView dataGridView1;
        private Label labNgayLap;
        private Label labMaPhong;
        private Button button3;
        private Button button2;
        private Button btnTaoMoi;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label labTienDien;
        private Label labTong;
        private Label labTienNuoc;
        private TextBox txtTienPhong;
        private TextBox txtTienDien;
        private TextBox txtTong;
        private TextBox txtTimKiem;
        private Button btnTimKIem;
        private TextBox txtTienNuoc;
        private TextBox txtTienDV;
        private TextBox txtNgayLap;
        private TextBox txtMaPhong;
        private TextBox txtMaHoaDon;
    }
}