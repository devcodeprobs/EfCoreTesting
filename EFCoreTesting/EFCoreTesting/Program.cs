using System;

namespace EFCoreTesting
{
    using EFCoreTesting.CrmDb;
    using EFCoreTesting.MandantDb;
    using EFCoreTesting.PcmDb;

    class Program
    {
        static void Main(string[] args)
        {
            MandantdbCoreDbContext mandantdbCoreDbContext = new MandantdbCoreDbContext();
            PcmdbCoreDbContext pcmdbCoreDbContext = new PcmdbCoreDbContext();
            CrmdbCoreDbContext crmdbCoreDbContext = new CrmdbCoreDbContext();


           IRepository repository = new Repository(mandantdbCoreDbContext, crmdbCoreDbContext, pcmdbCoreDbContext);

            foreach (var record in repository.GetPcmRecords())
            {
                Console.WriteLine(record.BsBesteller);
            }
        }
    }
}
