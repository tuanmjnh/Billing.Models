namespace Billing.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("DB_THANHTOAN_BKN")]
    public partial class DB_THANHTOAN_BKN
    {
        [Dapper.Contrib.Extensions.ExplicitKey]
        public Guid ID { get; set; }
        public int TYPE_BILL { get; set; }
        public int KHACHHANG_ID { get; set; }
        public string MA_KH { get; set; }
        public int THANHTOAN_ID { get; set; }
        public string MA_TT { get; set; }
        //public string ACCOUNT { get; set; }
        public int THUEBAO_ID { get; set; }
        public string MA_TB { get; set; }
        public string TEN_TT { get; set; }
        public string DIACHI_TT { get; set; }
        public string DIENTHOAI { get; set; }
        public string MS_THUE { get; set; }
        public string BANKNUMBER { get; set; }
        public string MA_DVI { get; set; }
        public int DONVI_ID { get; set; }
        public int DONVI_QL_ID { get; set; }
        public int DONVITC_ID { get; set; }
        public string MA_CBT { get; set; }
        public string MA_TUYEN { get; set; }
        public string CUSTCATE { get; set; }
        public string STK { get; set; }
        public int MA_DT { get; set; }
        public int? KHLON_ID { get; set; }
        public int? LOAIKH_ID { get; set; }
        public int TH_SD { get; set; }
        public int ISNULL { get; set; }
        public int ISNULLMT { get; set; }
        public int FIX { get; set; }
        public int FLAG { get; set; }
    }
}
