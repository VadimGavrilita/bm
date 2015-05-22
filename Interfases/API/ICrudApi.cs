using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Interfases.Utils;
namespace Interfases.API
{
    public interface ICrudApi<T>
    {
        IEnumerable<T> Get(IPaginationData paginationData);
        T Get(int id);
        T Post(T instance);
        void Put(int id, T instance);
        void Delete(int id);
    }
}