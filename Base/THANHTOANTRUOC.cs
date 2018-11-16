﻿namespace Billing.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("THANHTOANTRUOC")]
    public partial class THANHTOANTRUOC
    {
        [Dapper.Contrib.Extensions.ExplicitKey]
        public Guid ID { get; set; }
        public int TYPE_BILL { get; set; }
        public DateTime TIME_BILL { get; set; }
        [StringLength(256)]
        public string ID_TTT { get; set; }
        [StringLength(256)]
        public string ACCOUNT { get; set; }
        [StringLength(256)]
        public string MA_TB { get; set; }
        [StringLength(256)]
        public string SO_MAY { get; set; }
        public int DVVT_ID { get; set; }
        public int TOCDO_ID { get; set; }
        public int GOICUOC_ID { get; set; }
        public decimal TIENHANMUC { get; set; }
        public decimal TONGHANMUC { get; set; }
        public int TT { get; set; }
        [StringLength(128)]
        public string KHOANTIEN { get; set; }
        public int THANG { get; set; }
        public int NAM { get; set; }
        public DateTime? NGAY_BD { get; set; }
        public DateTime? NGAY_KT { get; set; }
        public decimal SODU { get; set; }
        public int ID_CV { get; set; }
        public DateTime? NGAY_TT { get; set; }
        public int NGUONDL { get; set; }
        public int CUOC_FIX { get; set; }
        [StringLength(512)]
        public string TEN_DVVT { get; set; }
        public int SOTHANG { get; set; }
        public decimal THUC_TRU { get; set; }
        public DateTime? NGAY_SD { get; set; }
        [StringLength(1024)]
        public string GHI_CHU { get; set; }
        public decimal TONG { get; set; }
        public decimal EXTRA_TONG { get; set; }
        public decimal SODU_TONG { get; set; }
        public int FLAG { get; set; }
    }
}