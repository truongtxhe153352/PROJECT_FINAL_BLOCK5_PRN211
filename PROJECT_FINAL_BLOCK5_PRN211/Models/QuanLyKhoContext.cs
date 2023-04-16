using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

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
            Console.WriteLine(Directory.GetCurrentDirectory());
            IConfiguration config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", true, true)
            .Build();
            var strConn = config["ConnectionStrings:QuanLyKho"];
            optionsBuilder.UseSqlServer(strConn);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TbCategory>(entity =>
            {
                entity.HasKey(e => e.Catid)
                    .HasName("PK__TbCatego__6A1D86D2C5135C35");

                entity.ToTable("TbCategory");

                entity.Property(e => e.Catid).ValueGeneratedNever();

                entity.Property(e => e.Catname).HasMaxLength(50);
            });

            modelBuilder.Entity<TbCustomer>(entity =>
            {
                entity.HasKey(e => e.Cid)
                    .HasName("PK__TbCustom__C1FFD8618D0C8F27");

                entity.ToTable("TbCustomer");

                entity.Property(e => e.Cid).ValueGeneratedNever();

                entity.Property(e => e.Cname).HasMaxLength(100);

                entity.Property(e => e.Cphone).HasMaxLength(20);
            });

            modelBuilder.Entity<TbOrder>(entity =>
            {
                entity.HasKey(e => e.Orderid)
                    .HasName("PK__TbOrder__C39F40170B41C7B4");

                entity.ToTable("TbOrder");

                entity.Property(e => e.Orderid).ValueGeneratedNever();

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
                    .HasName("PK__TbProduc__C5705938132241C3");

                entity.ToTable("TbProduct");

                entity.Property(e => e.Pid).ValueGeneratedNever();

                entity.Property(e => e.Pname).HasMaxLength(100);

                entity.HasOne(d => d.Cate)
                    .WithMany(p => p.TbProducts)
                    .HasForeignKey(d => d.Cateid);
            });

            modelBuilder.Entity<TbUser>(entity =>
            {
                entity.HasKey(e => e.Userid)
                    .HasName("PK__TbUser__1797D024A8B4D76D");

                entity.ToTable("TbUser");

                entity.Property(e => e.Userid).ValueGeneratedNever();

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
