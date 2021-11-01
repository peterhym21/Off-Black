﻿using Microsoft.AspNetCore.Mvc;
using Off_Black.Service.DTO;
using Off_Black.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Off_Black.API.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class CustomerController : ControllerBase
    {

        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        [Route("All")]
        public async Task<List<CustomerDTO>> GetAll()
        {
            return await _customerService.GetAll();
        }

        [HttpGet]
        [Route("ById/{Id:int}")]
        public async Task<CustomerDTO> GetById(int Id)
        {
            return await _customerService.GetById(Id);
        }

        [HttpGet]
        [Route("Last")]
        public async Task<CustomerDTO> GetLastCustomer()
        {
            return await _customerService.GetLastCustomer();
        }

        [HttpPost]
        [Route("Create")]
        public async Task Create(CustomerDTO customer)
        {
            await _customerService.Create(customer);
        }

        [HttpPut]
        [Route("Delete")]
        public async Task Delete(CustomerDTO customer)
        {
            await _customerService.Delete(customer);
        }

        [HttpPut]
        [Route("Update")]
        public async Task Update(CustomerDTO customer)
        {
            await _customerService.Update(customer);
        }
    }
}
