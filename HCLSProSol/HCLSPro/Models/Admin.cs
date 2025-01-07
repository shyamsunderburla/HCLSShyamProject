using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HCLSPro.Models
{
    [Table ("Admin")]
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }

        public String AdminName { get; set; }
        public String Gender { get; set; }
        public String Phone { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
        public String Address { get; set; }
        public String Id_Proof { get; set; }
        public bool ActiveStatus { get; set; }

        [ForeignKey ("AdminTypes")]
        public int AdminTypeId { get; set; }

        public AdminTypes? AdminTypes  {  get; set; }
    }
}
