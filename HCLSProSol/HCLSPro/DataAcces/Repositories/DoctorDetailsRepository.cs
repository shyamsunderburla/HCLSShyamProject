using HCLSPro.DataAcces.IRepositories;
using HCLSPro.DBContext;
using HCLSPro.Models;
using Microsoft.EntityFrameworkCore;

namespace HCLSPro.DataAcces.Repositories
{
    public class DoctorDetailsRepository : IDoctorDetailsRepository
    {   // context class object creation
        public HclsDbContext dbContext;


        public DoctorDetailsRepository(HclsDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public async Task<int> deleteDoctorDetails(int DeptId)
        {
            var Dept = await dbContext.DoctorDetails.FindAsync(DeptId);
            dbContext.DoctorDetails.Remove(Dept);
            return await dbContext.SaveChangesAsync();
        }

        public async Task<List<DoctorDetails>> GetAll()
        {
            return await dbContext.DoctorDetails.ToListAsync();
        }

        public async Task<int> insertDoctorDetails(DoctorDetails Doctordetails)
        {
            await dbContext.DoctorDetails.AddAsync(Doctordetails);
            return await dbContext.SaveChangesAsync();
        }

        public async Task<int> updateDoctorDetails(DoctorDetails Doctordetails)
        {
            dbContext.DoctorDetails.AddAsync(Doctordetails);
            return await dbContext.SaveChangesAsync();
        }
    }
}
