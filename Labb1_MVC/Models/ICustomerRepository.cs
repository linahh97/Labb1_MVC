using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb1_MVC.Models
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Customer>> GetAllCustomers();
        Task<Customer> GetSingleCustomer(int customerId);
        Task<Customer> AddCustomer(Customer customer);
        Task<Customer> DeleteCustomer(int customerId);
        Task<Customer> UpdateCustomer(Customer customer);
    }
}
