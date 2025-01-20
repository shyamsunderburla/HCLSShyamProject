using HCLSPro.Models;

namespace HCLSPro.DataAcces.IRepositories
{
    public interface ILabDetailsRepository
    {
        public Task<List<LabDetails>> GetAll();
        public Task<int> insertLabDetails(LabDetails Labdetails);

        public Task<int> updateLabDetails(LabDetails Labdetails);

        public Task<int> deleteLabDetails(int LabId);
    }
}
