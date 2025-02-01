using System.ComponentModel.DataAnnotations;

namespace UCMS.Website.Models
{
    public class Enrollment
    {
        [Key]
        public int EnrollmentId { get; set; }
        public int StudentId { get; set; }
        [Required]
        public int CourseId { get; set; }
        [Required]
        public string Progress { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
        public DateTime LastDate { get; set; }
        public bool Status { get; set; } = true;

        //Navigation Properties
        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
