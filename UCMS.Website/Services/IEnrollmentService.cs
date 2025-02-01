using UCMS.Website.Models;

namespace UCMS.Website.Services
{
    public interface IEnrollmentService
    {
        public List<Enrollment> GetEnrollments();
        public Enrollment GetEnrollmentById(int id);
        public Enrollment CreateEnrollment(Enrollment enrollment);
        public Enrollment UpdateEnrollment(Enrollment enrollment);
        public string DeleteEnrollment(int id);
    }
}
