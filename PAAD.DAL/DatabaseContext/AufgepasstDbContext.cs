using Microsoft.EntityFrameworkCore;
using PAAD.DAL.Models;
using PAAD.DAL.Utilities;

namespace PAAD.DAL.DatabaseContext
{
    public class AufgepasstDbContext : DbContext
    {
        public virtual DbSet<Notification> Notifications { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Lecturer> Lecturers { get; set; }
        public virtual DbSet<Administrator> Administrators { get; set; }
        public virtual DbSet<Course> Courses { get; set; }

        public AufgepasstDbContext()
            : base(new DbContextOptionsBuilder<AufgepasstDbContext>()
                  .UseSqlServer(ConfigurationUtility.GetConnectionString()).Options)
        {
#if DEBUG
            Database.EnsureDeleted();
#endif
            Database.EnsureCreated();
#if DEBUG
            AddTestingData();
#endif
        }

        private void AddTestingData()
        {
            // Add courses
            Course courseJava = new Course
            {
                Name = "Java"
            };
            Course courseOOPNET = new Course
            {
                Name = "OOPNET"
            };
            Course coursePM = new Course
            {
                Name = "Project management"
            };
            Courses.Add(courseJava);
            Courses.Add(courseOOPNET);
            Courses.Add(coursePM);
            SaveChanges();

            // Add users
            Administrator userAdmin = new Administrator
            {
                FirstName = "Amin",
                LastName = "Istrator",
                Email = "admin",
                // Password is test
                PasswordHash = new byte[] { 159, 134, 208, 129, 136, 76, 125, 101, 154, 47, 234, 160, 197, 90, 208, 21, 163, 191, 79, 27, 43, 11, 130, 44, 209, 93, 108, 21, 176, 240, 10, 8 },
            };
            Lecturer userJava = new Lecturer
            {
                FirstName = "Lecturer",
                LastName = "Java",
                Email = "java",
                CourseId = 1,
                // Password is test
                PasswordHash = new byte[] { 159, 134, 208, 129, 136, 76, 125, 101, 154, 47, 234, 160, 197, 90, 208, 21, 163, 191, 79, 27, 43, 11, 130, 44, 209, 93, 108, 21, 176, 240, 10, 8 },
            };
            Lecturer userOOPNET = new Lecturer
            {
                FirstName = "Lecturer",
                LastName = "OOPNET",
                Email = "oopnet",
                CourseId = 2,
                // Password is test
                PasswordHash = new byte[] { 159, 134, 208, 129, 136, 76, 125, 101, 154, 47, 234, 160, 197, 90, 208, 21, 163, 191, 79, 27, 43, 11, 130, 44, 209, 93, 108, 21, 176, 240, 10, 8 },
            };
            Lecturer userPM = new Lecturer
            {
                FirstName = "Lecturer",
                LastName = "ProjectManagement",
                Email = "pm",
                CourseId = 3,
                // Password is test
                PasswordHash = new byte[] { 159, 134, 208, 129, 136, 76, 125, 101, 154, 47, 234, 160, 197, 90, 208, 21, 163, 191, 79, 27, 43, 11, 130, 44, 209, 93, 108, 21, 176, 240, 10, 8 },
            };
            Administrators.Add(userAdmin);
            Lecturers.Add(userJava);
            Lecturers.Add(userOOPNET);
            Lecturers.Add(userPM);
            SaveChanges();

            // Add notifs
            Notifications.Add(new Notification
            {
                Title = "Test in java next week",
                Text = "Review TP8-12",
                AuthorId = userJava.Id,
                CourseId = courseJava.Id,
                ExpirationDateTime = DateTime.Today + TimeSpan.FromDays(15)
            });
            Notifications.Add(new Notification
            {
                Title = "Homework",
                Text = "Finish p89 before our next class please",
                AuthorId = userJava.Id,
                CourseId = courseJava.Id,
                ExpirationDateTime = DateTime.Today + TimeSpan.FromDays(15)
            });
            Notifications.Add(new Notification
            {
                Title = "Coffee party",
                Text = "It's free",
                AuthorId = userPM.Id,
                CourseId = coursePM.Id,
                ExpirationDateTime = DateTime.Today + TimeSpan.FromDays(15)
            });
            Notifications.Add(new Notification
            {
                Title = "What a notif",
                Text = "published in oopnet if it's good",
                AuthorId = userOOPNET.Id,
                CourseId = courseOOPNET.Id,
                ExpirationDateTime = DateTime.Today + TimeSpan.FromDays(15)
            });
            SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // This sets the primary key for all models
            modelBuilder.Entity<Model>(entity =>
            {
                entity.HasKey(model => model.Id);
            });

            modelBuilder.Entity<Notification>(entity =>
            {
                entity.ToTable($"{nameof(Notification)}s");

                entity
                    .HasOne(notification => notification.Author)
                    .WithMany(author => author.Notifications)
                    .HasForeignKey(notification => notification.AuthorId)
                    // Don't delete the author when deleting a notification
                    .OnDelete(DeleteBehavior.NoAction);

                entity
                    .HasOne(notification => notification.Course)
                    // A course can have multiple notifications
                    .WithMany(course => course.Notifications)
                    .HasForeignKey(notification => notification.CourseId)
                    // 
                    .OnDelete(DeleteBehavior.NoAction);

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

            modelBuilder.Entity<User>(entity =>
            {
                entity
                    .Property(user => user.FirstName)
                    .HasMaxLength(50)
                    .IsRequired();

                entity
                    .Property(user => user.LastName)
                    .HasMaxLength(50)
                    .IsRequired();

                entity
                    .Property(user => user.Email)
                    .HasMaxLength(256)
                    //.HasAnnotation()
                    .IsRequired();

                entity
                    .Property(user => user.PasswordHash)
                    .HasMaxLength(256)
                    .IsRequired();

                // Configure the relationship between User and Notification
                entity
                    .HasMany(user => user.Notifications)
                    .WithOne(notification => (Lecturer)notification.Author)
                    .HasForeignKey(notification => notification.AuthorId)
                    .OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable($"{nameof(Student)}s");

                entity
                    .HasMany(student => student.Courses)
                    .WithMany(course => course.Students);
            });

            modelBuilder.Entity<Lecturer>(entity =>
            {
                entity.ToTable($"{nameof(Lecturer)}s");

                entity
                    .HasOne(lecturer => lecturer.Course)
                    .WithMany(course => course.Lecturers)
                    .HasForeignKey(lecturer => lecturer.CourseId)
                    .OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Entity<Administrator>(entity =>
            {
                entity.ToTable($"{nameof(Administrator)}s");
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.ToTable($"{nameof(Course)}s");

                entity
                    .Property(course => course.Name)
                    .HasMaxLength(100)
                    .IsRequired();

                // Configure the relationship between Course and Lecturer
                entity
                    .HasMany(course => course.Lecturers)
                    .WithOne(lecturer => lecturer.Course);

                // Configure the relationship between Course and Notification
                entity
                    .HasMany(course => course.Notifications)
                    .WithOne(notification => notification.Course)
                    .HasForeignKey(notification => notification.CourseId)
                    .OnDelete(DeleteBehavior.NoAction);
            });
        }
    }
}
