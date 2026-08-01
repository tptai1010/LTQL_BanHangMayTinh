namespace LinhKienMayTinh
{
    partial class frmDKTK
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
            mtxtPassword = new MaskedTextBox();
            label6 = new Label();
            btnShowPassword = new Button();
            dtpNgaySinh = new DateTimePicker();
            txtUsername = new TextBox();
            txtHoTen = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnThoat = new Button();
            btnDangKy = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(97, 20);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(314, 32);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG KÝ TÀI KHOẢN";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(mtxtPassword);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btnShowPassword);
            groupBox1.Controls.Add(dtpNgaySinh);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Controls.Add(txtHoTen);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(32, 69);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(444, 275);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin đăng ký";
            // 
            // mtxtPassword
            // 
            mtxtPassword.Location = new Point(118, 183);
            mtxtPassword.Name = "mtxtPassword";
            mtxtPassword.Size = new Size(293, 27);
            mtxtPassword.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(65, 233);
            label6.Name = "label6";
            label6.Size = new Size(127, 20);
            label6.TabIndex = 9;
            label6.Text = "Show password";
            // 
            // btnShowPassword
            // 
            btnShowPassword.Location = new Point(24, 227);
            btnShowPassword.Name = "btnShowPassword";
            btnShowPassword.Size = new Size(35, 33);
            btnShowPassword.TabIndex = 8;
            btnShowPassword.UseVisualStyleBackColor = true;
            btnShowPassword.Click += btnShowPassword_Click;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Font = new Font("Microsoft Sans Serif", 10.2F);
            dtpNgaySinh.Location = new Point(117, 84);
            dtpNgaySinh.Margin = new Padding(4, 3, 4, 3);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(294, 27);
            dtpNgaySinh.TabIndex = 7;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtUsername.Location = new Point(117, 127);
            txtUsername.Margin = new Padding(4, 3, 4, 3);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(294, 34);
            txtUsername.TabIndex = 5;
            // 
            // txtHoTen
            // 
            txtHoTen.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtHoTen.Location = new Point(117, 30);
            txtHoTen.Margin = new Padding(4, 3, 4, 3);
            txtHoTen.Multiline = true;
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(294, 34);
            txtHoTen.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.2F);
            label5.Location = new Point(23, 190);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 3;
            label5.Text = "Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F);
            label4.Location = new Point(23, 141);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(91, 20);
            label4.TabIndex = 2;
            label4.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F);
            label3.Location = new Point(23, 89);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 1;
            label3.Text = "Ngày sinh:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F);
            label2.Location = new Point(23, 44);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 0;
            label2.Text = "Họ và tên:";
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.SkyBlue;
            btnThoat.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnThoat.Location = new Point(32, 371);
            btnThoat.Margin = new Padding(4, 3, 4, 3);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(218, 38);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = Color.SkyBlue;
            btnDangKy.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnDangKy.Location = new Point(258, 371);
            btnDangKy.Margin = new Padding(4, 3, 4, 3);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(218, 38);
            btnDangKy.TabIndex = 3;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = false;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // frmDKTK
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 421);
            Controls.Add(btnDangKy);
            Controls.Add(btnThoat);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 10.2F);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmDKTK";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng Ký Tài Khoản";
            Load += frmDKTK_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnThoat;
        private Button btnDangKy;
        private TextBox txtUsername;
        private TextBox txtHoTen;
        private DateTimePicker dtpNgaySinh;
        private Label label6;
        private Button btnShowPassword;
        private MaskedTextBox mtxtPassword;
    }
}