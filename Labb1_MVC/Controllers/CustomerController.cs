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
        private readonly AppDbContext _appDbContext;

        public CustomerController(ICustomerRepository customerRepository, AppDbContext appDbContext)
        {
            _customerRepository = customerRepository;
            _appDbContext = appDbContext;
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

        [HttpPost]
        public async Task<ActionResult<Customer>> AddNew(Customer customer)
        {
            var addCustomer = await _customerRepository.AddCustomer(customer);
            CreatedAtAction(nameof(GetSingle), new { id = addCustomer.CustomerId }, addCustomer);
            return View();
        }

        public ActionResult AddNewCustomer()
        {
            return View("AddNew");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var deleteCustomer = await _customerRepository.GetSingleCustomer(id);
            if (deleteCustomer == null)
            {
                return NotFound();
            }
            await _customerRepository.DeleteCustomer(id);
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Customer customer)
        {
            _appDbContext.Update(customer);
            _appDbContext.SaveChanges();
            return RedirectToAction(nameof(GetAll));
        }

        public async Task<IActionResult> Updates(int id)
        {
            var customer = await _customerRepository.GetSingleCustomer(id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }
    }
}