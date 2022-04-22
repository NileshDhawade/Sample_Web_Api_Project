using Microsoft.EntityFrameworkCore;
using Sample_Web_API_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Sample_Web_API_Project.Entities
{
    public class RepositoriesContext:DbContext
    {
        public RepositoriesContext(DbContextOptions options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
