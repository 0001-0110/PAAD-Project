using PAAD.DAL.Models;

namespace PAAD.DAL.Repositories
{
    public class RepositoryCollection : IRepositoryCollection
    {
        private Dictionary<Type, IRepository> repositories;

        public RepositoryCollection(
            IRepository<Notification> notificationRepository,
            IRepository<Lecturer> lecturerRepository,
            IRepository<Administrator> administratorRepository,
            IRepository<Course> courseRepository)
        {
            repositories = new Dictionary<Type, IRepository>()
            {
                [typeof(Notification)] = notificationRepository,
                //[typeof(Student)] = studentRepository,
                [typeof(Lecturer)] = lecturerRepository,
                [typeof(Administrator)] = administratorRepository,
                [typeof(Course)] = courseRepository,
            };
        }

        public IRepository<T> GetRepository<T>() where T : Model
        {
            IRepository? repository;

            if (!repositories.TryGetValue(typeof(T), out repository))
                throw new KeyNotFoundException();

            return (IRepository<T>)repository;
        }
    }
}
