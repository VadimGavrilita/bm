using System.Collections.Generic;
using System.Linq;
using Interfases.DL;
using Interfases.OM;
using Interfases.Utils;
using WebGrease.Css.Extensions;

namespace MOCK_Data_Layer
{
    public class MockBookRepository : IBookRepository
    {
        private static IList<Book> _books = new List<Book>()
        {
            new Book
            {
                Id = 3,
                Code = "TestCode",
                Name = "Somename"
            },
            new Book
            {
                Id = 4,
                Code = "TestCode1",
                Name = "Somename1"
            },
            new Book
            {
                Id = 5,
                Code = "TestCode2",
                Name = "Somename2"
            }
        };

        public IEnumerable<Book> GetAll(IPaginationData param)
        {
            return _books;
        }

        public Book Get(int id)
        {
            return _books.FirstOrDefault(book => book.Id.Equals(id));
        }

        public int Insert(Book instance)
        {
            instance.Id = _books.Max(b => b.Id) + 1;
            _books.Add(instance);
            return instance.Id;
        }

        public bool Update(Book instance)
        {
            if (!_books.Any(b => b.Id.Equals(instance.Id))) return false;
            
            _books.Where(b => b.Id.Equals(instance.Id)).ForEach(b =>
            {
                b = instance;
            });
            return true;
        }

        public bool Delete(int id)
        {
            if (!_books.Any(b => b.Id.Equals(id))) return false;
            var book = _books.FirstOrDefault(b => b.Id.Equals(id));
            _books.Remove(book);
            return true;
        }
    }
}
