using PAAD.DAL.Models;
using PAAD.DAL.Repositories;

namespace PAAD.BLL.Services
{
    public class DataService : IDataService
    {
        private IRepositoryCollection repositoryCollection;

        public DataService(IRepositoryCollection repositoryCollection)
        {
            this.repositoryCollection = repositoryCollection;
        }

        public IEnumerable<T> GetAll<T>() where T : Model
        {
            return repositoryCollection.GetRepository<T>().GetAll();
        }

        public T? GetById<T>(int id) where T : Model
        {
            return repositoryCollection.GetRepository<T>().GetById(id);
        }

        public bool Create<T>(T entity) where T : Model
        {
            IRepository<T> repository = repositoryCollection.GetRepository<T>();

            // If there already is an object with the same Id, we can't create it
            if (repository.IdExists(entity.Id))
                return false;

            repository.Create(entity);
            return true;
        }

        public bool Edit<T>(int id, T entity) where T : Model
        {
            IRepository<T> repository = repositoryCollection.GetRepository<T>();

            if (!repository.IdExists(id))
                return false;

            repository.Edit(id, entity);
            return true;
        }

        public bool Delete<T>(int id) where T : Model
        {
            IRepository<T> repository = repositoryCollection.GetRepository<T>();

            if (!repository.IdExists(id))
                return false;

            repository.Delete(repository.GetById(id)!);
            return true;
        }
    }
}
