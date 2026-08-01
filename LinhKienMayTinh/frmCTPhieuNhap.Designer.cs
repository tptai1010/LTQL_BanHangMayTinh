namespace LinhKienMayTinh
{
    partial class frmCTPhieuNhap
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            dgvCTPhieuNhap = new DataGridView();
            btnThoat = new Button();
            btnXoa = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCTPhieuNhap).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvCTPhieuNhap);
            groupBox1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(18, 12);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(969, 358);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chi tiết phiếu nhập";
            // 
            // dgvCTPhieuNhap
            // 
            dgvCTPhieuNhap.AllowUserToAddRows = false;
            dgvCTPhieuNhap.AllowUserToDeleteRows = false;
            dgvCTPhieuNhap.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCTPhieuNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCTPhieuNhap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCTPhieuNhap.Location = new Point(7, 26);
            dgvCTPhieuNhap.MultiSelect = false;
            dgvCTPhieuNhap.Name = "dgvCTPhieuNhap";
            dgvCTPhieuNhap.RowHeadersWidth = 51;
            dgvCTPhieuNhap.Size = new Size(955, 326);
            dgvCTPhieuNhap.TabIndex = 0;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.SkyBlue;
            btnThoat.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnThoat.Location = new Point(520, 388);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(169, 37);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.SkyBlue;
            btnXoa.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnXoa.Location = new Point(311, 388);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(169, 37);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // frmCTPhieuNhap
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(1000, 440);
            Controls.Add(groupBox1);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmCTPhieuNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chi Tiết Phiếu Nhập";
            Load += frmCTPhieuNhap_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCTPhieuNhap).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgvCTPhieuNhap;
        private Button btnThoat;
        private Button btnXoa;
    }
}