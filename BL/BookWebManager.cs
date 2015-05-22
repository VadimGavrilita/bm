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

        public IEnumerable<Book> GetAll(IPaginationData param)
        {
            return _bookRepository.GetAll(param);
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
