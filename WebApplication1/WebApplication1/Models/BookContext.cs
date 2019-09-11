using System.Data.Entity;
using Microsoft;
namespace WebApplication1.Models
{
    
        public class BookContext : DbContext
        {
        public BookContext():base("DBConnection")
        {
          
        }
       
        public DbSet<Book> Books { get; set; }
        
        }
    
}