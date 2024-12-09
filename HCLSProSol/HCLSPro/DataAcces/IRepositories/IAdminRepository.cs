using HCLSPro.Models;

namespace HCLSPro.DataAcces.IRepositories
{
    public interface IAdminRepository
    {
        Task<List<Admin>> getAllAdmins();
        Task<Admin> getAdminById(int AdminId);
        Task<int> insertAdmin(Admin admin);
        Task<int> updateAdmin(Admin admin);
        Task<int> deleteAdmin(int AdminId);
    }
}
