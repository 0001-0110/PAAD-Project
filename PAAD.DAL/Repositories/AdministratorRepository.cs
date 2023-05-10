using PAAD.DAL.DatabaseContext;
using PAAD.DAL.Extensions;
using PAAD.DAL.Models;

namespace PAAD.DAL.Repositories
{
    public class AdministratorRepository : Repository<Administrator>
    {
        public AdministratorRepository(AufgepasstDbContext dbContext) : base(dbContext) { }

        public override bool IdExists(int id)
        {
            return dbContext.Administrators.Any(administrator => administrator.Id == id);
        }

        public override IEnumerable<Administrator> GetAll()
        {
            return dbContext.Administrators;
        }

        public override Administrator? GetById(int id)
        {
            return dbContext.Administrators.SingleOrDefault(administrator => administrator.Id == id);
        }

        public override void Create(Administrator entity)
        {
            dbContext.Administrators.Add(entity);
            dbContext.SaveChanges();
        }

        public override void Edit(int id, Administrator edit)
        {
            Administrator administrator = dbContext.Administrators.First(administrator => administrator.Id == id);
            administrator.Edit(edit);
            dbContext.SaveChanges();
        }

        public override void Delete(Administrator item)
        {
            dbContext.Administrators.Remove(item);
            dbContext.SaveChanges();
        }
    }
}
