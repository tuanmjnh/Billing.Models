namespace Billing.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("COMMENT_BILL")]
    public partial class COMMENT_BILL
    {
        [Dapper.Contrib.Extensions.ExplicitKey]
        public Guid ID { get; set; }
        public int KYHOADON { get; set; }
        [StringLength(256)]
        public string MA_TT { get; set; }
        [StringLength(128)]
        public string ROOT_ID { get; set; }
        [StringLength(128)]
        public string PARENT_ID { get; set; }
        public string PARENTS_ID { get; set; }
        public int LEVELS { get; set; }
        public string CONTENTS { get; set; }
        [StringLength(256)]
        public string CREATEDBY { get; set; }
        public DateTime CREATEDAT { get; set; }
        [StringLength(256)]
        public string UPDATEDBY { get; set; }
        public DateTime? UPDATEDAT { get; set; }
        public int FLAG { get; set; }
    }
}
