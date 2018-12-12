namespace Billing.Models
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("DATCOC")]
    public partial class DATCOC
    {
        public int kyhoadon { get; set; }
        public int rkm_id { get; set; }
        public string ma_tb { get; set; }
        public int dichvuvt_id { get; set; }
        public int loaitb_id { get; set; }
        public int congvan_id { get; set; }
        public int nhom_datcoc_id { get; set; }
        public int cuoc_dc { get; set; }
        public int tyle_tb { get; set; }
        public int tyle_sd { get; set; }
        public int tien_tb { get; set; }
        public int tien_sd { get; set; }
        public int tinh_dt { get; set; }
        public int nguonkm_id { get; set; }
        public string may_cn { get; set; }
        public DateTime ngay_cn { get; set; }
        public string nguoi_cn { get; set; }
        public string ghichu { get; set; }
        public int thuebao_id { get; set; }
        public int kieu_dc { get; set; }
        public int cuoc_tb { get; set; }
        public int cuoc_sd { get; set; }
        public int tt_id { get; set; }
        public int tien_td_data { get; set; }
        public int kieuchot { get; set; }
        public int chitietkm_id { get; set; }
        public int tronthang { get; set; }
        public int tien_td_ca { get; set; }
        public int tongtien_dc { get; set; }
        public int thang_bd { get; set; }
        public int thang_kt { get; set; }
        public int thang_bd_mg { get; set; }
        public int thang_kt_mg { get; set; }
        public int tien_data_1thang { get; set; }
        public int goi_neo_id { get; set; }
        public int songay { get; set; }
    }
}
