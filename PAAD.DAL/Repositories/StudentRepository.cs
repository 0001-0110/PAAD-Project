using PAAD.DAL.DatabaseContext;
using PAAD.DAL.Extensions;
using PAAD.DAL.Models;

namespace PAAD.DAL.Repositories
{
    internal class StudentRepository : Repository<Student>
    {
        public StudentRepository(AufgepasstDbContext dbContext) : base(dbContext) { }

        public override bool IdExists(int id)
        {
            return dbContext.Students.Any(student => student.Id == id);
        }

        public override IEnumerable<Student> GetAll()
        {
            return dbContext.Students;
        }

        public override Student? GetById(int id)
        {
            return dbContext.Students.Single(student => student.Id == id);
        }

        public override void Create(Student entity)
        {
            dbContext.Students.Add(entity);
            dbContext.SaveChanges();
        }

        public override void Edit(int id, Student edit)
        {
            Student student = dbContext.Students.Single(student => student.Id == id);
            student.Edit(edit);
            dbContext.SaveChanges();
        }

        public override void Delete(Student item)
        {
            dbContext.Students.Remove(item);
            dbContext.SaveChanges();
        }
    }
}
