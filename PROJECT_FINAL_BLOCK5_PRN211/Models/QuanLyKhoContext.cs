using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PROJECT_FINAL_BLOCK5_PRN211.Models
{
    public partial class QuanLyKhoContext : DbContext
    {
        public QuanLyKhoContext()
        {
        }

        public QuanLyKhoContext(DbContextOptions<QuanLyKhoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbCategory> TbCategories { get; set; } = null!;
        public virtual DbSet<TbCustomer> TbCustomers { get; set; } = null!;
        public virtual DbSet<TbOrder> TbOrders { get; set; } = null!;
        public virtual DbSet<TbProduct> TbProducts { get; set; } = null!;
        public virtual DbSet<TbUser> TbUsers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=TRUONGTRINH\\SQLEXPRESS;database=QuanLyKho;uid=sa;pwd=123;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TbCategory>(entity =>
            {
                entity.HasKey(e => e.Catid)
                    .HasName("PK__TbCatego__6A1D86D2D37EA2EB");

                entity.ToTable("TbCategory");

                entity.Property(e => e.Catname).HasMaxLength(50);
            });

            modelBuilder.Entity<TbCustomer>(entity =>
            {
                entity.HasKey(e => e.Cid)
                    .HasName("PK__TbCustom__C1FFD861CF0FBA87");

                entity.ToTable("TbCustomer");

                entity.Property(e => e.Cname).HasMaxLength(100);

                entity.Property(e => e.Cphone).HasMaxLength(20);
            });

            modelBuilder.Entity<TbOrder>(entity =>
            {
                entity.HasKey(e => e.Orderid)
                    .HasName("PK__TbOrder__C39F4017ABEDEE43");

                entity.ToTable("TbOrder");

                entity.Property(e => e.Odate).HasColumnType("datetime");

                entity.HasOne(d => d.CidNavigation)
                    .WithMany(p => p.TbOrders)
                    .HasForeignKey(d => d.Cid);

                entity.HasOne(d => d.PidNavigation)
                    .WithMany(p => p.TbOrders)
                    .HasForeignKey(d => d.Pid);
            });

            modelBuilder.Entity<TbProduct>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PK__TbProduc__C5705938517FF882");

                entity.ToTable("TbProduct");

                entity.Property(e => e.Pname).HasMaxLength(100);

                entity.HasOne(d => d.Cate)
                    .WithMany(p => p.TbProducts)
                    .HasForeignKey(d => d.Cateid);
            });

            modelBuilder.Entity<TbUser>(entity =>
            {
                entity.HasKey(e => e.Userid)
                    .HasName("PK__TbUser__1797D024A6D21F38");

                entity.ToTable("TbUser");

                entity.Property(e => e.Fullname).HasMaxLength(100);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(20);

                entity.Property(e => e.Username).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
