using Labb1_MVC.Models;
using Labb1_MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb1_MVC.Controllers
{
    public class CustomerBookController : Controller
    {
        private readonly ICustomerBookRepository _customerbookRepo;
        private readonly AppDbContext _appDbContext;

        public CustomerBookController(ICustomerBookRepository customerBookRepo, AppDbContext appDbContext)
        {
            _customerbookRepo = customerBookRepo;
            _appDbContext = appDbContext;
        }

        [HttpGet("{id}")]
        public ActionResult LoanedBooks(int id)
        {
            var cb = _appDbContext.CustomerBooks.FirstOrDefault(c => c.CustomerId == id);

            if (cb == null)
            {
                return NotFound("No loans...");
            }
            else if (cb.CustomerId == id)
            {
                var customerbook = _appDbContext.CustomerBooks.Include
                    (b => b.Book).Where(c => c.CustomerId == id);
                var customerbookViewModel = new CustomerBookViewModel()
                {
                    GetCustomerBooks = customerbook
                };

                return View(customerbookViewModel);
            }
            return View();
        }
    }
}
