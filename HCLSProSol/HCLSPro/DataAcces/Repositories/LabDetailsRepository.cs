using HCLSPro.DataAcces.IRepositories;
using HCLSPro.DBContext;
using HCLSPro.Models;
using Microsoft.EntityFrameworkCore;

namespace HCLSPro.DataAcces.Repositories
{
    public class LabDetailsRepository : ILabDetailsRepository
    {
        // context class object creation
        public HclsDbContext dbContext;


        public LabDetailsRepository(HclsDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public async Task<int> deleteLabDetails(int LabId)
        {
            var Lab = await dbContext.LabDetails.FindAsync(LabId);
            dbContext.LabDetails.Remove(Lab);
            return await dbContext.SaveChangesAsync();
        }

        public async Task<List<LabDetails>> GetAll()
        {
            return await dbContext.LabDetails.ToListAsync();
        }

        public async Task<int> insertLabDetails(LabDetails Labdetails)
        {
            await dbContext.LabDetails.AddAsync(Labdetails);
            return await dbContext.SaveChangesAsync();
        }

        public async Task<int> updateLabDetails(LabDetails Labdetails)
        {
            dbContext.LabDetails.AddAsync(Labdetails);
            return await dbContext.SaveChangesAsync();
        }
    }
}
