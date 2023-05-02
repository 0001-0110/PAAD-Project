namespace PAAD.DAL.Repositories
{
    internal interface IRepository<T>
    {
        // TODO
        public IEnumerable<T> GetAll();

        public T? GetById(int id);

        public T Create(T entity);

        public T? Edit(int id, T edit);

        public void Delete(T item);
    }
}
