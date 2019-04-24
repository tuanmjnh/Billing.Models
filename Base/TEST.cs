namespace Billing.Models {
    using System.ComponentModel.DataAnnotations.Schema; 
    using System.ComponentModel.DataAnnotations; 
    using System; 

    [Table ("TEST")]
    public partial class TEST {
        [Dapper.Contrib.Extensions.ExplicitKey]
        public string ID {get; set; }
        public string NAME {get; set; }
        public int LEVELS {get; set; }
        public decimal MONEY {get; set; }
        public DateTime? TIME {get; set; }
    }
}