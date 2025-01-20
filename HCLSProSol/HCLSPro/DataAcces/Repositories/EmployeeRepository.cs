using HCLSPro.DataAcces.IRepositories;
using HCLSPro.DBContext;
using HCLSPro.Models;
using Microsoft.EntityFrameworkCore;

namespace HCLSPro.DataAcces.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    { // context class object creation
        public HclsDbContext dbContext;


        public EmployeeRepository(HclsDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public async Task<int> deleteEmployee(int EmpId)
        {
            var empRepo = await dbContext.Employees.FindAsync(EmpId);
            dbContext.Employees.Remove(empRepo);
            return await dbContext.SaveChangesAsync();
        }

        public async Task<List<Employee>> GetAll()
        {
            return await dbContext.Employees.ToListAsync();
        }

        public async Task<int> insertEmployee(Employee Emp)
        {
            await dbContext.Employees.AddAsync(Emp);
            return await dbContext.SaveChangesAsync();
        }

        public async Task<int> updateEmployee(Employee Emp)
        {
            dbContext.Employees.AddAsync(Emp);
            return await dbContext.SaveChangesAsync();
        }
    }
}
