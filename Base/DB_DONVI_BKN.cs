namespace Billing.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("DB_DONVI_BKN")]
    public partial class DB_DONVI_BKN
    {
        public int MA_DVI { get; set; }
        public int DONVI_ID { get; set; }
        public int DONVI_QL_ID { get; set; }
        public string TEN_DONVI { get; set; }
    }
}
