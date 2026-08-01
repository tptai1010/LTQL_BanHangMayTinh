namespace BanHangMayTinh.Reports
{
    partial class frmThongKeDoanhThu
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
            panelReport = new Panel();
            gbBaoCaoThang = new GroupBox();
            cboNamKT = new ComboBox();
            cboThangKT = new ComboBox();
            cboNamBD = new ComboBox();
            cboThangBD = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            gbBaoCaoNgay = new GroupBox();
            dtpNgayKT = new DateTimePicker();
            label2 = new Label();
            dtpNgayBD = new DateTimePicker();
            label1 = new Label();
            gbBaoCaoNam = new GroupBox();
            cboBCNamKT = new ComboBox();
            cboBCNamBD = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            btnDatLai = new Button();
            groupBox1 = new GroupBox();
            rbtnBaoCaoNam = new RadioButton();
            rbtnBaoCaoThang = new RadioButton();
            rbtnBaoCaoNgay = new RadioButton();
            btnLocKQ = new Button();
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            gbBaoCaoThang.SuspendLayout();
            gbBaoCaoNgay.SuspendLayout();
            gbBaoCaoNam.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panelReport
            // 
            panelReport.Dock = DockStyle.Fill;
            panelReport.Location = new Point(0, 119);
            panelReport.Name = "panelReport";
            panelReport.Size = new Size(1133, 532);
            panelReport.TabIndex = 8;
            // 
            // gbBaoCaoThang
            // 
            gbBaoCaoThang.Controls.Add(cboNamKT);
            gbBaoCaoThang.Controls.Add(cboThangKT);
            gbBaoCaoThang.Controls.Add(cboNamBD);
            gbBaoCaoThang.Controls.Add(cboThangBD);
            gbBaoCaoThang.Controls.Add(label3);
            gbBaoCaoThang.Controls.Add(label4);
            gbBaoCaoThang.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbBaoCaoThang.Location = new Point(459, 12);
            gbBaoCaoThang.Name = "gbBaoCaoThang";
            gbBaoCaoThang.Size = new Size(412, 94);
            gbBaoCaoThang.TabIndex = 15;
            gbBaoCaoThang.TabStop = false;
            gbBaoCaoThang.Text = "Báo cáo tháng";
            // 
            // cboNamKT
            // 
            cboNamKT.FormattingEnabled = true;
            cboNamKT.Location = new Point(274, 52);
            cboNamKT.Name = "cboNamKT";
            cboNamKT.Size = new Size(127, 28);
            cboNamKT.TabIndex = 6;
            // 
            // cboThangKT
            // 
            cboThangKT.FormattingEnabled = true;
            cboThangKT.Location = new Point(141, 52);
            cboThangKT.Name = "cboThangKT";
            cboThangKT.Size = new Size(127, 28);
            cboThangKT.TabIndex = 5;
            // 
            // cboNamBD
            // 
            cboNamBD.FormattingEnabled = true;
            cboNamBD.Location = new Point(274, 20);
            cboNamBD.Name = "cboNamBD";
            cboNamBD.Size = new Size(127, 28);
            cboNamBD.TabIndex = 4;
            // 
            // cboThangBD
            // 
            cboThangBD.FormattingEnabled = true;
            cboThangBD.Location = new Point(141, 20);
            cboThangBD.Name = "cboThangBD";
            cboThangBD.Size = new Size(127, 28);
            cboThangBD.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F);
            label3.Location = new Point(15, 60);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 2;
            label3.Text = "Đến tháng:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F);
            label4.Location = new Point(15, 28);
            label4.Name = "label4";
            label4.Size = new Size(120, 20);
            label4.TabIndex = 0;
            label4.Text = "Tháng bắt đầu:";
            // 
            // gbBaoCaoNgay
            // 
            gbBaoCaoNgay.Controls.Add(dtpNgayKT);
            gbBaoCaoNgay.Controls.Add(label2);
            gbBaoCaoNgay.Controls.Add(dtpNgayBD);
            gbBaoCaoNgay.Controls.Add(label1);
            gbBaoCaoNgay.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbBaoCaoNgay.Location = new Point(468, 12);
            gbBaoCaoNgay.Name = "gbBaoCaoNgay";
            gbBaoCaoNgay.Size = new Size(372, 94);
            gbBaoCaoNgay.TabIndex = 16;
            gbBaoCaoNgay.TabStop = false;
            gbBaoCaoNgay.Text = "Báo cáo ngày";
            // 
            // dtpNgayKT
            // 
            dtpNgayKT.Font = new Font("Microsoft Sans Serif", 10.2F);
            dtpNgayKT.Location = new Point(133, 53);
            dtpNgayKT.Name = "dtpNgayKT";
            dtpNgayKT.Size = new Size(233, 27);
            dtpNgayKT.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F);
            label2.Location = new Point(15, 60);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 2;
            label2.Text = "Đến ngày:";
            // 
            // dtpNgayBD
            // 
            dtpNgayBD.Font = new Font("Microsoft Sans Serif", 10.2F);
            dtpNgayBD.Location = new Point(133, 21);
            dtpNgayBD.Name = "dtpNgayBD";
            dtpNgayBD.Size = new Size(233, 27);
            dtpNgayBD.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F);
            label1.Location = new Point(15, 28);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 0;
            label1.Text = "Ngày bắt đầu:";
            // 
            // gbBaoCaoNam
            // 
            gbBaoCaoNam.Controls.Add(cboBCNamKT);
            gbBaoCaoNam.Controls.Add(cboBCNamBD);
            gbBaoCaoNam.Controls.Add(label5);
            gbBaoCaoNam.Controls.Add(label6);
            gbBaoCaoNam.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbBaoCaoNam.Location = new Point(485, 12);
            gbBaoCaoNam.Name = "gbBaoCaoNam";
            gbBaoCaoNam.Size = new Size(371, 94);
            gbBaoCaoNam.TabIndex = 14;
            gbBaoCaoNam.TabStop = false;
            gbBaoCaoNam.Text = "Báo cáo năm";
            // 
            // cboBCNamKT
            // 
            cboBCNamKT.FormattingEnabled = true;
            cboBCNamKT.Location = new Point(130, 52);
            cboBCNamKT.Name = "cboBCNamKT";
            cboBCNamKT.Size = new Size(206, 28);
            cboBCNamKT.TabIndex = 6;
            // 
            // cboBCNamBD
            // 
            cboBCNamBD.FormattingEnabled = true;
            cboBCNamBD.Location = new Point(130, 20);
            cboBCNamBD.Name = "cboBCNamBD";
            cboBCNamBD.Size = new Size(206, 28);
            cboBCNamBD.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.2F);
            label5.Location = new Point(15, 60);
            label5.Name = "label5";
            label5.Size = new Size(81, 20);
            label5.TabIndex = 2;
            label5.Text = "Đến năm:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.2F);
            label6.Location = new Point(15, 28);
            label6.Name = "label6";
            label6.Size = new Size(109, 20);
            label6.TabIndex = 0;
            label6.Text = "Năm bắt đầu:";
            // 
            // panel1
            // 
            panel1.Controls.Add(gbBaoCaoThang);
            panel1.Controls.Add(gbBaoCaoNgay);
            panel1.Controls.Add(btnDatLai);
            panel1.Controls.Add(gbBaoCaoNam);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(btnLocKQ);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1133, 119);
            panel1.TabIndex = 7;
            // 
            // btnDatLai
            // 
            btnDatLai.BackColor = Color.SkyBlue;
            btnDatLai.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnDatLai.Location = new Point(914, 66);
            btnDatLai.Name = "btnDatLai";
            btnDatLai.Size = new Size(152, 36);
            btnDatLai.TabIndex = 10;
            btnDatLai.Text = "Đặt lại";
            btnDatLai.UseVisualStyleBackColor = false;
            btnDatLai.Click += btnDatLai_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtnBaoCaoNam);
            groupBox1.Controls.Add(rbtnBaoCaoThang);
            groupBox1.Controls.Add(rbtnBaoCaoNgay);
            groupBox1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(40, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(403, 94);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chọn hình thức báo cáo";
            // 
            // rbtnBaoCaoNam
            // 
            rbtnBaoCaoNam.AutoSize = true;
            rbtnBaoCaoNam.Font = new Font("Microsoft Sans Serif", 10.2F);
            rbtnBaoCaoNam.Location = new Point(227, 26);
            rbtnBaoCaoNam.Name = "rbtnBaoCaoNam";
            rbtnBaoCaoNam.Size = new Size(166, 24);
            rbtnBaoCaoNam.TabIndex = 2;
            rbtnBaoCaoNam.TabStop = true;
            rbtnBaoCaoNam.Text = "Báo cáo theo năm";
            rbtnBaoCaoNam.UseVisualStyleBackColor = true;
            rbtnBaoCaoNam.CheckedChanged += rbtnBaoCaoNam_CheckedChanged;
            // 
            // rbtnBaoCaoThang
            // 
            rbtnBaoCaoThang.AutoSize = true;
            rbtnBaoCaoThang.Font = new Font("Microsoft Sans Serif", 10.2F);
            rbtnBaoCaoThang.Location = new Point(19, 56);
            rbtnBaoCaoThang.Name = "rbtnBaoCaoThang";
            rbtnBaoCaoThang.Size = new Size(175, 24);
            rbtnBaoCaoThang.TabIndex = 1;
            rbtnBaoCaoThang.TabStop = true;
            rbtnBaoCaoThang.Text = "Báo cáo theo tháng";
            rbtnBaoCaoThang.UseVisualStyleBackColor = true;
            rbtnBaoCaoThang.CheckedChanged += rbtnBaoCaoThang_CheckedChanged;
            // 
            // rbtnBaoCaoNgay
            // 
            rbtnBaoCaoNgay.AutoSize = true;
            rbtnBaoCaoNgay.Font = new Font("Microsoft Sans Serif", 10.2F);
            rbtnBaoCaoNgay.Location = new Point(19, 26);
            rbtnBaoCaoNgay.Name = "rbtnBaoCaoNgay";
            rbtnBaoCaoNgay.Size = new Size(169, 24);
            rbtnBaoCaoNgay.TabIndex = 0;
            rbtnBaoCaoNgay.TabStop = true;
            rbtnBaoCaoNgay.Text = "Báo cáo theo ngày";
            rbtnBaoCaoNgay.UseVisualStyleBackColor = true;
            rbtnBaoCaoNgay.CheckedChanged += rbtnBaoCaoNgay_CheckedChanged;
            // 
            // btnLocKQ
            // 
            btnLocKQ.BackColor = Color.SkyBlue;
            btnLocKQ.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnLocKQ.Location = new Point(914, 23);
            btnLocKQ.Name = "btnLocKQ";
            btnLocKQ.Size = new Size(152, 37);
            btnLocKQ.TabIndex = 9;
            btnLocKQ.Text = "Lọc kết quả";
            btnLocKQ.UseVisualStyleBackColor = false;
            btnLocKQ.Click += btnLocKQ_Click;
            // 
            // reportViewer1
            // 
            reportViewer1.Dock = DockStyle.Fill;
            reportViewer1.LocalReport.ReportEmbeddedResource = "rptThongKeHangHoa.rdlc";
            reportViewer1.Location = new Point(0, 0);
            reportViewer1.Name = "ReportViewer";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(396, 246);
            reportViewer1.TabIndex = 0;
            // 
            // frmThongKeDoanhThu
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(1133, 651);
            Controls.Add(panelReport);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmThongKeDoanhThu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thống kê doanh thu";
            Load += frmThongKeDoanhThu_Load;
            gbBaoCaoThang.ResumeLayout(false);
            gbBaoCaoThang.PerformLayout();
            gbBaoCaoNgay.ResumeLayout(false);
            gbBaoCaoNgay.PerformLayout();
            gbBaoCaoNam.ResumeLayout(false);
            gbBaoCaoNam.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelReport;
        private Panel panel1;
        private Button btnDatLai;
        private Button btnLocKQ;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private GroupBox groupBox1;
        private RadioButton rbtnBaoCaoThang;
        private RadioButton rbtnBaoCaoNgay;
        private RadioButton rbtnBaoCaoNam;
        private GroupBox gbBaoCaoThang;
        private ComboBox cboNamBD;
        private ComboBox cboThangBD;
        private Label label3;
        private Label label4;
        private ComboBox cboNamKT;
        private ComboBox cboThangKT;
        private GroupBox gbBaoCaoNam;
        private ComboBox cboBCNamKT;
        private ComboBox cboBCNamBD;
        private Label label5;
        private Label label6;
        private GroupBox gbBaoCaoNgay;
        private DateTimePicker dtpNgayKT;
        private Label label2;
        private DateTimePicker dtpNgayBD;
        private Label label1;
    }
}