using Microsoft.EntityFrameworkCore;
using PAAD.DAL.Models;

namespace PAAD.DAL.DatabaseContext
{
    internal class AufgepasstDbContext : DbContext
    {
        public virtual DbSet<Notification> Notifications { get; set; }
        public virtual DbSet<Lecturer> Lecturers { get; set; }
        public virtual DbSet<Course> Courses { get; set; }

        // TODO Get connection string
        public AufgepasstDbContext() : base(new DbContextOptionsBuilder<AufgepasstDbContext>().UseSqlServer("").Options) { }
    }
}
