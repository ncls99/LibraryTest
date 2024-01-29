using LibraryTest.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace LibraryTest.DataAccessLayer
{
    public class AplicationDBContext : DbContext
    {
        public AplicationDBContext() : base("Library_DataBase")
        { 
        
        }
        public DbSet<Author> Author { get; set; }
        public DbSet<Book> Book { get; set; }
    }
}
