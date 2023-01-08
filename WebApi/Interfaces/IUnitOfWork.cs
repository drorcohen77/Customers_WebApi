using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Interfaces
{
    public interface IUnitOfWork
    {
        ICustomerRepository CustomerRepository { get; }
        IFactoryRepository FactoryRepository { get; }
        IGroupRepository GroupRepository { get; }
        Task<bool> SaveAsync();
    }
}