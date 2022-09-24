using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb1_MVC.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<CustomerBook> CustomerBooks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Books
            modelBuilder.Entity<Book>().HasData(new Book { BookId = 1, BookName = "1984", Author = "George Orwell", PublicationYear = "1949", IsInStock = true });
            modelBuilder.Entity<Book>().HasData(new Book { BookId = 2, BookName = "The Great Gatsby", Author = "F. Scott Fitzgerald", PublicationYear = "1925", IsInStock = true });
            modelBuilder.Entity<Book>().HasData(new Book { BookId = 3, BookName = "Pride and Prejudice", Author = "Jane Austen", PublicationYear = "1813", IsInStock = false });
            modelBuilder.Entity<Book>().HasData(new Book { BookId = 4, BookName = "Frankenstein", Author = "Mary Shelley", PublicationYear = "1818", IsInStock = true });
            modelBuilder.Entity<Book>().HasData(new Book { BookId = 5, BookName = "Of Mice and Men", Author = "John Steinbeck", PublicationYear = "1937", IsInStock = false });
        }
    }
}
