using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb1_MVC.Models
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AppDbContext _appDbContext;
        public CustomerRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<IEnumerable<Customer>> GetAllCustomers()
        {
            return await _appDbContext.Customers.ToListAsync();
        }

        public async Task<Customer> GetSingleCustomer(int customerId)
        {
            return await _appDbContext.Customers.FirstOrDefaultAsync(c => c.CustomerId == customerId);
        }

        public async Task<Customer> AddCustomer(Customer customer)
        {
            var result = await _appDbContext.Customers.AddAsync(customer);
            await _appDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Customer> DeleteCustomer(int customerId)
        {
            var result = await _appDbContext.Customers.FirstOrDefaultAsync(c => c.CustomerId == customerId);
            if (result != null)
            {
                _appDbContext.Customers.Remove(result);
                await _appDbContext.SaveChangesAsync();
                return result;
            }
            return null;
        }

        public async Task<Customer> UpdateCustomer(Customer customer)
        {
            _appDbContext.Customers.Update(customer);
            await _appDbContext.SaveChangesAsync();
            return customer;
        }
    }
}
