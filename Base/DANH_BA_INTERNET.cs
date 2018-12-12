namespace Billing.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DANH_BA_INTERNET")]
    public partial class DANH_BA_INTERNET
    {
        public string MA_KH { get; set; }
        public string MST { get; set; }
        public string MA_CBT { get; set; }
        public string TEN_TT { get; set; }
        public string DIACHI_TT { get; set; }
        public string PHUONG_ID { get; set; }
        public int KHLON_ID { get; set; }
        public int DONVI_ID { get; set; }
        public string MA_TB { get; set; }
        public int CUOC_YTE { get; set; }
        public int CUOC_DV { get; set; }
        public int CUOC_TB { get; set; }
        public int THUTU_IN { get; set; }
        public int PHANLOAIKH_ID { get; set; }
        public int TRANGTHAITB_ID { get; set; }
        public string SOMAY_TN { get; set; }
        public int LOAITB_ID { get; set; }
        public int PHUONGTHUC { get; set; }
        public int NGAY_TB { get; set; }
        public DateTime NGAY_SD { get; set; }
        public DateTime NGAY_CAT { get; set; }
        public DateTime NGAY_KP { get; set; }
        public DateTime NGAY_TD { get; set; }
        public int DOITUONG_ID { get; set; }
        public string MA_TUYEN { get; set; }
        public string MA_TT { get; set; }
        public string DICHVUVT_ID { get; set; }
        public int DATMOI_TRONGTHANG { get; set; }
        public string SO_DT { get; set; }
    }
}
