using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhKienMayTinh.Data
{
    public class LKMTdbContext : DbContext
    {
        public DbSet<HangHoa> HangHoa { get; set; }
        public DbSet<LoaiHH> LoaiHH { get; set; }
        public DbSet<NhaCungCap> NhaCungCap { get; set; }
        public DbSet<NhanVien> NhanVien { get; set; }
        public DbSet<ChamCong> ChamCong { get; set; }
        public DbSet<KhachHang> KhachHang { get; set; }
        public DbSet<LoaiKH> LoaiKH { get; set; }
        public DbSet<HoaDon> HoaDon { get; set; }
        public DbSet<CTHD> CTHD { get; set; }
        public DbSet<PhieuNhap> PhieuNhap { get; set; }
        public DbSet<CTPhieuNhap> CTPhieuNhap { get; set; }
        public DbSet<PhieuBaoHanh> PhieuBaoHanh { get; set; }
        public DbSet<TaiKhoan> TaiKhoan { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["LinhKienMayTinhConnection"].ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CTHD>()
                .HasKey(c => new { c.MaHD, c.MaHH });
            modelBuilder.Entity<CTHD>()
                .HasOne(c => c.HoaDon).WithMany(n => n.CTHD).HasForeignKey(c => c.MaHD);
            modelBuilder.Entity<CTHD>()
                .HasOne(c => c.HangHoa).WithMany(n => n.CTHD).HasForeignKey(c => c.MaHH);               

            modelBuilder.Entity<CTPhieuNhap>()
                .HasKey(c => new { c.MaPhieu, c.MaHH });
            modelBuilder.Entity<CTPhieuNhap>()
               .HasOne(c => c.PhieuNhap).WithMany(n => n.CTPhieuNhap).HasForeignKey(c => c.MaPhieu);
            modelBuilder.Entity<CTPhieuNhap>()
                .HasOne(c => c.HangHoa).WithMany(n => n.CTPhieuNhap).HasForeignKey(c => c.MaHH);

            modelBuilder.Entity<ChamCong>()
                .HasKey(c => new { c.MaChamCong });
            modelBuilder.Entity<ChamCong>()
                .HasOne(c => c.NhanVien).WithMany(n => n.ChamCong).HasForeignKey(c => c.MaNV);

            modelBuilder.Entity<HangHoa>()
                .HasKey(c => new { c.MaHH });
            modelBuilder.Entity<HangHoa>()
              .HasOne(c => c.LoaiHH).WithMany(n => n.HangHoa).HasForeignKey(c => c.MaLoaiHH);

            modelBuilder.Entity<HoaDon>()
                .HasKey(c => new { c.MaHD });
            modelBuilder.Entity<HoaDon>()
                .HasOne(c => c.NhanVien).WithMany(n => n.HoaDon).HasForeignKey(c => c.MaNV);
            modelBuilder.Entity<HoaDon>()
                .HasOne(c => c.KhachHang).WithMany(n => n.HoaDon).HasForeignKey(c => c.MaKH);

            modelBuilder.Entity<KhachHang>()
                .HasKey(c => new { c.MaKH });
            modelBuilder.Entity<KhachHang>()
                .HasOne(c => c.LoaiKH).WithMany(n => n.KhachHang).HasForeignKey(c => c.MaLoaiKH);

            modelBuilder.Entity<LoaiKH>()
                .HasKey(c => new { c.MaLoaiKH });

            modelBuilder.Entity<LoaiHH>()
                .HasKey(c => new { c.MaLoaiHH });

            modelBuilder.Entity<NhaCungCap>()
                .HasKey(c => new { c.MaNCC });

            modelBuilder.Entity<NhanVien>()
                .HasKey(c => new { c.MaNV });

            modelBuilder.Entity<PhieuBaoHanh>()
               .HasKey(c => new { c.MaPhieu });
            modelBuilder.Entity<PhieuBaoHanh>()
               .HasOne(c => c.NhanVien).WithMany(n => n.PhieuBaoHanh).HasForeignKey(c => c.MaNV);
            modelBuilder.Entity<PhieuBaoHanh>()
               .HasOne(c => c.HangHoa).WithMany(n => n.PhieuBaoHanh).HasForeignKey(c => c.MaHH);
            modelBuilder.Entity<PhieuBaoHanh>()
               .HasOne(c => c.KhachHang).WithMany(n => n.PhieuBaoHanh).HasForeignKey(c => c.MaKH);

            modelBuilder.Entity<PhieuNhap>()
                .HasKey(c => new { c.MaPhieu });
            modelBuilder.Entity<PhieuNhap>()
                .HasOne(c => c.NhanVien).WithMany(n => n.PhieuNhap).HasForeignKey(c => c.MaNV);
            modelBuilder.Entity<PhieuNhap>()
                .HasOne(c => c.NhaCungCap).WithMany(n => n.PhieuNhap).HasForeignKey(c => c.MaNCC);

            modelBuilder.Entity<TaiKhoan>()
                .HasKey(c => new { c.Username });

            base.OnModelCreating(modelBuilder);
        }
    }
}
