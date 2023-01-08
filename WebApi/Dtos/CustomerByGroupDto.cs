using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Dtos
{
    public class CustomerByGroupDto
    {
        public string CustomerId { set; get; } = string.Empty;
        public string Name { set; get; } = string.Empty;
        public int? GroupCode { set; get; }
        public string GroupName { set; get; } = string.Empty;
    }
}