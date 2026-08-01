namespace LinhKienMayTinh
{
    partial class frmDangNhap
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            label4 = new Label();
            btnShowPassword = new Button();
            mtxtPassword = new MaskedTextBox();
            txtUsername = new TextBox();
            label3 = new Label();
            label2 = new Label();
            btnDangKy = new Button();
            btnDangNhap = new Button();
            btnThoat = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(193, 21);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(106, 32);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnShowPassword);
            groupBox1.Controls.Add(mtxtPassword);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(44, 76);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(411, 177);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin đăng nhập";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F);
            label4.Location = new Point(61, 138);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(127, 20);
            label4.TabIndex = 5;
            label4.Text = "Show password";
            // 
            // btnShowPassword
            // 
            btnShowPassword.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnShowPassword.Location = new Point(17, 127);
            btnShowPassword.Margin = new Padding(4, 3, 4, 3);
            btnShowPassword.Name = "btnShowPassword";
            btnShowPassword.Size = new Size(36, 31);
            btnShowPassword.TabIndex = 4;
            btnShowPassword.UseVisualStyleBackColor = true;
            btnShowPassword.Click += btnShowPassword_Click;
            // 
            // mtxtPassword
            // 
            mtxtPassword.Font = new Font("Microsoft Sans Serif", 10.2F);
            mtxtPassword.Location = new Point(116, 81);
            mtxtPassword.Margin = new Padding(4, 3, 4, 3);
            mtxtPassword.Name = "mtxtPassword";
            mtxtPassword.Size = new Size(267, 27);
            mtxtPassword.TabIndex = 3;
            mtxtPassword.KeyDown += mtxtPassword_KeyDown;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtUsername.Location = new Point(116, 26);
            txtUsername.Margin = new Padding(4, 3, 4, 3);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(267, 34);
            txtUsername.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F);
            label3.Location = new Point(17, 88);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 1;
            label3.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F);
            label2.Location = new Point(17, 40);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 0;
            label2.Text = "Username:";
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = Color.SkyBlue;
            btnDangKy.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnDangKy.Location = new Point(44, 269);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(196, 38);
            btnDangKy.TabIndex = 2;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = false;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.SkyBlue;
            btnDangNhap.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnDangNhap.Location = new Point(259, 269);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(196, 38);
            btnDangNhap.TabIndex = 3;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.SkyBlue;
            btnThoat.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnThoat.Location = new Point(44, 322);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(411, 38);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(499, 399);
            Controls.Add(btnThoat);
            Controls.Add(btnDangNhap);
            Controls.Add(btnDangKy);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng Nhập";
            Load += frmDangNhap_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private MaskedTextBox mtxtPassword;
        private TextBox txtUsername;
        private Label label3;
        private Label label2;
        private Button btnShowPassword;
        private Label label4;
        private Button btnDangKy;
        private Button btnDangNhap;
        private Button btnThoat;
    }
}