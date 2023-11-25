using DbShop.Model.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Context
{
    public class DbTravelContext : DbContext
    {
        public DbTravelContext(DbContextOptions<DbTravelContext> options) : base(options)
        { 

        }
        public virtual DbSet<BaiViet> BaiViets { get; set; } = null!;
        public virtual DbSet<ChiTietTour> ChiTietTours { get; set; } = null!;
        public virtual DbSet<DatTour> DatTours { get; set; } = null!;
        public virtual DbSet<DiaDiem> DiaDiems { get; set; } = null!;
        public virtual DbSet<NguoiDung> NguoiDungs { get; set; } = null!;
        public virtual DbSet<TourDuLich> TourDuLiches { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BaiViet>(entity =>
            {
                entity.ToTable("BaiViet");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdNguoiDung).HasColumnName("idNguoiDung");

                entity.Property(e => e.NgayDang)
                    .HasColumnType("date")
                    .HasColumnName("ngayDang");

                entity.Property(e => e.NoiDung)
                    .HasColumnType("text")
                    .HasColumnName("noiDung");

                entity.Property(e => e.TieuDe)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("tieuDe");

                entity.HasOne(d => d.IdNguoiDungNavigation)
                    .WithMany(p => p.BaiViets)
                    .HasForeignKey(d => d.IdNguoiDung)
                    .HasConstraintName("FK__BaiViet__idNguoi__2B3F6F97");
            });

            modelBuilder.Entity<ChiTietTour>(entity =>
            {
                entity.ToTable("ChiTietTour");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdTourDuLich).HasColumnName("idTourDuLich");

                entity.Property(e => e.AnhTour)
                   .HasColumnType("text")
                   .HasColumnName("anhTour");
                entity.Property(e => e.LichTrinh)
                    .HasColumnType("text")
                    .HasColumnName("lichTrinh");
                entity.Property(e => e.ThoiGian)
                    .HasColumnType("text")
                    .HasColumnName("thoiGian");
                entity.Property(e => e.KhoiHanh)
                    .HasColumnType("text")
                    .HasColumnName("khoiHanh");
                entity.Property(e => e.PhuongTien)
                    .HasColumnType("text")
                    .HasColumnName("phuongTien");
                entity.HasOne(d => d.IdTourDuLichNavigation)
                    .WithMany(p => p.ChiTietTours)
                    .HasForeignKey(d => d.IdTourDuLich)
                    .HasConstraintName("FK__ChiTietTo__idTou__31EC6D26");
            });

            modelBuilder.Entity<DatTour>(entity =>
            {
                entity.ToTable("DatTour");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdNguoiDung).HasColumnName("idNguoiDung");

                entity.Property(e => e.IdTourDuLich).HasColumnName("idTourDuLich");

                entity.Property(e => e.NgayDat)
                    .HasColumnType("date")
                    .HasColumnName("ngayDat");

                entity.Property(e => e.SoNguoi).HasColumnName("soNguoi");

                entity.HasOne(d => d.IdNguoiDungNavigation)
                    .WithMany(p => p.DatTours)
                    .HasForeignKey(d => d.IdNguoiDung)
                    .HasConstraintName("FK__DatTour__idNguoi__2E1BDC42");

                entity.HasOne(d => d.IdTourDuLichNavigation)
                    .WithMany(p => p.DatTours)
                    .HasForeignKey(d => d.IdTourDuLich)
                    .HasConstraintName("FK__DatTour__idTourD__2F10007B");
            });

            modelBuilder.Entity<DiaDiem>(entity =>
            {
                entity.ToTable("DiaDiem");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DiaChi)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("diaChi");

                entity.Property(e => e.HinhAnh)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("hinhAnh");

                entity.Property(e => e.MoTa)
                    .HasColumnType("text")
                    .HasColumnName("moTa");

                entity.Property(e => e.TenDiaDiem)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("tenDiaDiem");
            });

            modelBuilder.Entity<NguoiDung>(entity =>
            {
                entity.ToTable("NguoiDung");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Avartar)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("avatar");
                 entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.HoTen)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("hoTen");

                entity.Property(e => e.IsAdmin).HasColumnName("isAdmin");

                entity.Property(e => e.MatKhau)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("matKhau");

                entity.Property(e => e.SoDienThoai)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("soDienThoai");

                entity.Property(e => e.TenDangNhap)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tenDangNhap");
            });

            modelBuilder.Entity<TourDuLich>(entity =>
            {
                entity.ToTable("TourDuLich");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Gia)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("gia");

                entity.Property(e => e.IdDiaDiem).HasColumnName("idDiaDiem");

                entity.Property(e => e.MoTa)
                    .HasColumnType("text")
                    .HasColumnName("moTa");

                entity.Property(e => e.TenTour)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("tenTour");
                entity.Property(e => e.AnhTour)
                 .HasMaxLength(255)
                 .IsUnicode(false)
                 .HasColumnName("anhTour");
                entity.Property(e => e.KhuVuc)
               .HasMaxLength(255)
               .IsUnicode(false)
               .HasColumnName("khuVuc");


                entity.HasOne(d => d.IdDiaDiemNavigation)
                    .WithMany(p => p.TourDuLiches)
                    .HasForeignKey(d => d.IdDiaDiem)
                    .HasConstraintName("FK__TourDuLic__idDia__267ABA7A");
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
