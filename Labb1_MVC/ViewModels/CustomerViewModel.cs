using Labb1_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb1_MVC.ViewModels
{
    public class CustomerViewModel
    {
        public IEnumerable<Customer> AllCustomers { get; set; }
    }
}
