using LibraryTest.Models;
using Microsoft.EntityFrameworkCore;


namespace LibraryTest.DAL
{
    public class LibraryDatabaseContext : DbContext
    {
        public LibraryDatabaseContext(DbContextOptions<LibraryDatabaseContext> options) : base(options)
        { 
        
        }
        public DbSet<Author> Author { get; set; }
        public DbSet<Book> Book { get; set; }
    }
}
