using HCLSPro.Models;

namespace HCLSPro.DataAcces.IRepositories
{
    public interface IAdminRepository
    {
        Task<List<Admin>> GetAllAdmins();
        Task<Admin> GetAdminById(int AdminId);
        Task<int> InsertAdmin(Admin admin);
        Task<int> UpdateAdmin(Admin admin);
        Task<int> DeleteAdmin(int AdminId);
    }
}
