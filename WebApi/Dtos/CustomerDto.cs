using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Dtos
{
    public class CustomerDto
    {
        public string CustomerId { set; get; } = string.Empty;
        public string Name { set; get; } = string.Empty;
        public string Address { set; get; } = string.Empty;
        public string Phone { set; get; } = string.Empty;
        public int FactoryCode { set; get; }
        public int GroupCode { set; get; }
    }
}