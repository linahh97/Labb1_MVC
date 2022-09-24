using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Labb1_MVC.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [StringLength(25, MinimumLength = 2)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [StringLength(30, MinimumLength = 2)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [StringLength(12)]
        public string PersonalNumber { get; set; }

        public ICollection<CustomerBook> CustomerBooks { get; set; }
    }
}
