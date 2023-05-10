using Microsoft.EntityFrameworkCore;
using PAAD.DAL.DatabaseContext;
using PAAD.DAL.Models;

namespace PAAD.DAL.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : Model
    {
        protected AufgepasstDbContext dbContext;

        public Repository(AufgepasstDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public abstract bool IdExists(int id);

        public abstract IEnumerable<T> GetAll();

        public abstract T? GetById(int id);

        public abstract void Create(T entity);

        public abstract void Edit(int id, T edit);

        public abstract void Delete(T item);
    }
}
