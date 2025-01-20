using HCLSPro.DataAcces.IRepositories;
using HCLSPro.DBContext;
using HCLSPro.Models;
using Microsoft.EntityFrameworkCore;

namespace HCLSPro.DataAcces.Repositories
{
    public class HelperDetailsRepository : IHelperDetailsRepository
    { 
        // context class object creation
        public HclsDbContext dbContext;


        public HelperDetailsRepository(HclsDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public async Task<int> deleteHelperDetails(int HelperId)
        {
            var HelperDet = await dbContext.HelpersDetails.FindAsync(HelperId);
            dbContext.HelpersDetails.Remove(HelperDet);
            return await dbContext.SaveChangesAsync();
        }

        public async Task<List<HelperDetails>> GetAll()
        {
            return await dbContext.HelpersDetails.ToListAsync();
        }

        public async Task<int> insertHelperDetails(HelperDetails Helperdetails)
        {
            await dbContext.HelpersDetails.AddAsync(Helperdetails);
            return await dbContext.SaveChangesAsync();
        }

        public async Task<int> updateHelperDetails(HelperDetails Helperdetails)
        {
            dbContext.HelpersDetails.Update(Helperdetails);
            return await dbContext.SaveChangesAsync();
        }
    }
}
