namespace BanHangMayTinh
{
    partial class frmBackupRestore
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
            txtDuongDan = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            rbtnRestore = new RadioButton();
            rbtnBackup = new RadioButton();
            label2 = new Label();
            btnChonDuongDan = new Button();
            btnThucHien = new Button();
            btnThoat = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtDuongDan
            // 
            txtDuongDan.Location = new Point(157, 151);
            txtDuongDan.Multiline = true;
            txtDuongDan.Name = "txtDuongDan";
            txtDuongDan.Size = new Size(575, 34);
            txtDuongDan.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 165);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 1;
            label1.Text = "Đường dẫn:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtnRestore);
            groupBox1.Controls.Add(rbtnBackup);
            groupBox1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(328, 55);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(263, 72);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chọn hình thức";
            // 
            // rbtnRestore
            // 
            rbtnRestore.AutoSize = true;
            rbtnRestore.Font = new Font("Microsoft Sans Serif", 10.2F);
            rbtnRestore.Location = new Point(148, 25);
            rbtnRestore.Name = "rbtnRestore";
            rbtnRestore.Size = new Size(89, 24);
            rbtnRestore.TabIndex = 1;
            rbtnRestore.TabStop = true;
            rbtnRestore.Text = "Restore";
            rbtnRestore.UseVisualStyleBackColor = true;
            // 
            // rbtnBackup
            // 
            rbtnBackup.AutoSize = true;
            rbtnBackup.Font = new Font("Microsoft Sans Serif", 10.2F);
            rbtnBackup.Location = new Point(24, 25);
            rbtnBackup.Name = "rbtnBackup";
            rbtnBackup.Size = new Size(86, 24);
            rbtnBackup.TabIndex = 0;
            rbtnBackup.TabStop = true;
            rbtnBackup.Text = "Backup";
            rbtnBackup.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(328, 9);
            label2.Name = "label2";
            label2.Size = new Size(263, 29);
            label2.TabIndex = 3;
            label2.Text = "BACKUP - RESTORE";
            // 
            // btnChonDuongDan
            // 
            btnChonDuongDan.BackColor = Color.SkyBlue;
            btnChonDuongDan.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChonDuongDan.Location = new Point(749, 151);
            btnChonDuongDan.Name = "btnChonDuongDan";
            btnChonDuongDan.Size = new Size(129, 34);
            btnChonDuongDan.TabIndex = 4;
            btnChonDuongDan.Text = "Chọn";
            btnChonDuongDan.UseVisualStyleBackColor = false;
            btnChonDuongDan.Click += btnChonDuongDan_Click;
            // 
            // btnThucHien
            // 
            btnThucHien.BackColor = Color.SkyBlue;
            btnThucHien.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThucHien.Location = new Point(309, 212);
            btnThucHien.Name = "btnThucHien";
            btnThucHien.Size = new Size(129, 35);
            btnThucHien.TabIndex = 5;
            btnThucHien.Text = "Thực hiện";
            btnThucHien.UseVisualStyleBackColor = false;
            btnThucHien.Click += btnThucHien_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.SkyBlue;
            btnThoat.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(476, 212);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(129, 35);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // frmBackupRestore
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(925, 300);
            Controls.Add(btnThoat);
            Controls.Add(btnThucHien);
            Controls.Add(btnChonDuongDan);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(txtDuongDan);
            Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmBackupRestore";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Backup, Restore dữ liệu";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDuongDan;
        private Label label1;
        private GroupBox groupBox1;
        private RadioButton rbtnBackup;
        private RadioButton rbtnRestore;
        private Label label2;
        private Button btnChonDuongDan;
        private Button btnThucHien;
        private Button btnThoat;
    }
}