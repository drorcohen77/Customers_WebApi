using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;
using WebApi.Dtos;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Interfaces
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<FactoriesToCustomer>> GetCustomersByGroupAsync(int groupCode);
        void AddCustomer(Customer customer, FactoriesToCustomer factoriesToCustomer);
        void DeleteCustomer(string customerId);
        Task<Customer> FindCustomer(string customerId);
        Task<FactoriesToCustomer> GetCustomersFromFtoC(string customerId, int factoryGroup, int groupCode);
    }
}