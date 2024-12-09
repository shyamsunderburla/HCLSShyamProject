using HCLSPro.DataAcces.IRepositories;
using HCLSPro.DBContext;
using HCLSPro.Models;
using Microsoft.EntityFrameworkCore;

namespace HCLSPro.DataAcces.Repositories
{
    public class AdminRepository : IAdminRepository
    {
        // context class object creation
        public HclsDbContext dbContext;
        public AdminRepository(HclsDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public async Task<int> deleteAdmin(int AdminId)
        {
            var admin = await dbContext.Admins.FindAsync(AdminId);
            dbContext.Admins.Remove(admin);
            return await dbContext.SaveChangesAsync();
        }

        public async Task<Admin> getAdminById(int AdminId)
        {
            return await dbContext.Admins.FindAsync(AdminId);
        }

        public async Task<List<Admin>> getAllAdmins()
        {
           return await dbContext.Admins.ToListAsync();
        }

        public async Task<int> insertAdmin(Admin admin)
        {
           await dbContext.Admins.AddAsync(admin);
            return await dbContext.SaveChangesAsync();
        }

        public async Task<int> updateAdmin(Admin admin)
        {
            dbContext.Admins.Update(admin);
            return await dbContext.SaveChangesAsync();  
        }
    }
}
