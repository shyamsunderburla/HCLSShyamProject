using HCLSPro.Models;

namespace HCLSPro.DataAcces.IRepositories
{
    public interface IAdminRepository
    {
        Task<List<Admin>> GetAllAdmins();
        Task<Admin> GetAdminById(int AdminId);
        public Task<Admin> CheckAdminLogin(string Email, string Password);
        public Task<int> ActivateAdmin(string Email);
        public Task<string> BringPassword(string Email);

        public Task<int> ChangePassword(string Email, string Password);
        Task<int> InsertAdmin(Admin admin);
        Task<int> UpdateAdmin(Admin admin);
        Task<int> DeleteAdmin(int AdminId);
    }
}
