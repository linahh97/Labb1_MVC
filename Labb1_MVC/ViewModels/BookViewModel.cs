using Labb1_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb1_MVC.ViewModels
{
    public class BookViewModel
    {
        public IEnumerable<Book> BooksInStock { get; set; }
    }
}
