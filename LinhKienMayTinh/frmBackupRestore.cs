using LinhKienMayTinh;
using LinhKienMayTinh.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;

namespace BanHangMayTinh
{
    public partial class frmBackupRestore : Form
    {
        FileDialog dl;
        private string currentUsername;
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public frmBackupRestore(string username)
        {
            InitializeComponent();
            currentUsername = username;
        }

        private void btnChonDuongDan_Click(object sender, EventArgs e)
        {
            if (rbtnBackup.Checked == true)
            {
                dl = new SaveFileDialog();
            }
            else
            {
                dl = new OpenFileDialog();
            }
            dl.Filter = "file type (*.bak)|*.bak";
            dl.DefaultExt = "bak";
            if (dl.ShowDialog() == DialogResult.OK)
            {
                txtDuongDan.Text = dl.FileName;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDuongDan.Text))
            {
                MessageBox.Show("Chưa chọn đường dẫn.");
                return;
            }

            using (var context = new LKMTdbContext())
            {
                string dbName = context.Database.GetDbConnection().Database;
                string filePath = txtDuongDan.Text;

                try
                {
                    if (rbtnBackup.Checked)
                    {
                        if (!Directory.Exists(Path.GetDirectoryName(filePath)))
                        {
                            MessageBox.Show("Thư mục không tồn tại.");
                            return;
                        }

                        string sqlBackup = $@"BACKUP DATABASE [{dbName}]
                                      TO DISK = N'{filePath}'
                                      WITH FORMAT, INIT, NAME = 'Full Backup of {dbName}';";

                        context.Database.ExecuteSqlRaw(sqlBackup);
                        MessageBox.Show("Backup thành công!");
                        logger.Info($"Người dùng {currentUsername} đã backup dữ liệu hệ thống.");
                    }
                    else if (rbtnRestore.Checked)
                    {
                        if (!File.Exists(filePath))
                        {
                            MessageBox.Show("File không tồn tại.");
                            return;
                        }

                        string sqlRestore = $@"USE master;
                                       ALTER DATABASE [{dbName}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
                                       RESTORE DATABASE [{dbName}] FROM DISK = N'{filePath}' WITH REPLACE;
                                       ALTER DATABASE [{dbName}] SET MULTI_USER;";

                        context.Database.ExecuteSqlRaw(sqlRestore);
                        MessageBox.Show("Restore thành công!");
                        logger.Info($"Người dùng {currentUsername} đã restore dữ liệu hệ thống.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
    }
}
