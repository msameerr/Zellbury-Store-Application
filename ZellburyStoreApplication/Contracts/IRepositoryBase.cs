using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZellburyStoreApplication.Contracts
{
    public interface IRepositoryBase<T> where T : class
    {

        bool Create(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        bool Save();
        bool isExist(int id);
        T FindById(int id);
        ICollection<T> FindAll();

    }
}
