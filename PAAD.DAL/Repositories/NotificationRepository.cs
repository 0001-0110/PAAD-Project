using PAAD.DAL.DatabaseContext;
using PAAD.DAL.Models;

namespace PAAD.DAL.Repositories
{


    public class NotificationRepository : Repository<Notification>
    {
        public NotificationRepository(AufgepasstDbContext dbContext) : base(dbContext) { }

        private void DeleteExpired()
        {
            DateTime currentDate = DateTime.Now;
            IEnumerable<Notification> expiredNotifications = dbContext.Notifications
                .Where(notification => notification.ExpirationDateTime < currentDate);

            if (expiredNotifications.Any())
            {
                dbContext.Notifications.RemoveRange(expiredNotifications);
                dbContext.SaveChanges();
            }
        }

        public override bool IdExists(int id)
        {
            DeleteExpired();
            return base.IdExists(id);
        }

        public override IEnumerable<Notification> GetAll()
        {
            DeleteExpired();
            return base.GetAll();
        }

        public override Notification? GetById(int id)
        {
            DeleteExpired();
            return base.GetById(id);
        }
    }
}
