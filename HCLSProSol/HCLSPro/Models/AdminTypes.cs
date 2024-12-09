using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HCLSPro.Models
{
    [ Table ("AdminTypes")]
    public class AdminTypes
    {
        [Key]
        public int AdminTypeId { get; set; }
        public String AdminTypeName { get; set; }

      public ICollection<Admin> Admin { get; set; }
    }
}
