using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb1_MVC.Models
{
    public class CustomerBookRepository : ICustomerBookRepository
    {
        private readonly AppDbContext _appDbContext;
        public CustomerBookRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<CustomerBook> GetBorrowedBooksFromCustomer(int id)
        {
            throw new NotImplementedException();
        }
    }
}
