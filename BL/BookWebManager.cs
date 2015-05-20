using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfases.BL;
using Interfases.DL;
using Interfases.OM;
using Interfases.Utils;

namespace BL
{
    public class BookWebManager : IBookManager
    {
        private readonly IBookRepository _bookRepository;

        public BookWebManager(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public IEnumerable<IBook> GetAll(IPaginationData param)
        {
            return _bookRepository.GetAll(param);
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
