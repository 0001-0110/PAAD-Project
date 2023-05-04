using PAAD.DAL.DatabaseContext;
using PAAD.DAL.Extensions;
using PAAD.DAL.Models;

namespace PAAD.DAL.Repositories
{
    public class LecturerRepository : IRepository<Lecturer>
    {
        public bool IdExists(int id)
        {
            using AufgepasstDbContext dbContext = new AufgepasstDbContext();
            return dbContext.Lecturers.Any(lecturer => lecturer.Id == id);
        }

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
            Lecturer lecturer = dbContext.Lecturers.Single(lecturer => lecturer.Id == id);
            lecturer.Edit(edit);
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
