using HCLSPro.DataAcces.IRepositories;
using HCLSPro.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HCLSPro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminTypesWebAPIController : ControllerBase
    {
        //INSTANCIATION
        public IAdminTypesRepository AdminTypesRef;

        // CONSTRUCTOR
        public AdminTypesWebAPIController(IAdminTypesRepository _adminTypesRef) 
        {
            AdminTypesRef = _adminTypesRef;
        }

        //    Web api method/Web api endpoint/ Api for GetAllAdminTypes data
        [HttpGet]
        [Route("GetAllAdminTypes")]
        public async Task<IActionResult> GetAllAdminTypes()
        {
            try
            {
                var AdminTypes = await AdminTypesRef.GetAllAdminTypes();
                if (AdminTypes.Count > 0)
                {
                    return Ok(AdminTypes);
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

        //    Web api method/Web api endpoint/ Api for read AdminTypesById data

        [HttpGet]
        [Route("GetAdminTypesById")]
        public async Task<IActionResult> GetAdminTypesById(int AdminTypeId)
        {
            try
            {
                var AdminType = await AdminTypesRef.GetAdminTypesById(AdminTypeId);
                if (AdminType != null)
                {
                    return Ok(AdminType);
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

       //    Web api method/Web api endpoint/ Api for InsertAdminTypes data
        [HttpPost]
        [Route("InsertAdminTypes")]
        public async Task<IActionResult>InsertAdminTypes(AdminTypes Admin)
        {
            try
            {
                var Count = await AdminTypesRef.InsertAdminTypes(Admin);
                if (Count>0)
                {
                    return Ok(Count+ "Recpord inserted");
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

        //    Web api method/Web api endpoint/ Api for UpdateAdminTypes data
        [HttpPut]
        [Route("UpdateAdminTypes")]
        public async Task<IActionResult> UpdateAdminTypes(AdminTypes Admin)
        {
            try
            {
                var Count = await AdminTypesRef.UpdateAdminTypes(Admin);
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
        //    Web api method/Web api endpoint/ Api for DeleteAdminTypes data
        [HttpDelete]
        [Route("DeleteAdminTypes")]
        public async Task<IActionResult> DeleteAdminTypes(int AdminTypeId)
        {
            try
            {
                var deleteAdminType = await AdminTypesRef.DeleteAdminTypes(AdminTypeId);
                if (deleteAdminType > 0)
                {
                    return Ok(deleteAdminType + "Recpord deleted...!");
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