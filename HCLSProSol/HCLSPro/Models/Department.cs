using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HCLSPro.Models
{
    [Table("Department")]
    public class Department
    {
        [Key]
        public int DeptNo { get; set; }

        public string DName { get; set; }
    }
}
