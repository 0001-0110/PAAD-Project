using PAAD.DAL.Utilities;
using Microsoft.EntityFrameworkCore;
using PAAD.DAL.Models;

namespace PAAD.DAL.DatabaseContext
{
    internal class AufgepasstDbContext : DbContext
    {
        public virtual DbSet<Notification> Notifications { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Lecturer> Lecturers { get; set; }
        public virtual DbSet<Administrator> Administrators { get; set; }
        public virtual DbSet<Course> Courses { get; set; }

        public AufgepasstDbContext() 
            : base(new DbContextOptionsBuilder<AufgepasstDbContext>()
                  .UseSqlServer(ConfigurationUtility.GetConnectionString()).Options) { }

        // TODO Model creation
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Notification>(entity =>
            {
                entity.ToTable($"{nameof(Notification)}s");

                entity.HasKey(notification => notification.Id);

                entity
                    .HasOne(notification => notification.Author)
                    .WithMany()
                    .HasForeignKey(notification => notification.Author.Id)
                    // Don't delete the author when deleting a notification
                    .OnDelete(DeleteBehavior.Restrict);

                entity
                    .HasOne(notification => notification.Course)
                    // A course can have multiple notifications
                    .WithMany()
                    .HasForeignKey(notification => notification.Course.Id)
                    // 
                    .OnDelete(DeleteBehavior.Restrict);

                entity
                    .Property(notification => notification.Title)
                    .HasMaxLength(100);

                entity
                    .Property(notification => notification.Text)
                    .HasMaxLength(500);

                entity
                    .Property(notification => notification.PublishedDateTime)
                    // Set default value for UTC datetime
                    .HasDefaultValueSql("GETUTCDATE()");

                entity
                    .Property(notification => notification.ExpirationDateTime)
                    .IsRequired();
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable($"{nameof(Student)}s");
            });

            modelBuilder.Entity<Lecturer>(entity =>
            {
                entity.ToTable($"{nameof(Lecturer)}s");
            });

            modelBuilder.Entity<Administrator>(entity =>
            {
                entity.ToTable($"{nameof(Administrator)}s");
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.ToTable($"{nameof(Course)}s");
            });
        }
    }
}
