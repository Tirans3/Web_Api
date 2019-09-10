using System.Data.Entity;

namespace WebApplication1.Models
{
    
        public class BookContext : DbContext
        {
            public DbSet<Book> Books { get; set; }
        }
    
}