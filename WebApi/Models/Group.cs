using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Group
    {
        [Key]
        public int GroupCode { set; get; }
        public string GroupName { set; get; } = string.Empty;
    }
}