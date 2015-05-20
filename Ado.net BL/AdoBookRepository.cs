using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfases.BL;
using Interfases.DL;
using Interfases.OM;
using Interfases.Utils;
using ObjectModels;

namespace Ado.net_BL
{
    public class AdoBookRepository : IBookRepository
    {
        public IEnumerable<IBook> GetAll(IPaginationData param)
        {
            return new List<Book>
            {
                new Book
                {
                    Code = "TestCode",
                    Name = "Somename"
                },
                new Book
                {
                    Code = "TestCode",
                    Name = "Somename"
                },
                new Book
                {
                    Code = "TestCode",
                    Name = "Somename"
                },
            };
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
