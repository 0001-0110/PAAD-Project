﻿using PAAD.DAL.DatabaseContext;
using PAAD.DAL.Models;

namespace PAAD.DAL.Repositories
{
    internal class NotificationRepository : IRepository<Notification>
    {
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

        public Notification Create(Notification entity)
        {
            using AufgepasstDbContext dbContext = new AufgepasstDbContext();
            dbContext.Notifications.Add(entity);
            dbContext.SaveChanges();
            return entity;
        }

        public Notification? Edit(int id, Notification edit)
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
