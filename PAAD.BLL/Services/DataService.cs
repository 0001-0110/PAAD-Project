using PAAD.DAL.Models;
using PAAD.DAL.Repositories;

namespace PAAD.BLL.Services
{
    public class DataService
    {
        public static readonly DataService Instance = new DataService();

        private Dictionary<Type, IRepository<Model>> repositories;

        private DataService() 
        {
            repositories = new Dictionary<Type, IRepository<Model>>()
            {
                [typeof(Notification)] = (IRepository<Model>)new NotificationRepository(),
                //[typeof(Student)] = (IRepository<Model>)new StudentRepository(),
                [typeof(Lecturer)] = (IRepository<Model>)new LecturerRepository(),
                [typeof(Administrator)] = (IRepository<Model>)new AdministratorRepository(),
                [typeof(Course)] = (IRepository<Model>)new CourseRepository(),
            };
        }

        private IRepository<T> GetRepository<T>() where T : Model
        {
            IRepository<Model>? repository;

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
    }
}
