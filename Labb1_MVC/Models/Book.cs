using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Labb1_MVC.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [Required]
        public string BookName { get; set; }
        [Required]
        public string Author { get; set; }
        public string PublicationYear { get; set; }
        public bool IsInStock { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnail { get; set; }

        public ICollection<CustomerBook> CustomerBooks { get; set; }
    }
}
