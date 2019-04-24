namespace Billing.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("HD_MERGIN")]
    public partial class HD_MERGIN
    {
        [Dapper.Contrib.Extensions.ExplicitKey]
        public Guid ID { get; set; }
        public int KYHOADON { get; set; }
        public Guid HD_ID { get; set; }
        public Guid DBKH_ID { get; set; }
        public int TYPE_BILL { get; set; }
        public int? APP_ID { get; set; }
        [StringLength(256)]
        public string MA_TT_HNI { get; set; }
        [StringLength(128)]
        public string MA_DVI { get; set; }
        [StringLength(256)]
        public string ACC_NET { get; set; }
        [StringLength(256)]
        public string ACC_TV { get; set; }
        [StringLength(256)]
        public string SO_DD { get; set; }
        [StringLength(256)]
        public string SO_CD { get; set; }
        public decimal TONG_CD { get; set; }
        public decimal TONG_DD { get; set; }
        public decimal TONG_NET { get; set; }
        public decimal TONG_TV { get; set; }
        public decimal CUOC_KTHUE { get; set; }
        public decimal GIAM_TRU { get; set; }
        public decimal TONG_TTT { get; set; }
        public decimal TONG_DC { get; set; }
        public decimal TONG_IN { get; set; }
        public decimal TONG { get; set; }
        public decimal VAT { get; set; }
        public decimal TONGCONG { get; set; }
        [StringLength(256)]
        public string KIEU { get; set; }
        public int GHEP { get; set; }
        public int MA_IN { get; set; }
        public int KIEU_TT { get; set; }
        public int DUPE_FLAG { get; set; }
        public int FLAG { get; set; }
    }
}
