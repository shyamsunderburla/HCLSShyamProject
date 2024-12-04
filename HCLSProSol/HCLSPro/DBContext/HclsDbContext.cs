using HCLSPro.Models;
using Microsoft.EntityFrameworkCore;

namespace HCLSPro.DBContext
{
    public class HclsDbContext :DbContext
    {
        
        
            // Dependency injection process:[.nec core by default provide dependency injection]
            //Loosly coupled app dev
            public HclsDbContext(DbContextOptions<HclsDbContext> options) : base(options) { }
            public DbSet<AdminTypes> AdminTypes { get; set; }
            public DbSet<Admin> Admin { get; set; }
        
    }
}

