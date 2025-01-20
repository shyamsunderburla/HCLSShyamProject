using HCLSPro.Models;

namespace HCLSPro.DataAcces.IRepositories
{
    public interface IHelperDetailsRepository
    {
        public Task<List<HelperDetails>> GetAll();
        public Task<int> insertHelperDetails(HelperDetails Helperdetails);

        public Task<int> updateHelperDetails(HelperDetails Helperdetails);

        public Task<int> deleteHelperDetails(int HelperId);

    }
}
