using PAAD.DAL.Models;

namespace PAAD.DAL.Repositories
{
    public interface IRepositoryCollection
    {
        public IRepository<T> GetRepository<T>() where T : Model;
    }
}
