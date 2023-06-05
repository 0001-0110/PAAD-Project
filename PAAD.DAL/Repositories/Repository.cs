using Microsoft.EntityFrameworkCore;
using PAAD.DAL.DatabaseContext;
using PAAD.DAL.Extensions;
using PAAD.DAL.Models;
using System.Reflection;

namespace PAAD.DAL.Repositories
{
    public class Repository<T> : IRepository<T> where T : Model
    {
        protected AufgepasstDbContext dbContext;
        private PropertyInfo property;

        public Repository(AufgepasstDbContext dbContext)
        {
            this.dbContext = dbContext;
            property = dbContext.GetType().GetProperty(typeof(DbSet<T>)) ??
                throw new Exception("No corresponding property inside dbContext");
        }

        private DbSet<T> Values => (DbSet<T>)property.GetValue(dbContext)!;

        public virtual bool IdExists(int id)
        {
            return Values.Any(administrator => administrator.Id == id);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return Values;
        }

        public virtual T? GetById(int id)
        {
            return Values.SingleOrDefault(administrator => administrator.Id == id);
        }

        public virtual void Create(T entity)
        {
            Values.Add(entity);
            dbContext.SaveChanges();
        }

        public virtual void Edit(int id, T edit)
        {
            T entity = Values.First(entity => entity.Id == id);
            entity.Edit(edit);
            dbContext.SaveChanges();
        }

        public virtual void Delete(T item)
        {
            Values.Remove(item);
            dbContext.SaveChanges();
        }
    }
}
