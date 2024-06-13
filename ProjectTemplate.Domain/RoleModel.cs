using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectTemplate.Domain
{
    [Table("Role_Mstr_tbl")]
    public class RoleModel
    {
        [Key]
        public int Role_Mstr_ID { get; set; }
        public int Role_Mstr_Code { get; set; }
        public string Role_Mstr_Name { get; set; }
        public string Role_Mstr_LandingPage { get; set; }
        public DateTime Role_Mstr_CreatedDate { get; set; }
        public int? Role_Mstr_CreatedBy { get; set; }
        public DateTime Role_Mstr_ModDate { get; set; }
        public int? Role_Mstr_ModBy { get; set; }
        public bool Role_Mstr_IsActive { get; set; }
        public string Role_Mstr_Description { get; set; }
    }
}
