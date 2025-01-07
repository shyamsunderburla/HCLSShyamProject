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

        public async Task<int> ActivateAdmin(string Email)
        {
            var admin = await dbContext.Admins.Where(x => x.Email == Email).SingleOrDefaultAsync();
            admin.ActiveStatus=true;
            return await UpdateAdmin(admin);
        }

        public async Task<string> BringPassword(string Email)
        {
            var Admin = await dbContext.Admins!.Where(x => x.Email == Email).SingleOrDefaultAsync();
            var x = Admin.Password;
            return x;
        }

        public async Task<int> ChangePassword(string Email, string Password)
        {
            var Admin = await dbContext.Admins!.Where(x => x.Email == Email).SingleOrDefaultAsync();
            Admin.Password = Password;
            return await UpdateAdmin(Admin);
        }

        public async Task<Admin> CheckAdminLogin(string Email, string Password)
        {
            return await dbContext.Admins!.Where(x => x.Email == Email && x.Password == Password).SingleOrDefaultAsync();
        }

        public async Task<int> DeleteAdmin(int AdminId)
        {
            var admin = await dbContext.Admins.FindAsync(AdminId);
            dbContext.Admins.Remove(admin);
            return await dbContext.SaveChangesAsync();
        }

        public async Task<Admin> GetAdminById(int AdminId)
        {
            return await dbContext.Admins.FindAsync(AdminId);
        }

        public async Task<List<Admin>> GetAllAdmins()
        {
            return await dbContext.Admins.ToListAsync();
        }

        public async Task<int> InsertAdmin(Admin admin)
        {
            await dbContext.Admins.AddAsync(admin);
            return await dbContext.SaveChangesAsync();
        }

        public async Task<int> UpdateAdmin(Admin admin)
        {
            await dbContext.Admins.AddAsync(admin);
            return await dbContext.SaveChangesAsync();
        }
    }
}
