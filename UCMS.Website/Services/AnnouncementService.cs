using UCMS.Website.Models;

namespace UCMS.Website.Services
{
    public class AnnouncementService : IAnnouncementService
    {
        private readonly ApplicationDbContext _dbContext;
        public AnnouncementService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Announcement CreateAnnouncement(Announcement enrollment)
        {
            throw new NotImplementedException();
        }

        public string DeleteAnnouncement(int id)
        {
            throw new NotImplementedException();
        }

        public Announcement GetAnnouncementById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Announcement> GetAnnouncements()
        {
            throw new NotImplementedException();
        }

        public Announcement UpdateAnnouncement(Announcement enrollment)
        {
            throw new NotImplementedException();
        }
    }
}
