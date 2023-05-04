using PAAD.DAL.DatabaseContext;
using PAAD.DAL.Models;

namespace PAAD.DAL.Repositories
{
    internal class LecturerRepository : IRepository<Lecturer>
    {

        public IEnumerable<Lecturer> GetAll()
        {
            using AufgepasstDbContext dbContext = new AufgepasstDbContext();
            return dbContext.Lecturers;
        }

        public Lecturer? GetById(int id)
        {
            using AufgepasstDbContext dbContext = new AufgepasstDbContext();
            return dbContext.Lecturers.SingleOrDefault(lecturer => lecturer.Id == id);
        }

        public void Create(Lecturer entity)
        {
            using AufgepasstDbContext dbContext = new AufgepasstDbContext();
            dbContext.Lecturers.Add(entity);
            dbContext.SaveChanges();
        }

        public void Edit(int id, Lecturer edit)
        {
            using AufgepasstDbContext dbContext = new AufgepasstDbContext();
            throw new NotImplementedException();
            dbContext.SaveChanges();
        }

        public void Delete(Lecturer item)
        {
            using AufgepasstDbContext dbContext = new AufgepasstDbContext();
            dbContext.Remove(item);
            dbContext.SaveChanges();
        }
    }
}
