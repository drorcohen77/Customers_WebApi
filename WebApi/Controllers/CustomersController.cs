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
        // private readonly IMapper Mapper;

        public CustomersController(IUnitOfWork uno) 
        {
            this.Uno = uno;
            // this.Mapper = mapper;
        }

        // api/customers-by-group/100
        [HttpGet("customers-by-group/{groupCode}")]
        public async Task<IActionResult> GetCustomersByGroups(int groupCode) 
        {
            var customers = await Uno.CustomerRepository.GetCustomersByGroupAsync(groupCode);
            // var customersDto = Mapper.Map<IEnumerable<CustomerDto>>(customers);
            
            if(customers.Count() > 0)
            {

                var customerByGroup = from c in customers select new CustomerByGroupDto()
                {
                    CustomerId = c.CustomerId,
                    Name = c.Customer.Name,
                    GroupCode = c.GroupCode,
                    GroupName = c.Group.GroupName
                };

                // return Ok(customersDto);
                return Ok(customerByGroup);
            }
            else
            {
                return StatusCode(204);
            } 
        }

        [HttpPost("add-customer")]
        public async Task<IActionResult> AddCustomer(CustomerDto customerDto)
        {
            // var customer = Mapper.Map<Customer>(customerDto);
            

            Uno.CustomerRepository.AddCustomer(customerDto);
            await Uno.SaveAsync();
            return StatusCode(201);
        }
    }
}