namespace PAAD.DAL.Repositories
{
    internal interface IRepository<T>
    {
        // TODO
        public IEnumerable<T> GetAll();

        public T? GetById(int id);

        public void Create(T entity);

        public void Edit(int id, T edit);

        public void Delete(T item);
    }
}
