using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EFCoreTesting.MandantDb
{
    public partial class MandantdbCoreDbContext : DbContext
    {
        public virtual DbSet<TblBsInboxArchiv> TblBsInboxArchiv { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer(@"Data Source=ESERVER02\SERVER02;Initial Catalog=MandantDB;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblBsInboxArchiv>(entity =>
            {
                entity.HasKey(e => e.BsInboxIdArchiv);

                entity.ToTable("tblBsInbox_Archiv");

                entity.HasIndex(e => e.MediGuid);

                entity.Property(e => e.BsInboxIdArchiv).HasColumnName("BsInboxID_Archiv");

                entity.Property(e => e.Abteilung).HasMaxLength(30);

                entity.Property(e => e.BsBelegArt).HasMaxLength(10);

                entity.Property(e => e.BsBemerkung).HasMaxLength(255);

                entity.Property(e => e.BsBestelldatum).HasColumnType("datetime");

                entity.Property(e => e.BsBesteller).HasMaxLength(100);

                entity.Property(e => e.BsCurCode).HasColumnType("char(3)");

                entity.Property(e => e.BsInboxId).HasColumnName("BsInboxID");

                entity.Property(e => e.BsKostenstelle).HasMaxLength(50);

                entity.Property(e => e.BsKreditor).HasMaxLength(50);

                entity.Property(e => e.BsKundenNr).HasMaxLength(50);

                entity.Property(e => e.BsLid).HasColumnName("BsLID");

                entity.Property(e => e.BsLieferdatum).HasColumnType("datetime");

                entity.Property(e => e.BsMid).HasColumnName("BsMID");

                entity.Property(e => e.BsNr).HasMaxLength(25);

                entity.Property(e => e.BuchungskreisKurzBez).HasMaxLength(15);

                entity.Property(e => e.GlnDerLieferadresse).HasMaxLength(20);

                entity.Property(e => e.SysAddDat).HasColumnType("datetime");

                entity.Property(e => e.SysAddDatArchiv)
                    .HasColumnName("SysAddDat_Archiv")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WarenempfaengerKurzBez).HasMaxLength(15);
            });
        }
    }
}
