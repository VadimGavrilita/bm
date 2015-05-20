using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfases.BL;
using Interfases.OM;
using Interfases.Utils;

namespace BL
{
    public class BookDesctopManager : IBookManager
    {
        public IEnumerable<IBook> GetAll(IPaginationData param)
        {
            throw new NotImplementedException();
        }

        public IBook Get(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(IBook type)
        {
            throw new NotImplementedException();
        }

        public bool Update(IBook type)
        {
            throw new NotImplementedException();
        }
    }
}
