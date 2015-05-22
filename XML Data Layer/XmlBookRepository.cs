using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfases.DL;
using Interfases.OM;
using Interfases.Utils;

namespace XML_Data_Layer
{
    class XmlBookRepository : IBookRepository
    {
        public IEnumerable<Book> GetAll(IPaginationData param)
        {
            throw new NotImplementedException();
        }

        public Book Get(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(Book type)
        {
            throw new NotImplementedException();
        }

        public bool Update(Book type)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
