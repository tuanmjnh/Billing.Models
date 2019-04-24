namespace Billing.Models
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("DB_KHUYEN_MAI")]
    public partial class DB_KHUYEN_MAI
    {
        public int kyhoadon { get; set; }
        public string ma_tb { get; set; }
        public int dichvuvt_id { get; set; }
        public int loaitb_id { get; set; }
        public int congvan_id { get; set; }
        public int khuyenmai_id { get; set; }
        public int chitietkm_id { get; set; }
        public int cuoc_sd { get; set; }
        public int cuoc_tb { get; set; }
        public decimal tyle_csd { get; set; }
        public decimal tyle_ctb { get; set; }
        public int tien_ck { get; set; }
        public int tien_tb { get; set; }
        public int tien_sd { get; set; }
        public int tang_truoc { get; set; }
        public int tinh_dt { get; set; }
        public int kieu_ck { get; set; }
        public int rkm_id { get; set; }
        public int nguonkm_id { get; set; }
        public int khoanmuctc_mg { get; set; }
        public decimal tyle_tk { get; set; }
        public decimal tyle_tc { get; set; }
        public decimal tyle_tbi { get; set; }
        public decimal tyle_ht { get; set; }
        public string ghichu { get; set; }
        public int tien_td { get; set; }
        public int datcoc_csd { get; set; }
        public string socongvan { get; set; }
        public int thuebao_id { get; set; }
        public int tronthang { get; set; }
        public int songay { get; set; }

    }
}
