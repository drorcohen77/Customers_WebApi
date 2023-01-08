using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;
using WebApi.Data;
using WebApi.Interfaces;
using Microsoft.EntityFrameworkCore;
using WebApi.Dtos;

namespace WebApi.Data.Repositories
{
    public class GroupRepository : IGroupRepository
    {
        private readonly DataContext Dc;
        public GroupRepository(DataContext dc)
        {
            this.Dc = dc;
        }
       

        public async Task<Group> FindGroup(int groupCode)
        {
            return await Dc.Groups.FindAsync(groupCode);
        }
    }
}