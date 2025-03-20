namespace QuanLyPhongTro
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtTK = new TextBox();
            txtMK = new TextBox();
            btDangNhap = new Button();
            ckMK = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 26F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(197, 23);
            label1.Name = "label1";
            label1.Size = new Size(404, 60);
            label1.TabIndex = 0;
            label1.Text = "Quản lý phòng trọ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(74, 126);
            label2.Name = "label2";
            label2.Size = new Size(150, 36);
            label2.TabIndex = 1;
            label2.Text = "Tài khoản:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(74, 194);
            label3.Name = "label3";
            label3.Size = new Size(143, 36);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu:";
            // 
            // txtTK
            // 
            txtTK.BackColor = SystemColors.Info;
            txtTK.Font = new Font("Times New Roman", 16F);
            txtTK.Location = new Point(249, 118);
            txtTK.Name = "txtTK";
            txtTK.Size = new Size(331, 44);
            txtTK.TabIndex = 3;
            txtTK.KeyPress += txtTK_TextChanged;
            // 
            // txtMK
            // 
            txtMK.BackColor = SystemColors.Info;
            txtMK.Font = new Font("Times New Roman", 16F);
            txtMK.Location = new Point(249, 194);
            txtMK.Name = "txtMK";
            txtMK.PasswordChar = '*';
            txtMK.Size = new Size(331, 44);
            txtMK.TabIndex = 4;
            txtMK.KeyPress += txtMK_TextChanged;
            // 
            // btDangNhap
            // 
            btDangNhap.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btDangNhap.Location = new Point(325, 323);
            btDangNhap.Name = "btDangNhap";
            btDangNhap.Size = new Size(134, 41);
            btDangNhap.TabIndex = 5;
            btDangNhap.Text = "Đăng nhập";
            btDangNhap.UseVisualStyleBackColor = true;
            btDangNhap.Click += btDangNhap_Click;
            // 
            // ckMK
            // 
            ckMK.AutoSize = true;
            ckMK.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ckMK.Location = new Point(249, 264);
            ckMK.Name = "ckMK";
            ckMK.Size = new Size(210, 31);
            ckMK.TabIndex = 6;
            ckMK.Text = "Hiển thị mật khảu";
            ckMK.UseVisualStyleBackColor = true;
            ckMK.CheckedChanged += ckMK_CheckedChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(778, 394);
            Controls.Add(ckMK);
            Controls.Add(btDangNhap);
            Controls.Add(txtMK);
            Controls.Add(txtTK);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtTK;
        private TextBox txtMK;
        private Button btDangNhap;
        private CheckBox ckMK;
    }
}
