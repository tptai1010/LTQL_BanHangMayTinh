namespace BanHangMayTinh.Reports
{
    partial class frmInPBH
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
            SuspendLayout();
            // 
            // panelReport
            // 
            panelReport.Location = new Point(0, 1);
            panelReport.Name = "panelReport";
            panelReport.Size = new Size(1091, 921);
            panelReport.TabIndex = 0;
            // 
            // frmInPBH
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(1132, 853);
            Controls.Add(panelReport);
            Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmInPBH";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "In phiếu bảo hành";
            Load += frmInPBH_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel panelReport;
    }
}