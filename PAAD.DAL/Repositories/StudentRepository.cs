using PAAD.DAL.DatabaseContext;
using PAAD.DAL.Models;

namespace PAAD.DAL.Repositories
{
    internal class StudentRepository : IRepository<Student>
    {
        public bool Exists(int id)
        {
            using AufgepasstDbContext dbContext = new AufgepasstDbContext();
            return dbContext.Students.Any(student => student.Id == id);
        }

        public IEnumerable<Student> GetAll()
        {
            using AufgepasstDbContext dbContext = new AufgepasstDbContext();
            return dbContext.Students;
        }

        public Student? GetById(int id)
        {
            using AufgepasstDbContext dbContext = new AufgepasstDbContext();
            return dbContext.Students.SingleOrDefault(student => student.Id == id);
        }

        public void Create(Student entity)
        {
            using AufgepasstDbContext dbContext = new AufgepasstDbContext();
            dbContext.Students.Add(entity);
            dbContext.SaveChanges();
        }

        public void Edit(int id, Student edit)
        {
            using AufgepasstDbContext dbContext = new AufgepasstDbContext();
            throw new NotImplementedException();
            dbContext.SaveChanges();
        }

        public void Delete(Student item)
        {
            using AufgepasstDbContext dbContext = new AufgepasstDbContext();
            dbContext.Students.Remove(item);
            dbContext.SaveChanges();
        }
    }
}
