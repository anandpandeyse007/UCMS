using UCMS.Website.Models;

namespace UCMS.Website.Services
{
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext _dbContext;
        public UserService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public User CreateUser(User user)
        {
            throw new NotImplementedException();
        }

        public string DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public User GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetUsers()
        {
            throw new NotImplementedException();
        }

        public User UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
