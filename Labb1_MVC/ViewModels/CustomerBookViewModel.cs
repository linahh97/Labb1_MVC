using Labb1_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb1_MVC.ViewModels
{
    public class CustomerBookViewModel
    {
        public IEnumerable<CustomerBook> GetCustomerBooks { get; set; }
    }
}
