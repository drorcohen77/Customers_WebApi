using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApi.Data;
using WebApi.Models;
using WebApi.Interfaces;
using WebApi.Dtos;
using WebApi.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomersController : ControllerBase
    {
        private readonly IUnitOfWork Uno;
        private readonly IMapper Mapper;

        public CustomersController(IUnitOfWork uno, IMapper mapper) 
        {
            this.Uno = uno;
            this.Mapper = mapper;
        }

        // api/Customers/customers-by-group/groupCode
        [HttpGet("customers-by-group/{groupCode}")]
        public async Task<IActionResult> GetCustomersByGroups(int groupCode) 
        {
            var customers = await Uno.CustomerRepository.GetCustomersByGroupAsync(groupCode);
            
            if(customers is not null)
            {
                var customerByGroup = new List<CustomerByGroupDto>();
                foreach(FactoriesToCustomer c in customers)
                {
                    customerByGroup.Add(new CustomerByGroupDto
                        {
                            CustomerId = c.CustomerId,
                            Name = c.Customer.Name,
                            GroupCode = c.GroupCode,
                            GroupName = c.Group.GroupName,
                        }
                    );
                }

                // var customerByGroup = from c in customers select new CustomerByGroupDto()
                // {
                //     CustomerId = c.CustomerId,
                //     Name = c.Customer.Name,
                //     GroupCode = c.GroupCode,
                //     GroupName = c.Group.GroupName
                // };

                return Ok(customerByGroup);
            }
            else
            {
                return NotFound("Customer not found");
            } 
        }

        // api/Customers/add-customer
        [HttpPost("add-customer")]
        public async Task<IActionResult> AddCustomer(CustomerDto customerDto)
        {
            var existCustomer = await Uno.CustomerRepository.FindCustomer(customerDto.CustomerId);
            var existGroup = await Uno.GroupRepository.FindGroup(customerDto.GroupCode);
            var existFactory = await Uno.FactoryRepository.FindFactory(customerDto.FactoryCode);
            
            if(existCustomer is null)
            {
                var customer = Mapper.Map<Customer>(customerDto);

                if(existGroup is null && existFactory is null) 
                {
                    customerDto.FactoryCode = 0;
                    customerDto.GroupCode = 0;
                }
                var factoriesToCustomer = Mapper.Map<FactoriesToCustomer>(customerDto);

                Uno.CustomerRepository.AddCustomer(customer, factoriesToCustomer);
                await Uno.SaveAsync();
                return StatusCode(201);

            // if(existCustomer != null)
            // {
            //     Customer newCustomer = new Customer
            //     {
            //         CustomerId = customerDto.CustomerId,
            //         Name = customerDto.Name,
            //         Address =  customerDto.Address,
            //         Phone = customerDto.Phone
            //     };

            //     if(existGroup != null && existFactory != null) 
            //     {
            //         FactoriesToCustomer factoriesToCustomer = new FactoriesToCustomer
            //         {
            //             FactoryCode = customerDto.FactoryCode,
            //             GroupCode = customerDto.GroupCode,
            //             CustomerId = customerDto.CustomerId
            //         };
            //         Dc.FactoriesToCustomer.AddAsync(factoriesToCustomer);
            //     }
            // }
            }
            else
            {
                return StatusCode(204);
            }
        }

        // api/Customers/update/id
        [HttpPut("update/{id}")]
        public async Task<IActionResult> UpdateCustomer(string id, CustomerDto customerDto)
        {   
            var existCustomer = await Uno.CustomerRepository.FindCustomer(id);
            if(existCustomer is null) return NotFound("Customer not found");

            var existGroup = await Uno.GroupRepository.FindGroup(customerDto.GroupCode);
            var existFactory = await Uno.FactoryRepository.FindFactory(customerDto.FactoryCode);
            
            if(existGroup is null) return NotFound("GroupCode not found");
            if(existFactory is null) return NotFound("FactoryCode not found");
            var customerToFactories = 
                await Uno.CustomerRepository.GetCustomersFromFtoC(id, customerDto.GroupCode, customerDto.FactoryCode);
                
            Mapper.Map(customerDto, existCustomer);

            Mapper.Map<FactoriesToCustomer>(customerToFactories);

            await Uno.SaveAsync();
            return StatusCode(200);
        }

        // api/Customers/delete/id
        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeleteCustomer(string id)
        {
            Uno.CustomerRepository.DeleteCustomer(id);
            await Uno.SaveAsync();
            return StatusCode(200);
        }
    }
}