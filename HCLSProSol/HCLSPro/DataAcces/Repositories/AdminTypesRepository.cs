﻿using HCLSPro.DataAcces.IRepositories;
using HCLSPro.DBContext;
using HCLSPro.Models;
using Microsoft.EntityFrameworkCore;

namespace HCLSPro.DataAcces.Repositories
{
    public class AdminTypesRepository : IAdminTypesRepository
    {
        // context class object creation
        public HclsDbContext DBContext;
        public AdminTypesRepository(HclsDbContext __dBContext)
        {
            DBContext = __dBContext;
        }

   
        public async Task<int> DeleteAdminTypes(int AdminTypeId)
        {
            var AdminTypes = await DBContext.AdminTypes.FindAsync(AdminTypeId);
            DBContext.AdminTypes.Remove(AdminTypes);
            return await DBContext.SaveChangesAsync();
        }

        public async Task<AdminTypes> GetAdminTypesById(int AdminTypeId)
        {
            return await DBContext.AdminTypes.FindAsync(AdminTypeId);
        }

        public async Task<List<AdminTypes>> GetAllAdminTypes()
        {
            return await DBContext.AdminTypes.ToListAsync();
        }

        public async Task<int> InsertAdminTypes(AdminTypes Admin)
        {
            await DBContext.AdminTypes.AddAsync(Admin);
            return await DBContext.SaveChangesAsync();
        }

        public async Task<int> UpdateAdminTypes(AdminTypes Admin)
        {
            DBContext.AdminTypes.Update(Admin);
            return await DBContext.SaveChangesAsync();
        }
    }
}

