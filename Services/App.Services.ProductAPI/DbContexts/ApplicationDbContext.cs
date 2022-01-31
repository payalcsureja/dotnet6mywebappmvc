using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Services.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace App.Services.ProductAPI.DbContexts
{
    public class ApplicationDbContext : DbContext
    {        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }

    }
}