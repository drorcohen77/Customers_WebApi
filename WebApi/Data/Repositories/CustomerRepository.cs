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
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DataContext Dc;
        public CustomerRepository(DataContext dc)
        {
            this.Dc = dc;
        }
        public async Task<IEnumerable<FactoriesToCustomer>> GetCustomersByGroupAsync(int groupCode)
        {
            var customers = await Dc.FactoriesToCustomer
            .Where(fc => fc.GroupCode == groupCode)
            .Include(c => c.Customer)
            .Include(g => g.Group)
            .ToListAsync();

            return customers;
        }

        public void AddCustomer(CustomerDto customerDto)
        {
            var existCustomer = Dc.Customers.FirstOrDefault(c => c.CustomerId == customerDto.CustomerId);

            if(existCustomer != null)
            {
                var existGroup = Dc.Groups.FirstOrDefault(g => g.GroupCode == customerDto.GroupCode);
                var existFactory = Dc.Factories.FirstOrDefault(f => f.FactoryCode == customerDto.FactoryCode);

                Customer newCustomer = new Customer
                {
                    CustomerId = customerDto.CustomerId,
                    Name = customerDto.Name,
                    Address =  customerDto.Address,
                    Phone = customerDto.Phone
                };
                Dc.Customers.AddAsync(newCustomer);

                if(existGroup != null && existFactory != null) 
                {
                    FactoriesToCustomer factoriesToCustomer = new FactoriesToCustomer
                    {
                        FactoryCode = customerDto.FactoryCode,
                        GroupCode = customerDto.GroupCode,
                        CustomerId = customerDto.CustomerId
                    };
                    Dc.FactoriesToCustomer.AddAsync(factoriesToCustomer);
                }
            }
        }
    }
}