using Labb1_MVC.Models;
using Labb1_MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb1_MVC.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<IActionResult> GetAll()
        {
            var customerViewModel = new CustomerViewModel
            {
                AllCustomers = await _customerRepository.GetAllCustomers()
            };
            return View(customerViewModel);
        }

        public async Task<IActionResult> GetSingle(int id)
        {
            var customer = await _customerRepository.GetSingleCustomer(id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }

        public async Task<IActionResult> AddNew(Customer customer)
        {
            if (customer == null)
            {
                return BadRequest();
            }
            var addCustomer = await _customerRepository.AddCustomer(customer);
            return View(CreatedAtAction(nameof(GetSingle), new { id = addCustomer.CustomerId }, addCustomer));

        }

        public async Task<IActionResult> Delete(int id)
        {
            var deleteCustomer = await _customerRepository.DeleteCustomer(id);
            return View();
        }
    }
}