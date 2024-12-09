using HCLSPro.Models;

namespace HCLSPro.DataAcces.IRepositories
{
    public interface IAdminTypesRepository
    {
        Task<List<AdminTypes>> getAllAdminTypes();
        Task<AdminTypes> getAdminTypesById(int AdminTypeId);
        Task<int> insertAdminTypes(AdminTypes Admin);
        Task<int> updateAdminTypes(AdminTypes Admin);
        Task<int> deleteAdminTypes(int AdminTypeId);
    }
}
