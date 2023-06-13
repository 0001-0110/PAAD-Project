using PAAD.DAL.Models;

namespace PAAD.DAL.Repositories
{
    public interface IRepository
    {
        public bool IdExists(int id);
    }

    public interface IRepository<T> : IRepository where T : Model
    {
        public IEnumerable<T> GetAll();

        public T? GetById(int id);

        public void Create(T entity);

        public void Edit(int id, T edit);

        public void Delete(T item);
    }
}
