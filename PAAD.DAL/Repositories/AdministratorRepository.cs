using PAAD.DAL.DatabaseContext;
using PAAD.DAL.Models;

namespace PAAD.DAL.Repositories
{
    public class AdministratorRepository : IRepository<Administrator>
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

        public void Create(Administrator entity)
        {
            using AufgepasstDbContext dbContext = new AufgepasstDbContext();
            dbContext.Administrators.Add(entity);
            dbContext.SaveChanges();
        }

        public void Edit(int id, Administrator edit)
        {
            using AufgepasstDbContext dbContext = new AufgepasstDbContext();
            Administrator administrator = dbContext.Administrators.First(administrator => administrator.Id == id);
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
