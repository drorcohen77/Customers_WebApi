using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;
using WebApi.Dtos;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Interfaces
{
    public interface IGroupRepository
    {
        Task<Group> FindGroup(int groupCode);
    }
}