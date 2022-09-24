using Labb1_MVC.Models;
using Labb1_MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb1_MVC.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository _bookRepository;

        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<ViewResult> List()
        {
            var bookViewModel = new BookViewModel
            {
                BooksInStock = await _bookRepository.GetBooksInStock()
            };
            return View(bookViewModel);
        }

        public async Task<IActionResult> Details(int id)
        {
            var book = await _bookRepository.GetSingleBook(id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }
    }
}
