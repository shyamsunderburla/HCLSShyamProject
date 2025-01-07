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
                var adminTypes = await AdminRef.GetAllAdmins();
                if (adminTypes.Count > 0)
                {
                    return Ok(adminTypes);
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
                var Admins = await AdminRef.GetAdminById(AdminId);
                if (Admins != null)
                {
                    return Ok(Admins);
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
        //    Web api method/Web api endpoint/ Api for CheckAdminLogin data
        [HttpGet]
        [Route("CheckAdminLogin")]
        public async Task<IActionResult> CheckAdminLogin(string Email, string Password)
        {
            try
            {
                var admin = await AdminRef.CheckAdminLogin(Email, Password); // Retrieve the admin

                
                    return Ok(admin);
               
            }
            catch (Exception ex)
            {
                return BadRequest("sorry for inconvienince \n we will solve it soon \n" + ex.Message);
            }

        }
        //    Web api method/Web api endpoint/ Api for ActivateAdmin data
        [HttpGet]
        [Route("ActivateAdmin")]

        public async Task<IActionResult> ActivateAdmin(string Email)
        {
            try
            {
                var admin = await AdminRef.ActivateAdmin(Email);
                if (admin >0)
                {
                    return Ok(admin);
                }
                else
                {
                    return NotFound("No Account is found with the provided Email");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("sorry for inconvienince \n we will solve it soon \n" + ex.Message);
            }
        }
        //    Web api method/Web api endpoint/ Api for bringPassword data
        [HttpGet]
        [Route("bringPassword")]
        public async Task<IActionResult> bringPassword(string Email)
        {
            try
            {
                var adminPassword = await AdminRef.BringPassword(Email);
                return Ok(adminPassword);

            }
            catch (Exception ex)
            {

                return BadRequest($"Sorry for the inconvenience. We will solve this issue soon... Error: {ex.Message}");
            }
        }
        //    Web api method/Web api endpoint/ Api for changePassword data
        [HttpGet]
        [Route("changePassword")]
        public async Task<IActionResult> changePassword(string Email, string Password)
        {
            try
            {

                var admin = await AdminRef.ChangePassword(Email, Password);
                if (admin > 0)
                {
                    return Ok(admin);
                }
                else
                {
                    return NotFound("No admin found with the provided email.");
                }
            }
            catch (Exception ex)
            {

                return BadRequest($"Sorry for the inconvenience. We will solve this issue soon... Error: {ex.Message}");
            }
        }
    }
}
