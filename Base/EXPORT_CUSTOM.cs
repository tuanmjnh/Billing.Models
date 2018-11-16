namespace Billing.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("EXPORT_CUSTOM")]
    public partial class EXPORT_CUSTOM
    {
        [Dapper.Contrib.Extensions.ExplicitKey]
        public Guid ID { get; set; }
        [StringLength(128)]
        public string NAME { get; set; }
        [StringLength(128)]
        public string TABLE_NAME { get; set; }
        [StringLength(1024)]
        public string TABLE_LIST { get; set; }
        public string QUERY_CREATE { get; set; }
        public string QUERY_SELECT { get; set; }
        public string QUERY_INSERT { get; set; }
        public string QUERY_END { get; set; }
        [StringLength(2048)]
        public string CONDITION { get; set; }
        [StringLength(500)]
        public string CONNECTION { get; set; }
        [StringLength(50)]
        public string CONNECTION_NAME { get; set; }
        [StringLength(50)]
        public string CONNECTION_TYPE { get; set; }
        [StringLength(50)]
        public string TYPE_NAME { get; set; }
        public int FLAG { get; set; }
    }
}