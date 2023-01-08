using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Factory
    {
        [Key]
        public int FactoryCode { set; get; }
        public string FactoryName { set; get; } = string.Empty;
        
        [ForeignKey("Group")]
        public int GroupCode { set; get; }
        public Group? Group { get; set; }

        public IList<FactoriesToCustomer> FactoriesToCustomer { get; set; }
    }
}