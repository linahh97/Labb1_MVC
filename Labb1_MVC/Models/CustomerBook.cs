using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Labb1_MVC.Models
{
    public class CustomerBook
    {
        [Key]
        public int CustomerBookId { get; set; }

        [Required]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        [Required]
        public int BookId { get; set; }
        public Book Book { get; set; }

        public DateTime Borrowed { get; set; }
        public DateTime Returned { get; set; }
    }
}
