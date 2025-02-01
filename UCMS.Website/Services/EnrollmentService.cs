using UCMS.Website.Models;

namespace UCMS.Website.Services
{
    public class EnrollmentService : IEnrollmentService
    {
        private readonly ApplicationDbContext _dbContext;
        public EnrollmentService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Enrollment CreateEnrollment(Enrollment enrollment)
        {
            throw new NotImplementedException();
        }

        public string DeleteEnrollment(int id)
        {
            throw new NotImplementedException();
        }

        public Enrollment GetEnrollmentById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Enrollment> GetEnrollments()
        {
            throw new NotImplementedException();
        }

        public Enrollment UpdateEnrollment(Enrollment enrollment)
        {
            throw new NotImplementedException();
        }
    }
}
