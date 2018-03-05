namespace EFCoreTesting
{
    using System;

    public class XRecord
    {
        public int BsInboxId { get; set; }
        public DateTime? BsBestelldatum { get; set; }
        public DateTime? BsLieferdatum { get; set; }
        public string BsBesteller { get; set; }
        public string LiefMatch { get; set; }
        public DateTime? MaBsDatPcmsent { get; set; }
    }
}