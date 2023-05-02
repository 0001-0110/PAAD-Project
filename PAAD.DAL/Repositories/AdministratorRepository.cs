using PAAD.DAL.DatabaseContext;
using PAAD.DAL.Models;

namespace PAAD.DAL.Repositories
{
    internal class AdministratorRepository : IRepository<Administrator>
    {

        public IEnumerable<Administrator> GetAll()
        {
            using AufgepasstDbContext dbContext = new AufgepasstDbContext();
            return dbContext.Administrators;
        }

        public Administrator? GetById(int id)
        {
            using AufgepasstDbContext dbContext = new AufgepasstDbContext();
            return dbContext.Administrators.SingleOrDefault(administrator => administrator.Id == id);
        }

        public Administrator Create(Administrator entity)
        {
            using AufgepasstDbContext dbContext = new AufgepasstDbContext();
            dbContext.Administrators.Add(entity);
            dbContext.SaveChanges();
            return entity;
        }

        public Administrator Edit(int id, Administrator edit)
        {
            using AufgepasstDbContext dbContext = new AufgepasstDbContext();
            throw new NotImplementedException();
            dbContext.SaveChanges();
        }

        public void Delete(Administrator item)
        {
            using AufgepasstDbContext dbContext = new AufgepasstDbContext();
            dbContext.Administrators.Remove(item);
            dbContext.SaveChanges();
        }
    }
}
