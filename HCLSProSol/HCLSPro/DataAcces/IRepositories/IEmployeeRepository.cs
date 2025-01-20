using HCLSPro.Models;

namespace HCLSPro.DataAcces.IRepositories
{
    public interface IEmployeeRepository
    {
        public Task<List<Employee>> GetAll();
        public Task<int> insertEmployee(Employee Emp);

        public Task<int> updateEmployee(Employee Emp);

        public Task<int> deleteEmployee(int EmpId);
    }
}
