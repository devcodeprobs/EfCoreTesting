using System;
using System.Collections.Generic;

namespace EFCoreTesting.MandantDb
{
    public partial class TblBsInboxArchiv
    {
        public int BsInboxIdArchiv { get; set; }
        public int BsInboxId { get; set; }
        public string BsNr { get; set; }
        public int? BsMid { get; set; }
        public int? BsLid { get; set; }
        public string BsKostenstelle { get; set; }
        public string BsKreditor { get; set; }
        public DateTime? BsBestelldatum { get; set; }
        public DateTime? BsLieferdatum { get; set; }
        public string BsBesteller { get; set; }
        public string BsCurCode { get; set; }
        public bool? BsOrderDirty { get; set; }
        public DateTime? SysAddDat { get; set; }
        public DateTime? SysAddDatArchiv { get; set; }
        public Guid? MediGuid { get; set; }
        public int? BsBestellerPsId { get; set; }
        public string BsBemerkung { get; set; }
        public string BsKundenNr { get; set; }
        public int? BsMaAdrIdLa { get; set; }
        public int? BsMaAdrIdRa { get; set; }
        public int? BsKdNrId { get; set; }
        public int? IstTest { get; set; }
        public string BsBelegArt { get; set; }
        public string BuchungskreisKurzBez { get; set; }
        public string Abteilung { get; set; }
        public string WarenempfaengerKurzBez { get; set; }
        public string GlnDerLieferadresse { get; set; }
    }
}
