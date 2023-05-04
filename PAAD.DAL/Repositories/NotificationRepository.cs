using PAAD.DAL.DatabaseContext;
using PAAD.DAL.Models;

namespace PAAD.DAL.Repositories
{
    public class NotificationRepository : IRepository<Notification>
    {
        public bool Exists(int id)
        {
            using AufgepasstDbContext dbContext = new AufgepasstDbContext();
            return dbContext.Notifications.Any(notification => notification.Id == id);
        }

        public IEnumerable<Notification> GetAll()
        {
            using AufgepasstDbContext dbContext = new AufgepasstDbContext();
            return dbContext.Notifications;
        }

        public Notification? GetById(int id)
        {
            using AufgepasstDbContext dbContext = new AufgepasstDbContext();
            return dbContext.Notifications.SingleOrDefault(notification => notification.Id == id);
        }

        public void Create(Notification entity)
        {
            using AufgepasstDbContext dbContext = new AufgepasstDbContext();
            dbContext.Notifications.Add(entity);
            dbContext.SaveChanges();
        }

        public void Edit(int id, Notification edit)
        {
            using AufgepasstDbContext dbContext = new AufgepasstDbContext();
            throw new NotImplementedException();
            dbContext.SaveChanges();
        }

        public void Delete(Notification item)
        {
            using AufgepasstDbContext dbContext = new AufgepasstDbContext();
            dbContext.Notifications.Remove(item);
            dbContext.SaveChanges();
        }
    }
}
