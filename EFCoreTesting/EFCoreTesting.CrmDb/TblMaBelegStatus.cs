using System;

namespace EFCoreTesting.CrmDb
{
    public class TblMaBelegStatus
    {
        public int MaDataId { get; set; }
        public string MaBsNr { get; set; }
        public string MaBsKred { get; set; }
        public DateTime? MaBsDatMaDelivery { get; set; }
        public DateTime? MaBsDatPcmreceived { get; set; }
        public DateTime? MaBsDatPcmsent { get; set; }
        public DateTime? MaBsDatLfConfirmed { get; set; }
        public DateTime? MaBsDatLfdelivery { get; set; }
        public DateTime? MaLsDatPcmreceived { get; set; }
        public DateTime? MaLsDatPcmsent { get; set; }
        public DateTime? MaReDatPcmreceived { get; set; }
        public DateTime? MaReDatPcmsent { get; set; }
        public DateTime SysAddDat { get; set; }
        public int? Mid { get; set; }
        public int? MaBsid { get; set; }
        public int? MaLsid { get; set; }
        public int? MaReid { get; set; }
        public Guid? MediGuid { get; set; }
        public string BsKprotoPath { get; set; }
        public string LsKprotoPath { get; set; }
        public string ReKprotoPath { get; set; }
        public int? Lid { get; set; }
        public int? MaOrid { get; set; }
        public DateTime? MaOrdatPcmsent { get; set; }
        public string InterneAuftragsnummer { get; set; }
    }
}
