using PAAD.DAL.Models;
using PAAD.DAL.Repositories;

namespace PAAD.BLL.Services
{
    public class DataService
    {
        public static readonly DataService Instance = new DataService();

        private Dictionary<Type, object> repositories;

        private DataService()
        {
            repositories = new Dictionary<Type, object>()
            {
                [typeof(Notification)] = new NotificationRepository(),
                //[typeof(Student)] = new StudentRepository(),
                [typeof(Lecturer)] = new LecturerRepository(),
                [typeof(Administrator)] = new AdministratorRepository(),
                [typeof(Course)] = new CourseRepository(),
            };
        }

        #region Call to repositories

        private IRepository<T> GetRepository<T>() where T : Model
        {
            object? repository;

            if (!repositories.TryGetValue(typeof(T), out repository))
                throw new KeyNotFoundException();

            return (IRepository<T>)repository;
        }

        public IEnumerable<T> GetAll<T>() where T : Model
        {
            return GetRepository<T>().GetAll();
        }

        public T? GetById<T>(int id) where T : Model
        {
            return GetRepository<T>().GetById(id);
        }

        public bool Create<T>(T entity) where T : Model
        {
            IRepository<T> repository = GetRepository<T>();

            // If there already is an object with the same Id, we can't create it
            if (repository.IdExists(entity.Id))
                return false;

            repository.Create(entity);
            return true;
        }

        public bool Edit<T>(int id, T entity) where T : Model
        {
            IRepository<T> repository = GetRepository<T>();

            if (!repository.IdExists(id))
                return false;

            repository.Edit(id, entity);
            return true;
        }

        public bool Delete<T>(int id) where T : Model
        {
            IRepository<T> repository = GetRepository<T>();

            if (!repository.IdExists(id))
                return false;

            repository.Delete(repository.GetById(id)!);
            return true;
        }

        #endregion

        public IEnumerable<User> GetAllUsers()
        {
            return GetAll<Lecturer>().Cast<User>().Concat(GetAll<Administrator>());
            //return GetAll<Student>().Cast<User>().GetAll<Lecturer>().Cast<User>().Concat(GetAll<Administrator>());
        }
    }
}
