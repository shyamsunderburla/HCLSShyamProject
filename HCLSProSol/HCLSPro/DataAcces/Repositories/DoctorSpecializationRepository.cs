using HCLSPro.DataAcces.IRepositories;
using HCLSPro.DBContext;
using HCLSPro.Models;
using Microsoft.EntityFrameworkCore;

namespace HCLSPro.DataAcces.Repositories
{
    public class DoctorSpecializationRepository : IDoctorSpecializationRepository
    {
        // context class object creation
        public HclsDbContext dbContext;


        public DoctorSpecializationRepository(HclsDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public async Task<int> deleteDoctorSpecialization(int DeptId)
        {
            var docspcl = await dbContext.DoctorSpecialization.FindAsync(DeptId);
            dbContext.DoctorSpecialization.Remove(docspcl);
            return await dbContext.SaveChangesAsync();
        }

        public async Task<List<DoctorSpecialization>> GetAll()
        {
            return await dbContext.DoctorSpecialization.ToListAsync();
        }

        public async Task<int> insertDoctorSpecialization(DoctorSpecialization DocSpec)
        {

            await dbContext.DoctorSpecialization.AddAsync(DocSpec);
            return await dbContext.SaveChangesAsync();
        }

        public async Task<int> updateDoctorSpecialization(DoctorSpecialization DocSpec)
        {
            dbContext.DoctorSpecialization.Update(DocSpec);
            return await dbContext.SaveChangesAsync();
        }
    }
}
