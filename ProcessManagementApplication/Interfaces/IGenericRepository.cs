using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessManagementApplication.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {

        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task<int> Add(T entity);
        Task<int> Delete(int id);
        Task<int> Update(T entity);

    }
}
