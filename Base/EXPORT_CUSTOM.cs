namespace Billing.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("EXPORT_CUSTOM")]
    public partial class EXPORT_CUSTOM
    {
        [Dapper.Contrib.Extensions.ExplicitKey]
        public String ID { get; set; }
        public string NAME { get; set; }
        public string TABLE_NAME { get; set; }
        public string TABLE_LIST { get; set; }
        public string QUERY_CREATE { get; set; }
        public string QUERY_SELECT { get; set; }
        public string QUERY_INSERT { get; set; }
        public string QUERY_END { get; set; }
        public string CONDITION { get; set; }
        public string CONNECTION { get; set; }
        public string CONNECTION_NAME { get; set; }
        public string CONNECTION_TYPE { get; set; }
        public string TYPE_NAME { get; set; }
        public int FLAG { get; set; }
    }
}