using HCLSPro.DataAcces.IRepositories;
using HCLSPro.DBContext;
using HCLSPro.Models;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.EntityFrameworkCore;

namespace HCLSPro.DataAcces.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        // context class object creation
        public HclsDbContext dbContext;


        public DepartmentRepository(HclsDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public async Task<int> deleteDepartment(int DeptId)
        {
            var DeptRepo = await dbContext.Departments.FindAsync(DeptId);
            dbContext.Departments.Remove(DeptRepo);
            return await dbContext.SaveChangesAsync();
        }

        public async Task<List<Department>> GetAll()
        {
            return await dbContext.Departments.ToListAsync();
        }

        public async Task<int> insertDepartment(Department Dept)
        {
            await dbContext.Departments.AddAsync(Dept);
            return await dbContext.SaveChangesAsync();
        }

        public async Task<int> updateDepartment(Department Dept)
        {
            dbContext.Departments.Update(Dept);
            return await dbContext.SaveChangesAsync();
        }
    }
}
