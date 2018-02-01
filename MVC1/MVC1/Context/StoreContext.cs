using MVC1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC1.Context
{
    public class StoreContext : DbContext
    {
        public DbSet<Products> MyProducts { get; set; } 
    }
}