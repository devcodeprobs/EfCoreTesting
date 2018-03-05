namespace EFCoreTesting
{
    using System.Collections.Generic;

    using EFCoreTesting.MandantDb;

    public interface IRepository
    {
        IEnumerable<XRecord> GetPcmRecords();
    }
}