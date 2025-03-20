using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.btDangNhap = new System.Windows.Forms.Button();
            this.ckMK = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý phòng trọ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tài khoản:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu:";
            // 
            // txtTK
            // 
            this.txtTK.BackColor = System.Drawing.SystemColors.Info;
            this.txtTK.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.txtTK.Location = new System.Drawing.Point(224, 94);
            this.txtTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(298, 44);
            this.txtTK.TabIndex = 3;
            // 
            // txtMK
            // 
            this.txtMK.BackColor = System.Drawing.SystemColors.Info;
            this.txtMK.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.txtMK.Location = new System.Drawing.Point(224, 155);
            this.txtMK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMK.Name = "txtMK";
            this.txtMK.PasswordChar = '*';
            this.txtMK.Size = new System.Drawing.Size(298, 44);
            this.txtMK.TabIndex = 4;
            // 
            // btDangNhap
            // 
            this.btDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDangNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDangNhap.Location = new System.Drawing.Point(266, 261);
            this.btDangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btDangNhap.Name = "btDangNhap";
            this.btDangNhap.Size = new System.Drawing.Size(151, 43);
            this.btDangNhap.TabIndex = 5;
            this.btDangNhap.Text = "Đăng nhập";
            this.btDangNhap.UseVisualStyleBackColor = true;
            this.btDangNhap.Click += new System.EventHandler(this.btDangNhap_Click);
            // 
            // ckMK
            // 
            this.ckMK.AutoSize = true;
            this.ckMK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckMK.Location = new System.Drawing.Point(224, 211);
            this.ckMK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckMK.Name = "ckMK";
            this.ckMK.Size = new System.Drawing.Size(210, 31);
            this.ckMK.TabIndex = 6;
            this.ckMK.Text = "Hiển thị mật khảu";
            this.ckMK.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(700, 315);
            this.Controls.Add(this.ckMK);
            this.Controls.Add(this.btDangNhap);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

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
