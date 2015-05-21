using System.Collections.Generic;
using Interfases.BL;

namespace Interfases.Utils
{
    public interface ICrudMethods<T>
    {
        IEnumerable<T> GetAll(IPaginationData param);
        T Get(int id);
        int Insert(T instance);
        bool Update(T instance);
        bool Delete(int id);
    }
}