using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb1_MVC.Models
{
    public class BookRepository : IBookRepository
    {
        private readonly AppDbContext _appDbContext;
        public BookRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            return await _appDbContext.Books.ToListAsync();
        }

        public async Task<IEnumerable<Book>> GetBooksInStock()
        {
            return await _appDbContext.Books.Where(b => b.IsInStock).ToListAsync();
        }

        public async Task<Book> GetSingleBook(int bookId)
        {
            return await _appDbContext.Books.FirstOrDefaultAsync(b => b.BookId == bookId);
        }
    }
}
