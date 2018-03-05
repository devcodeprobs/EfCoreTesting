using Microsoft.EntityFrameworkCore;

namespace EFCoreTesting.CrmDb
{
    public partial class CrmdbCoreDbContext : DbContext
    {
        public virtual DbSet<TblMaBelegStatus> TblMaBelegStatus { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=ESERVER02\SERVER02;Initial Catalog=CRM;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblMaBelegStatus>(entity =>
            {
                entity.HasKey(e => e.MaDataId);

                entity.ToTable("tblMaBelegStatus");

                entity.Property(e => e.MaDataId).HasColumnName("MaDataID");

                entity.Property(e => e.BsKprotoPath)
                    .HasColumnName("BsKProtoPath")
                    .HasMaxLength(100);

                entity.Property(e => e.InterneAuftragsnummer).HasMaxLength(50);

                entity.Property(e => e.Lid).HasColumnName("LID");

                entity.Property(e => e.LsKprotoPath)
                    .HasColumnName("LsKProtoPath")
                    .HasMaxLength(100);

                entity.Property(e => e.MaBsDatLfConfirmed).HasColumnType("datetime");

                entity.Property(e => e.MaBsDatLfdelivery)
                    .HasColumnName("MaBsDatLFDelivery")
                    .HasColumnType("datetime");

                entity.Property(e => e.MaBsDatMaDelivery).HasColumnType("datetime");

                entity.Property(e => e.MaBsDatPcmreceived)
                    .HasColumnName("MaBsDatPCMReceived")
                    .HasColumnType("datetime");

                entity.Property(e => e.MaBsDatPcmsent)
                    .HasColumnName("MaBsDatPCMSent")
                    .HasColumnType("datetime");

                entity.Property(e => e.MaBsKred).HasMaxLength(50);

                entity.Property(e => e.MaBsNr).HasMaxLength(50);

                entity.Property(e => e.MaBsid).HasColumnName("MaBSId");

                entity.Property(e => e.MaLsDatPcmreceived)
                    .HasColumnName("MaLsDatPCMReceived")
                    .HasColumnType("datetime");

                entity.Property(e => e.MaLsDatPcmsent)
                    .HasColumnName("MaLsDatPCMSent")
                    .HasColumnType("datetime");

                entity.Property(e => e.MaLsid).HasColumnName("MaLSId");

                entity.Property(e => e.MaOrdatPcmsent)
                    .HasColumnName("MaORDatPCMSent")
                    .HasColumnType("datetime");

                entity.Property(e => e.MaOrid).HasColumnName("MaORId");

                entity.Property(e => e.MaReDatPcmreceived)
                    .HasColumnName("MaReDatPCMReceived")
                    .HasColumnType("datetime");

                entity.Property(e => e.MaReDatPcmsent)
                    .HasColumnName("MaReDatPCMSent")
                    .HasColumnType("datetime");

                entity.Property(e => e.MaReid).HasColumnName("MaREId");

                entity.Property(e => e.Mid).HasColumnName("MID");

                entity.Property(e => e.ReKprotoPath)
                    .HasColumnName("ReKProtoPath")
                    .HasMaxLength(100);

                entity.Property(e => e.SysAddDat)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });
        }
    }
}
