using HCLSPro.Models;

namespace HCLSPro.DataAcces.IRepositories
{
    public interface IAdminTypesRepository
    {
        Task<List<AdminTypes>> GetAllAdminTypes();
        Task<AdminTypes> GetAdminTypesById(int AdminTypeId);
        Task<int> InsertAdminTypes(AdminTypes Admin);
        Task<int> UpdateAdminTypes(AdminTypes Admin);
        Task<int> DeleteAdminTypes(int AdminTypeId);
    }
}
