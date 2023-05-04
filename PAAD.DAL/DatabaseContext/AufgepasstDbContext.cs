using Microsoft.EntityFrameworkCore;
using PAAD.DAL.Models;
using PAAD.DAL.Utilities;

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

            /*modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable($"{nameof(Student)}s");

                entity.HasKey(student => student.Id);

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
                    .IsRequired();

                entity
                    .Property(user => user.PasswordHash)
                    .HasMaxLength(256)
                    .IsRequired();

                // Configure the relationship between User and Notification
                entity
                    .HasMany(user => user.Notifications)
                    .WithOne(notification => notification.Author)
                    .HasForeignKey(notification => notification.AuthorId)
                    .OnDelete(DeleteBehavior.Restrict);
            });*/

            modelBuilder.Entity<Lecturer>(entity =>
            {
                entity.ToTable($"{nameof(Lecturer)}s");

                entity.HasKey(lecturer => lecturer.Id);

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
                    .IsRequired();

                entity
                    .Property(user => user.PasswordHash)
                    .HasMaxLength(256)
                    .IsRequired();

                // Configure the relationship between User and Notification
                entity
                    .HasMany(user => user.Notifications)
                    .WithOne(notification => (Lecturer)notification.Author)
                    .HasForeignKey(notification => notification.Author.Id)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Administrator>(entity =>
            {
                entity.ToTable($"{nameof(Administrator)}s");

                entity.HasKey(administrator => administrator.Id);

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
                    .IsRequired();

                entity
                    .Property(user => user.PasswordHash)
                    .HasMaxLength(256)
                    .IsRequired();

                // Configure the relationship between User and Notification
                entity
                    .HasMany(user => user.Notifications)
                    .WithOne(notification => (Administrator)notification.Author)
                    .HasForeignKey(notification => notification.Author.Id)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.ToTable($"{nameof(Course)}s");

                entity.HasKey(course => course.Id);

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
                    .HasForeignKey(notification => notification.Course.Id)
                    .OnDelete(DeleteBehavior.Restrict);
            });
        }
    }
}
