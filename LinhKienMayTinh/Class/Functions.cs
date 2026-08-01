using LinhKienMayTinh.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static ClosedXML.Excel.XLPredefinedFormat;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LinhKienMayTinh.Class
{
    internal class Functions
    {
        public static SqlConnection Con { get; private set; }

        public static string CurrentUserRole { get; private set; } = "NhanVien";
        public static string currentUsername;

        public static void Connect()
        {
            try
            {
                string connectString = ConfigurationManager.ConnectionStrings["LinhKienMayTinhConnection"].ConnectionString;
                Con = new SqlConnection(connectString);
                Con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }

        public static void Disconnect()
        {
            if (Con?.State == ConnectionState.Open)
            {
                Con.Close();
                Con.Dispose();
                Con = null;
            }
        }

        public static void SetCurrentUserRole(string username)
        {
            using (var context = new LKMTdbContext())
            {
                CurrentUserRole = context.TaiKhoan
                    .Where(tk => tk.Username == username)
                    .Select(tk => tk.QuyenHan)
                    .FirstOrDefault() ?? "NhanVien"; 
            }
        }

        public static string GetScalarValue(string sql)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand(sql, Con))
                {
                    object result = cmd.ExecuteScalar();
                    return result?.ToString() ?? "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lấy dữ liệu: " + ex.Message);
                return "";
            }
        }

        public static bool IsKeyExists(string tableName, string columnName, string value)
        {
            using (var context = new LKMTdbContext())
            {
                return context.Database
                    .SqlQueryRaw<int>($"SELECT COUNT(*) FROM {tableName} WHERE {columnName} = @p0", value)
                    .FirstOrDefault() > 0;
            }
        }


        public static void ExecuteNonQuery(string sql, bool checkPermission = false, string requiredRole = "Admin")
        {
            if (checkPermission && CurrentUserRole != requiredRole)
            {
                MessageBox.Show("Bạn không có quyền thực hiện thao tác này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlCommand cmd = new SqlCommand(sql, Con))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thực thi SQL: " + ex.Message);
            }
        }

        public static DataTable GetDataToTable(string sql)
        {
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter(sql, Con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi truy vấn dữ liệu: " + ex.Message);
                return null;
            }
        }

        public static void FillComboBox(string sql, ComboBox combo, string valueMember, string displayMember)
        {
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter(sql, Con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    combo.DataSource = dt;
                    combo.ValueMember = valueMember;
                    combo.DisplayMember = displayMember;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load dữ liệu ComboBox: " + ex.Message);
            }
        }

        public static string ChuyenSoSangChu(string sNumber)
        {
            sNumber = sNumber.Split(',')[0]; // Bỏ phần sau dấu ,
            sNumber = sNumber.Replace(".", ""); // Bỏ dấu chấm nếu có
            sNumber = sNumber.Replace(",", ""); // Bỏ dấu phẩy nếu nhập kiểu 1,000,000

            int mLen, mDigit;
            string mTemp = "";
            string[] mNumText;
            mNumText = "không;một;hai;ba;bốn;năm;sáu;bảy;tám;chín".Split(';');
            mLen = sNumber.Length - 1;

            for (int i = 0; i <= mLen; i++)
            {
                mDigit = Convert.ToInt32(sNumber.Substring(i, 1));
                mTemp = mTemp + " " + mNumText[mDigit];

                if (mLen == i)
                    break;

                switch ((mLen - i) % 9)
                {
                    case 0:
                        mTemp = mTemp + " tỷ";
                        break;
                    case 6:
                        mTemp = mTemp + " triệu";
                        break;
                    case 3:
                        mTemp = mTemp + " nghìn";
                        break;
                    default:
                        switch ((mLen - i) % 3)
                        {
                            case 2:
                                mTemp = mTemp + " trăm";
                                break;
                            case 1:
                                mTemp = mTemp + " mươi";
                                break;
                        }
                        break;
                }
            }

            mTemp = mTemp.Replace("không mươi không ", "");
            mTemp = mTemp.Replace("không mươi không", "");
            mTemp = mTemp.Replace("không mươi ", "linh ");
            mTemp = mTemp.Replace("mươi không", "mươi");
            mTemp = mTemp.Replace("một mươi", "mười");
            mTemp = mTemp.Replace("mươi bốn", "mươi tư");
            mTemp = mTemp.Replace("linh bốn", "linh tư");
            mTemp = mTemp.Replace("mươi năm", "mươi lăm");
            mTemp = mTemp.Replace("mươi một", "mươi mốt");
            mTemp = mTemp.Replace("mười năm", "mười lăm");

            mTemp = mTemp.Trim();
            mTemp = mTemp.Substring(0, 1).ToUpper() + mTemp.Substring(1) + " đồng";
            return mTemp;
        }

        public static string GetMaLoaiKHTheoTien(decimal soTienMua)
        {
            using (var context = new LKMTdbContext())
            {
                return context.LoaiKH
                    .Where(lk =>
                        soTienMua < 50000000 ? lk.TenLoai == "Thường" :
                        soTienMua <= 80000000 ? lk.TenLoai == "Đặc biệt" :
                        lk.TenLoai == "VIP"
                    )
                    .Select(lk => lk.MaLoaiKH)
                    .FirstOrDefault();
            }
        }

        public static void AutoBackupCuonChieu(string currentUsername, int soNgayGiu = 7)
        {
            try
            {
                using (var context = new LKMTdbContext())
                {
                    string dbName = context.Database.GetDbConnection().Database;
                    string backupFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "AutoBackups");

                    if (!Directory.Exists(backupFolder))
                        Directory.CreateDirectory(backupFolder);

                    string timestamp = System.DateTime.Now.ToString("yyyyMMdd_HHmmss");
                    string fileName = $"backup_{timestamp}.bak";
                    string filePath = Path.Combine(backupFolder, fileName);

                    string sqlBackup = $@"BACKUP DATABASE [{dbName}]
                                        TO DISK = N'{filePath}'
                                        WITH FORMAT, INIT, NAME = 'Auto Backup of {dbName}';";

                    context.Database.ExecuteSqlRaw(sqlBackup);

                    var files = Directory.GetFiles(backupFolder, "*.bak")
                                         .OrderByDescending(File.GetCreationTime)
                                         .ToList();

                    for (int i = soNgayGiu; i < files.Count; i++)
                    {
                        File.Delete(files[i]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi backup tự động: " + ex.Message);
            }
        }
    }
}
