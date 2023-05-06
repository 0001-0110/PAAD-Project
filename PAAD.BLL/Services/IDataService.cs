using PAAD.DAL.Models;

namespace PAAD.BLL.Services
{
    public interface IDataService
    {
        IEnumerable<T> GetAll<T>() where T : Model;
        T? GetById<T>(int id) where T : Model;
        bool Create<T>(T entity) where T : Model;
        bool Edit<T>(int id, T entity) where T : Model;
        bool Delete<T>(int id) where T : Model;
    }
}
