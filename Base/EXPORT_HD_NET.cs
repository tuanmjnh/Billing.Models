namespace Billing.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("EXPORT_HD_NET")]
    public partial class EXPORT_HD_NET : DB_THANHTOAN_BKN
    {
        public Guid NET_ID { get; set; }
        public Guid DBKH_ID { get; set; }
        public DateTime TIME_BILL { get; set; }
        [StringLength(512)]
        public string TOC_DO { get; set; }
        public int? TT_THANG { get; set; }
        [StringLength(128)]
        public string TBTHG { get; set; }
        public int? NGAY_TB { get; set; }
        public int? NGAY_TB_PTTB { get; set; }
        public int? GOICUOCID { get; set; }
        public int? TH_THANG { get; set; }
        public int? TH_HUY { get; set; }
        public int? DUPECOUNT { get; set; }
        public int? ISDATMOI { get; set; }
        public int? ISHUY { get; set; }
        public int? ISTTT { get; set; }
        public int? ISDATCOC { get; set; }
        public int GIAM_TRU { get; set; }
        public decimal CUOC_IP { get; set; }
        public decimal CUOC_EMAIL { get; set; }
        public decimal CUOC_DATA { get; set; }
        public decimal CUOC_SD { get; set; }
        public decimal CUOC_TB { get; set; }
        public decimal TONG_TTT { get; set; }
        public decimal TONG_DC { get; set; }
        public decimal TONG_IN { get; set; }
        public decimal TONG { get; set; }
        public decimal VAT { get; set; }
        public decimal TONGCONG { get; set; }
        //PTTB
        public DateTime? NGAY_DKY { get; set; }
        public DateTime? NGAY_CAT { get; set; }
        public DateTime? NGAY_HUY { get; set; }
        public DateTime? NGAY_CHUYEN { get; set; }
        //KTNV
        public DateTime? NGAY_SD { get; set; }
        public DateTime? NGAY_KHOA { get; set; }
        public DateTime? NGAY_MO { get; set; }
        public DateTime? NGAY_KT { get; set; }
    }
}
