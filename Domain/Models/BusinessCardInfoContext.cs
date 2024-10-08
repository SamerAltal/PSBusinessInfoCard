using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PSBusinessInfoCard.Domain.Models
{
    public partial class BusinessCardInfoContext : DbContext
    {
        public BusinessCardInfoContext()
        {
        }

        public BusinessCardInfoContext(DbContextOptions<BusinessCardInfoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BusinessCardDetail> BusinessCardDetails { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=SAMER-ALTAL;Database=BusinessCardInfo;User Id=ESKA/S.AlTal;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BusinessCardDetail>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DateofBirth).HasColumnType("date");

                entity.Property(e => e.Gender).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Phone).HasColumnType("numeric(18, 0)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
