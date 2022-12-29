using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Dtos
{
    public class FactoriesToCustomerDto
    {
        public int GroupCode { set; get; }
        public Group? Group { get; set; }
        public int FactoryCode { set; get; }
        public Factory? Factory { get; set; }
        public string CustomerId { set; get; } = string.Empty;
        public Customer? Customer { get; set; }
    }
}