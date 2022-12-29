using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Factory
    {
        [Key]
        public int FactoryCode { set; get; }
        public string FactoryName { set; get; } = string.Empty;
        public int GroupCode { set; get; }
        public Group? Group { get; set; }
    }
}