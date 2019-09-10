using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    
        public class BookContext : DbContext
        {
            public DbSet<Book> Books { get; set; }
        }
    
}