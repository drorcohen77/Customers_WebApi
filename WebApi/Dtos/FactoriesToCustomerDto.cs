using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Dtos
{
    public class FactoriesToCustomerDto
    {
        public int? GroupCode { set; get; }
        public int? FactoryCode { set; get; }
        public string CustomerId { set; get; } = string.Empty;
    }
}