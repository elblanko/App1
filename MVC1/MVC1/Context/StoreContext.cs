using MVC1.Models;
using System.Data.Entity;

namespace MVC1.Context
{
    public class StoreContext : DbContext
    {
        public DbSet<Product> Products { get; set; } 
    }
}