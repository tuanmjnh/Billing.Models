namespace Billing.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("CUOC_FIBERVNN")]
    public partial class CUOC_FIBERVNN
    {
        [Dapper.Contrib.Extensions.ExplicitKey]
        [StringLength(256)]
        public string MA_MEN { get; set; }
        public decimal CUOC { get; set; }
        [StringLength(128)]
        public string THANGNAM { get; set; }
    }
}