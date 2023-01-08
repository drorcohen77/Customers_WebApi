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

        public void AddCustomer(Customer customer, FactoriesToCustomer factoriesToCustomer)
        {
            Dc.Customers.AddAsync(customer);
            Dc.FactoriesToCustomer.AddAsync(factoriesToCustomer);
        }


        public async Task<Customer> FindCustomer(string CustomerId)
        {
            return await Dc.Customers.FindAsync(CustomerId);
        }

        public async Task<FactoriesToCustomer> GetCustomersFromFtoC(string customerId, int groupCode, int factoryCode)
        {
            var customer = await Dc.FactoriesToCustomer.FirstOrDefaultAsync(
                fc => fc.CustomerId == customerId && fc.FactoryCode == factoryCode && fc.GroupCode == groupCode);

            return customer;
        }


        public void DeleteCustomer(string customerId)
        {
            var customer = Dc.Customers.FirstOrDefault(c => c.CustomerId == customerId);
            var allCustomerRecords = Dc.FactoriesToCustomer
                .Where(fc => fc.CustomerId == customerId)
                .ToList();

            Dc.Customers.Remove(customer);
            Dc.FactoriesToCustomer.RemoveRange(allCustomerRecords);
        }
    }
}