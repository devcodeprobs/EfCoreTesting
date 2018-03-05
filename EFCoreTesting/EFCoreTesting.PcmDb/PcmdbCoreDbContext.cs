using Microsoft.EntityFrameworkCore;

namespace EFCoreTesting.PcmDb
{
    public partial class PcmdbCoreDbContext : DbContext
    {
        public virtual DbSet<TblLieferantDict> TblLieferantDict { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=ESERVER02\SERVER02;Initial Catalog=PCMDB;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblLieferantDict>(entity =>
            {
                entity.HasKey(e => new { e.Lid, e.Ccode });

                entity.ToTable("tblLieferant_Dict");

                entity.HasIndex(e => e.LiefMatch)
                    .HasName("IX_LieferantDict_LiefMatch");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("MSmerge_index_1061018961")
                    .IsUnique();

                entity.HasIndex(e => e.TsVmpro)
                    .HasName("IX_PCMDB_dbo_tblLieferant_Dict_104");

                entity.HasIndex(e => new { e.Lid, e.LiefMatch, e.Ccode })
                    .HasName("IX_tblLieferant_Dict_100");

                entity.HasIndex(e => new { e.Lid, e.LiefMatch, e.Ccode, e.MitarbeiterDta })
                    .HasName("Missing_IXNC_tblLieferant_Dict_CCode_Mitarbeiter_DTA_05C09");

                entity.HasIndex(e => new { e.Lid, e.LiefMatch, e.LiefBez1, e.Ccode })
                    .HasName("IX_PCMDB_dbo_tblLieferant_Dict_52");

                entity.HasIndex(e => new { e.Lid, e.LiefMatch, e.Ts, e.Ccode })
                    .HasName("IX_tblLieferant_Dict_1");

                entity.HasIndex(e => new { e.Lid, e.LiefMatch, e.LiefBez1, e.LiefBez2, e.LiefBsAsp, e.Uid, e.Steuernummer, e.Ccode })
                    .HasName("IX_PCMDB_dbo_tblLieferant_Dict_156");

                entity.Property(e => e.Lid).HasColumnName("LID");

                entity.Property(e => e.Ccode)
                    .HasColumnName("CCode")
                    .HasColumnType("char(2)");

                entity.Property(e => e.BemExt).HasMaxLength(255);

                entity.Property(e => e.BemNaehrstZst)
                    .HasColumnName("BemNaehrstZSt")
                    .HasMaxLength(500);

                entity.Property(e => e.BemPflege).HasMaxLength(150);

                entity.Property(e => e.Bemerkung).HasMaxLength(500);

                entity.Property(e => e.BsAuswId)
                    .HasColumnName("BsAuswID")
                    .HasDefaultValueSql("((4))");

                entity.Property(e => e.BsFax).HasMaxLength(30);

                entity.Property(e => e.BsFtppath)
                    .HasColumnName("BsFTPPath")
                    .HasMaxLength(150);

                entity.Property(e => e.BsFtppw)
                    .HasColumnName("BsFTPPw")
                    .HasMaxLength(20);

                entity.Property(e => e.BsFtpuser)
                    .HasColumnName("BsFTPUser")
                    .HasMaxLength(20);

                entity.Property(e => e.BsMailBcc)
                    .HasColumnName("BsMailBCC")
                    .HasMaxLength(150);

                entity.Property(e => e.BsMailBetreff).HasMaxLength(150);

                entity.Property(e => e.BsMailCc)
                    .HasColumnName("BsMailCC")
                    .HasMaxLength(150);

                entity.Property(e => e.BsMailSmtptyp)
                    .HasColumnName("BsMailSMTPTyp")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.BsMailTo).HasMaxLength(150);

                entity.Property(e => e.BsOrderType).HasDefaultValueSql("((4))");

                entity.Property(e => e.BsPathInt).HasMaxLength(150);

                entity.Property(e => e.BsTel).HasMaxLength(35);

                entity.Property(e => e.Dsid)
                    .HasColumnName("DSID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IstRechnungssteller)
                    .HasColumnName("istRechnungssteller")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.KdNrLaenge)
                    .HasColumnName("KdNr_Laenge")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LiefBez1).HasMaxLength(100);

                entity.Property(e => e.LiefBez2).HasMaxLength(100);

                entity.Property(e => e.LiefBsAsp)
                    .HasColumnName("LiefBsASP")
                    .HasMaxLength(80);

                entity.Property(e => e.LiefMatch).HasMaxLength(50);

                entity.Property(e => e.MitarbeiterArtikelpflege)
                    .HasColumnName("Mitarbeiter_Artikelpflege")
                    .HasDefaultValueSql("([dbo].[sfnGetPCMAbtLtr]((-4),'de'))");

                entity.Property(e => e.MitarbeiterDatenpflege)
                    .HasColumnName("Mitarbeiter_Datenpflege")
                    .HasDefaultValueSql("([dbo].[sfnGetPCMAbtLtr]((-3),'de'))");

                entity.Property(e => e.MitarbeiterDta).HasColumnName("Mitarbeiter_DTA");

                entity.Property(e => e.MitarbeiterEinkauf)
                    .HasColumnName("Mitarbeiter_Einkauf")
                    .HasDefaultValueSql("((1508))");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Steuernummer).HasMaxLength(20);

                entity.Property(e => e.SysAddDat).HasColumnType("smalldatetime");

                entity.Property(e => e.SysChangeDat).HasColumnType("smalldatetime");

                entity.Property(e => e.Ts)
                    .IsRequired()
                    .HasColumnName("TS")
                    .IsRowVersion();

                entity.Property(e => e.TsStage)
                    .IsRequired()
                    .HasColumnName("TS_Stage")
                    .HasMaxLength(8)
                    .HasDefaultValueSql("(@@dbts)");

                entity.Property(e => e.TsVmpro)
                    .HasColumnName("TS_VMPro")
                    .HasMaxLength(8)
                    .HasDefaultValueSql("(@@dbts)");

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasMaxLength(14);
            });
        }
    }
}
