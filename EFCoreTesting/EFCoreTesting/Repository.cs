namespace EFCoreTesting
{
    using System.Collections.Generic;
    using System.Linq;

    using EFCoreTesting.CrmDb;
    using EFCoreTesting.MandantDb;
    using EFCoreTesting.PcmDb;

    public class Repository : IRepository
    {

        private readonly MandantdbCoreDbContext mandantdbCoreDbContext;

        private readonly CrmdbCoreDbContext crmdbCoreDbContext;

        private readonly PcmdbCoreDbContext pcmdbCoreDbContext;

        public Repository(MandantdbCoreDbContext mandantdbCoreDbContext, CrmdbCoreDbContext crmdbCoreDbContext, PcmdbCoreDbContext pcmdbCoreDbContext)
        {
            this.mandantdbCoreDbContext = mandantdbCoreDbContext;
            this.crmdbCoreDbContext = crmdbCoreDbContext;
            this.pcmdbCoreDbContext = pcmdbCoreDbContext;
        }

        // This method throws a "The value can not be null. \ r \ nParameterName: entityType" exception
        public IEnumerable<XRecord> GetPcmRecords()
        {
            var query = from bs in this.mandantdbCoreDbContext.TblBsInboxArchiv 
                        join ld in this.pcmdbCoreDbContext.TblLieferantDict on bs.BsLid equals ld.Lid
                        join mbs in this.crmdbCoreDbContext.TblMaBelegStatus on bs.BsInboxId equals mbs.MaBsid into mbsGrps
                        from mbs in mbsGrps.DefaultIfEmpty()
                        select new XRecord()
                                   {
                                       BsInboxId =  bs.BsInboxId,
                                       BsBestelldatum = bs.BsBestelldatum,
                                       BsBesteller = bs.BsBesteller,
                                       BsLieferdatum = bs.BsLieferdatum,
                                       LiefMatch = ld.LiefMatch,
                                       MaBsDatPcmsent = mbs.MaBsDatPcmsent
                                   };
            return query.ToList();
        }
    }
}