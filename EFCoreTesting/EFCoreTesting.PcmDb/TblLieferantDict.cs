using System;

namespace EFCoreTesting.PcmDb
{
    public class TblLieferantDict
    {
        public int Lid { get; set; }
        public string Ccode { get; set; }
        public string LiefMatch { get; set; }
        public string LiefBez1 { get; set; }
        public string LiefBez2 { get; set; }
        public string LiefBsAsp { get; set; }
        public string Bemerkung { get; set; }
        public string BemExt { get; set; }
        public DateTime? SysAddDat { get; set; }
        public int? SysAddUser { get; set; }
        public DateTime? SysChangeDat { get; set; }
        public int? SysChangeUser { get; set; }
        public byte[] Ts { get; set; }
        public byte[] TsVmpro { get; set; }
        public bool? SysExchange { get; set; }
        public int Dsid { get; set; }
        public Guid Rowguid { get; set; }
        public byte[] TsStage { get; set; }
        public byte? BsOrderType { get; set; }
        public string BsPathInt { get; set; }
        public string BsMailTo { get; set; }
        public string BsMailCc { get; set; }
        public string BsMailBcc { get; set; }
        public string BsMailBetreff { get; set; }
        public string BsFtppath { get; set; }
        public string BsFtpuser { get; set; }
        public string BsFtppw { get; set; }
        public string BsTel { get; set; }
        public string BsFax { get; set; }
        public byte? BsMailFrom { get; set; }
        public byte? BsMailSplit { get; set; }
        public int? BsAuswId { get; set; }
        public byte? KdNrLaenge { get; set; }
        public int? MitarbeiterDatenpflege { get; set; }
        public byte? BsMailSmtptyp { get; set; }
        public string Uid { get; set; }
        public string Steuernummer { get; set; }
        public int? MitarbeiterEinkauf { get; set; }
        public int? MitarbeiterArtikelpflege { get; set; }
        public string BemPflege { get; set; }
        public bool? IstRechnungssteller { get; set; }
        public string BemNaehrstZst { get; set; }
        public int? MitarbeiterDta { get; set; }
        public bool? LfNwZstVererbung { get; set; }
    }
}
