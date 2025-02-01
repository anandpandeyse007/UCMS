using System.ComponentModel.DataAnnotations;

namespace UCMS.Website.Models
{
    public class User
    {
        public int UserId { get; set; }

        [Required(ErrorMessage = "Username is required.")]
        [MinLength(5)]
        public string Username { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password is required.")]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;
        public bool Status { get; set; } = true;

        public int RoleId { get; set; }
    }
}
