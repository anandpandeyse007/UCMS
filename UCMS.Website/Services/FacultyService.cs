using UCMS.Website.Models;

namespace UCMS.Website.Services
{
    public class FacultyService : IFacultyService
    {
        private readonly ApplicationDbContext _dbContext;
        public FacultyService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Faculty CreateFaculty(Faculty faculty)
        {
            try
            {
                _dbContext.Faculty.Add(faculty);
                _dbContext.SaveChanges();

                return faculty;
            }
            catch (Exception ex) 
            { 

            }
            return null;
        }

        public string DeleteFaculty(int id)
        {
            throw new NotImplementedException();
        }

        public List<Faculty> GetFaculties()
        {
            List<Faculty> faculties = _dbContext.Faculty.ToList();
            return faculties;
        }

        public Faculty GetFacultyById(int id)
        {
            Faculty faculty = _dbContext.Faculty.Find(id);
            return faculty;
        }

        public Faculty UpdateFaculty(Faculty faculty)
        {
            throw new NotImplementedException();
        }
    }
}
