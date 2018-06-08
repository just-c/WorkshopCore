using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkshopCore.Models
{
    public class WorkshopContext : DbContext
    {
        public WorkshopContext (DbContextOptions<WorkshopContext> options)
            : base(options)
        {

        }

        public DbSet<Request> Request { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductImage> ProductImage { get; set; }
    }
}
