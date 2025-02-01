using UCMS.Website.Models;

namespace UCMS.Website.Services
{
    public interface IStudentService
    {
        public List<Student> GetAllStudents();
        public Student GetStudent(int id);
        public Student CreateStudent(Student student);
        public Student UpdateStudent(Student student);
        public string DeleteStudent(int id);
    }
}
