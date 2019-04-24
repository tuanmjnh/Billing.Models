namespace Billing.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("DANHBA_GOICUOC_TICHHOP")]
    public partial class DANHBA_GOICUOC_TICHHOP
    {
        [Dapper.Contrib.Extensions.ExplicitKey]
        public Guid ID { get; set; }
        public int KYHOADON { get; set; }
        public string MA_TB { get; set; }
        public string MA_GOI { get; set; }
        public int GOI_ID { get; set; }
        public int LOAITB_ID { get; set; }
        public int DICHVUVT_ID { get; set; }
        public int NHOMTB_ID { get; set; }
        public DateTime? NGAY_DK { get; set; }
        public DateTime? NGAY_KT { get; set; }
        public int DUPE_COUNT { get; set; }
        public int DUPE_FLAG { get; set; }
        public int NO_DUPE { get; set; }
        public int FIX_NGAY_KT { get; set; }
        public int TH_THANG { get; set; }
        public int TH_SO_NGAY { get; set; }
        public int FIX { get; set; }
        public int EXTRA_TYPE { get; set; }
        public string DETAILS { get; set; }
		public string EXTRAS { get; set; }
        public int FLAG { get; set; }
    }
}
