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
            public DbSet<Admin> Admins { get; set; }
        public DbSet<Department> Departments { get; set; }

        public DbSet<DoctorDetails> DoctorDetails { get; set; }

        public DbSet<DoctorSpecialization> DoctorSpecialization { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<HelperDetails> HelpersDetails { get; set; }

        public DbSet<LabDetails> LabDetails { get; set; }

        public DbSet<ReceptionistDetails> ReceptionistDetails { get; set; }



    }
}

