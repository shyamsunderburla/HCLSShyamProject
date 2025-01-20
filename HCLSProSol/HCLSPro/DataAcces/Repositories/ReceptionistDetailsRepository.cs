using HCLSPro.DataAcces.IRepositories;
using HCLSPro.DBContext;
using HCLSPro.Models;
using Microsoft.EntityFrameworkCore;

namespace HCLSPro.DataAcces.Repositories
{
    public class ReceptionistDetailsRepository : IReceptionistDetailsRepository
    {

        // context class object creation
        public HclsDbContext dbContext;


        public ReceptionistDetailsRepository(HclsDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public async Task<int> deleteReceptionistDetails(int RecpId)
        {
            var RecpDet = await dbContext.ReceptionistDetails.FindAsync(RecpId);
            dbContext.ReceptionistDetails.Remove(RecpDet);
            return await dbContext.SaveChangesAsync();
        }

        public async Task<List<ReceptionistDetails>> GetAll()
        {
            return await dbContext.ReceptionistDetails.ToListAsync();
        }

        public async Task<int> insertReceptionistDetails(ReceptionistDetails Recpdetails)
        {
            await dbContext.ReceptionistDetails.AddAsync(Recpdetails);
            return await dbContext.SaveChangesAsync();
        }

        public async Task<int> updateReceptionistDetails(ReceptionistDetails Recpdetails)
        {
            dbContext.ReceptionistDetails.AddAsync(Recpdetails);
            return await dbContext.SaveChangesAsync();
        }
    }
}
