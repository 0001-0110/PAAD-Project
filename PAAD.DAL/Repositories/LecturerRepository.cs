using PAAD.DAL.DatabaseContext;
using PAAD.DAL.Extensions;
using PAAD.DAL.Models;

namespace PAAD.DAL.Repositories
{
    public class LecturerRepository : Repository<Lecturer>
    {
        public LecturerRepository(AufgepasstDbContext dbContext) : base(dbContext) { }

        public override bool IdExists(int id)
        {
            return dbContext.Lecturers.Any(lecturer => lecturer.Id == id);
        }

        public override IEnumerable<Lecturer> GetAll()
        {
            return dbContext.Lecturers;
        }

        public override Lecturer? GetById(int id)
        {
            return dbContext.Lecturers.SingleOrDefault(lecturer => lecturer.Id == id);
        }

        public override void Create(Lecturer entity)
        {
            dbContext.Lecturers.Add(entity);
            dbContext.SaveChanges();
        }

        public override void Edit(int id, Lecturer edit)
        {
            Lecturer lecturer = dbContext.Lecturers.Single(lecturer => lecturer.Id == id);
            lecturer.Edit(edit);
            dbContext.SaveChanges();
        }

        public override void Delete(Lecturer item)
        {
            dbContext.Remove(item);
            dbContext.SaveChanges();
        }
    }
}
