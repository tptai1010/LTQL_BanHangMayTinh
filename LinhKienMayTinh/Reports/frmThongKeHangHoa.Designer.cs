namespace BanHangMayTinh.Reports
{
    partial class frmThongKeHangHoa
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
            btnLocKQ = new Button();
            cboLoaiHH = new ComboBox();
            cboHangSX = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            panelReport = new Panel();
            btnDatLai = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDatLai);
            panel1.Controls.Add(btnLocKQ);
            panel1.Controls.Add(cboLoaiHH);
            panel1.Controls.Add(cboHangSX);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1111, 57);
            panel1.TabIndex = 5;
            // 
            // btnLocKQ
            // 
            btnLocKQ.BackColor = Color.SkyBlue;
            btnLocKQ.Location = new Point(823, 12);
            btnLocKQ.Name = "btnLocKQ";
            btnLocKQ.Size = new Size(122, 28);
            btnLocKQ.TabIndex = 9;
            btnLocKQ.Text = "Lọc kết quả";
            btnLocKQ.UseVisualStyleBackColor = false;
            btnLocKQ.Click += btnLocKQ_Click_1;
            // 
            // cboLoaiHH
            // 
            cboLoaiHH.FormattingEnabled = true;
            cboLoaiHH.Location = new Point(547, 12);
            cboLoaiHH.Name = "cboLoaiHH";
            cboLoaiHH.Size = new Size(235, 28);
            cboLoaiHH.TabIndex = 8;
            // 
            // cboHangSX
            // 
            cboHangSX.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cboHangSX.FormattingEnabled = true;
            cboHangSX.Location = new Point(149, 12);
            cboHangSX.Name = "cboHangSX";
            cboHangSX.Size = new Size(235, 28);
            cboHangSX.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(422, 20);
            label3.Name = "label3";
            label3.Size = new Size(119, 20);
            label3.TabIndex = 6;
            label3.Text = "Loại hàng hóa:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 20);
            label4.Name = "label4";
            label4.Size = new Size(122, 20);
            label4.TabIndex = 5;
            label4.Text = "Hãng sản xuất:";
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
            // panelReport
            // 
            panelReport.Dock = DockStyle.Fill;
            panelReport.Location = new Point(0, 57);
            panelReport.Name = "panelReport";
            panelReport.Size = new Size(1111, 527);
            panelReport.TabIndex = 6;
            // 
            // btnDatLai
            // 
            btnDatLai.BackColor = Color.SkyBlue;
            btnDatLai.Location = new Point(964, 12);
            btnDatLai.Name = "btnDatLai";
            btnDatLai.Size = new Size(122, 28);
            btnDatLai.TabIndex = 10;
            btnDatLai.Text = "Đặt lại";
            btnDatLai.UseVisualStyleBackColor = false;
            btnDatLai.Click += btnDatLai_Click;
            // 
            // frmThongKeHangHoa
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(1111, 584);
            Controls.Add(panelReport);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmThongKeHangHoa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thống kê hàng hóa";
            Load += frmThongKeHangHoa_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnLocKQ;
        private ComboBox cboLoaiHH;
        private ComboBox cboHangSX;
        private Label label3;
        private Label label4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Panel panelReport;
        private Button btnDatLai;
    }
}