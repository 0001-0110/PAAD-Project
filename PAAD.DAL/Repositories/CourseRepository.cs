using PAAD.DAL.DatabaseContext;
using PAAD.DAL.Extensions;
using PAAD.DAL.Models;

namespace PAAD.DAL.Repositories
{
    public class CourseRepository : Repository<Course>
    {
        public CourseRepository(AufgepasstDbContext dbContext) : base(dbContext) { }

        public override bool IdExists(int id)
        {
            return dbContext.Courses.Any(course => course.Id == id);
        }

        public override IEnumerable<Course> GetAll()
        {
            return dbContext.Courses;
        }

        public override Course? GetById(int id)
        {
            return dbContext.Courses.SingleOrDefault(course => course.Id == id);
        }

        public override void Create(Course entity)
        {
            dbContext.Courses.Add(entity);
            dbContext.SaveChanges();
        }

        public override void Edit(int id, Course edit)
        {
            Course course = dbContext.Courses.Single(course => course.Id == id);
            course.Edit(edit);
            dbContext.SaveChanges();
        }

        public override void Delete(Course item)
        {
            dbContext.Courses.Remove(item);
            dbContext.SaveChanges();
        }
    }
}
