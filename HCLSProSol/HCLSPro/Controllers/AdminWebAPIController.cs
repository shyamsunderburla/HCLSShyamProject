using HCLSPro.DataAcces.IRepositories;
using HCLSPro.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HCLSPro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminWebAPIController : ControllerBase
    {
        //INSTANCIATION
        public IAdminRepository AdminRef;
        // CONSTRUCTOR
        public AdminWebAPIController(IAdminRepository _adminRef)
        {
            AdminRef = _adminRef;
        }

        //    Web api method/Web api endpoint/ Api for GetAllAdmins data
        [HttpGet]
        [Route("GetAllAdmins")]
        public async Task<IActionResult> GetAllAdmins()
        {
            try
            {
                var Admin = await AdminRef.GetAllAdmins();
                if (Admin.Count > 0)
                {
                    return Ok(Admin);
                }
                else
                {
                    return NotFound(" records not found ");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("sorry for inconvienince \n we will solve it soon \n" + ex.Message);
            }

        }

        //    Web api method/Web api endpoint/ Api for read GetAdminById data

        [HttpGet]
        [Route("GetAdminById")]
        public async Task<IActionResult> GetAdminById(int AdminId)
        {
            try
            {
                var Admin = await AdminRef.GetAdminById(AdminId);
                if (Admin != null)
                {
                    return Ok(Admin);
                }
                else
                {
                    return NotFound(" records not found ");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("sorry for inconvienince \n we will solve it soon \n" + ex.Message);
            }

        }

        //    Web api method/Web api endpoint/ Api for InsertAdmin data
        [HttpPost]
        [Route("InsertAdmin")]
        public async Task<IActionResult> InsertAdmin(Admin Admin)
        {
            try
            {
                var Count = await AdminRef.InsertAdmin(Admin);
                if (Count > 0)
                {
                    return Ok(Count + "Recpord inserted");
                }
                else
                {
                    return NotFound("record not inserted");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("sorry for inconvienince \n we will solve it soon \n" + ex.Message);
            }

        }

        //    Web api method/Web api endpoint/ Api for UpdateAdmin data
        [HttpPut]
        [Route("UpdateAdmin")]
        public async Task<IActionResult> UpdateAdmin(Admin Admin)
        {
            try
            {
                var Count = await AdminRef.UpdateAdmin(Admin);
                if (Count > 0)
                {
                    return Ok(Count + "Recpord updated");
                }
                else
                {
                    return BadRequest("data not updated");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("sorry for inconvienince \n we will solve it soon \n" + ex.Message);
            }

        }

        //    Web api method/Web api endpoint/ Api for DeleteAdmin data
        [HttpDelete]
        [Route("DeleteAdmin")]
        public async Task<IActionResult> DeleteAdmin(int AdminId)
        {
            try
            {
                var deleteAdmin = await AdminRef.DeleteAdmin(AdminId);
                if (deleteAdmin > 0)
                {
                    return Ok(deleteAdmin + "Recpord deleted...!");
                }
                else
                {
                    return BadRequest("No Record Deleted...!");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("sorry for inconvienince \n we will solve it soon \n" + ex.Message);
            }

        }
    }
}
