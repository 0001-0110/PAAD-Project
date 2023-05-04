using PAAD.DAL.Models;

namespace PAAD.DAL.Repositories
{
    internal interface IRepository<T> where T : Model
    {
        public IEnumerable<T> GetAll();

        public T? GetById(int id);

        public void Create(T entity);

        public void Edit(int id, T edit);

        public void Delete(T item);
    }
}
