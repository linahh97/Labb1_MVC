using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb1_MVC.Models
{
    public interface ICustomerBookRepository
    {
        Task<CustomerBook> GetBorrowedBooksFromCustomer(int id);
    }
}