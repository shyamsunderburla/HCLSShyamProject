using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HCLSPro.Models
{
    [Table("ReceptionistDetails")]
    public class ReceptionistDetails
    {
        [Key]
        [Required(ErrorMessage = "Please Enter Employee Id")]
        public int EmpId { get; set; }

        [Required(ErrorMessage = "Please Enter Email")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Enter Logged")]
        public Boolean Logged { get; set; }
    }
}
