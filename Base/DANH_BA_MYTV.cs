namespace Billing.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DANH_BA_MYTV")]
    public partial class DANH_BA_MYTV
    {
        public string MA_TB { get; set; }
        public string TEN_TT { get; set; }
        public string DIACHI_TT { get; set; }
        public string SO_DT { get; set; }
        public int TRANGTHAITB_ID { get; set; }
        public int DONVI_ID { get; set; }
        public int DOITUONG_ID { get; set; }
        public string MST { get; set; }
        public string PHUONG_ID { get; set; }
        public string MA_CBT { get; set; }
        public string MA_TUYEN { get; set; }
        public string MA_TT { get; set; }
        public string MA_KH { get; set; }
        public int DATMOI_TRONGTHANG { get; set; }
        public string DICHVUVT_ID { get; set; }
        public DateTime NGAY_SD { get; set; }
        public DateTime NGAY_CAT { get; set; }
        public DateTime NGAY_KP { get; set; }
        public DateTime NGAY_TD { get; set; }
    }
}
