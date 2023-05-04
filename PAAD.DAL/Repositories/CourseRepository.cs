using PAAD.DAL.DatabaseContext;
using PAAD.DAL.Extensions;
using PAAD.DAL.Models;

namespace PAAD.DAL.Repositories
{
    public class CourseRepository : IRepository<Course>
    {
        public bool IdExists(int id)
        {
            using AufgepasstDbContext dbContext = new AufgepasstDbContext();
            return dbContext.Courses.Any(course => course.Id == id);
        }

        public IEnumerable<Course> GetAll()
        {
            using AufgepasstDbContext dbContext = new AufgepasstDbContext();
            return dbContext.Courses;
        }

        public Course? GetById(int id)
        {
            using AufgepasstDbContext dbContext = new AufgepasstDbContext();
            return dbContext.Courses.SingleOrDefault(course => course.Id == id);
        }

        public void Create(Course entity)
        {
            using AufgepasstDbContext dbContext = new AufgepasstDbContext();
            dbContext.Courses.Add(entity);
            dbContext.SaveChanges();
        }

        public void Edit(int id, Course edit)
        {
            using AufgepasstDbContext dbContext = new AufgepasstDbContext();
            Course course = dbContext.Courses.Single(course => course.Id == id);
            course.Edit(edit);
            dbContext.SaveChanges();
        }

        public void Delete(Course item)
        {
            using AufgepasstDbContext dbContext = new AufgepasstDbContext();
            dbContext.Courses.Remove(item);
            dbContext.SaveChanges();
        }
    }
}
