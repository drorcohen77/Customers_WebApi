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
    public class FactoryRepository : IFactoryRepository
    {
        private readonly DataContext Dc;
        public FactoryRepository(DataContext dc)
        {
            this.Dc = dc;
        }
       

        public async Task<Factory> FindFactory(int factoryCode)
        {
            return await Dc.Factories.FindAsync(factoryCode);
        }
    }
}