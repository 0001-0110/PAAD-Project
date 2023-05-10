using PAAD.DAL.DatabaseContext;
using PAAD.DAL.Extensions;
using PAAD.DAL.Models;

namespace PAAD.DAL.Repositories
{
    public class NotificationRepository : Repository<Notification>
    {
        public NotificationRepository(AufgepasstDbContext dbContext) : base(dbContext) { }

        public override bool IdExists(int id)
        {
            return dbContext.Notifications.Any(notification => notification.Id == id);
        }

        public override IEnumerable<Notification> GetAll()
        {
            return dbContext.Notifications;
        }

        public override Notification? GetById(int id)
        {
            return dbContext.Notifications.SingleOrDefault(notification => notification.Id == id);
        }

        public override void Create(Notification entity)
        {
            dbContext.Notifications.Add(entity);
            dbContext.SaveChanges();
        }

        public override void Edit(int id, Notification edit)
        {
            Notification notification = dbContext.Notifications.Single(notification => notification.Id == id);
            notification.Edit(edit);
            dbContext.SaveChanges();
        }

        public override void Delete(Notification item)
        {
            dbContext.Notifications.Remove(item);
            dbContext.SaveChanges();
        }
    }
}
