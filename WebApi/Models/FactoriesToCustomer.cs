using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Models
{
    [Keyless]
    public class FactoriesToCustomer
    {
        [ForeignKey("Group")]
        public int GroupCode { set; get; }
        public Group? Group { get; set; }

        [ForeignKey("Factory")]
        public int FactoryCode { set; get; }
        public Factory? Factory { get; set; }

        [ForeignKey("Customer")]
        public string CustomerId { set; get; } = string.Empty;
        public Customer? Customer { get; set; }
    }
}