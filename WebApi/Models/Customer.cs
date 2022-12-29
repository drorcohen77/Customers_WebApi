using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Customer
    {
        [Key]
        public string CustomerId { set; get; } = string.Empty;
        public string Name { set; get; } = string.Empty;
        public string Address { set; get; } = string.Empty;
        public string Phone { set; get; } = string.Empty;
    }
}