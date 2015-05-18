using System.Collections.Generic;
using Interfases.BL;

namespace Interfases.Utils
{
    public interface ICrudMethods<T>
    {
        IEnumerable<T> GetAll(IPaginationData param);
        T Get(int id);
        int Insert(T type);
        bool Update(T type);
    }
}