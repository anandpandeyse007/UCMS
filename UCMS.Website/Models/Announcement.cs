using System.ComponentModel.DataAnnotations;

namespace UCMS.Website.Models
{
    public class Announcement
    {
        [Key]
        public int AnnouncementId { get; set; }
        [Required(ErrorMessage ="Description is required.")]
        public string Description { get;set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
