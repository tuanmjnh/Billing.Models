namespace Billing.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Config
    {
        public System.Collections.Generic.List<Connection> connection { get; set; }
    }
    [Table("connection")]
    public partial class Connection
    {
        public int id { get; set; }
        public string name { get; set; }
        public string value { get; set; }
        public string type_name { get; set; }
        public string providerName { get; set; }
    }
}
