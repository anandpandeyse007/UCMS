using UCMS.Website.Models;

namespace UCMS.Website.Services
{
    public interface ICourseService
    {
        public List<Course> GetCourses();
        public Course GetCourseById(int id);
        public Course CreateCourse(Course enrollment);
        public Course UpdateCourse(Course enrollment);
        public string DeleteCourse(int id);
    }
}
