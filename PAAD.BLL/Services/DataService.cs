using PAAD.DAL.Models;
using PAAD.DAL.Repositories;

namespace PAAD.BLL.Services
{
    public class DataService
    {
        public static readonly DataService Instance = new DataService();

        private DataService() { }

        public T GetAll<T>()
        {
            throw new NotImplementedException();
        }

        public T? GetById<T>()
        {
            throw new NotImplementedException();
        }

        public bool Create<T>(T entity)
        {
            throw new NotImplementedException();
        }

        public bool Edit(int id, Task entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete<T>(int id) 
        {
            throw new NotImplementedException();
        }
    }
}
