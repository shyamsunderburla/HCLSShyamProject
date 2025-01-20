using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HCLSPro.Models
{
    [Table("DoctorSpecialization")]
    public class DoctorSpecialization
    {
        [Key]
        [Required(ErrorMessage = "Please Enter Employee Id")]
        public int DocSpecId { get; set; }

        [Required(ErrorMessage = "Please Enter Specialization")]
        public string Specialization { get; set; }
    }
}
