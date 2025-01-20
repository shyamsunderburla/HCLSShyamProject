using HCLSPro.Models;

namespace HCLSPro.DataAcces.IRepositories
{
    public interface IDoctorDetailsRepository
    {
        public Task<List<DoctorDetails>> GetAll();
        public Task<int> insertDoctorDetails(DoctorDetails Doctordetails);

        public Task<int> updateDoctorDetails(DoctorDetails Doctordetails);

        public Task<int> deleteDoctorDetails(int DeptId);
    }
}
