using UCMS.Website.Models;

namespace UCMS.Website.Services
{
    public interface IAnnouncementService
    {
        public List<Announcement> GetAnnouncements();
        public Announcement GetAnnouncementById(int id);
        public Announcement CreateAnnouncement(Announcement enrollment);
        public Announcement UpdateAnnouncement(Announcement enrollment);
        public string DeleteAnnouncement(int id);
    }
}
