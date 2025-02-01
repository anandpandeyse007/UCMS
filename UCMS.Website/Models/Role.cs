using System.ComponentModel.DataAnnotations;

namespace UCMS.Website.Models
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }
        public string RoleName { get; set; } = string.Empty;
    }
}
