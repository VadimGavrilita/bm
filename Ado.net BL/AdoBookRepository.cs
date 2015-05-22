using System;
using System.Collections.Generic;
using Interfases.DL;
using Interfases.OM;
using Interfases.Utils;

namespace Ado.net_BL
{
    public class AdoBookRepository : IBookRepository
    {
        public IEnumerable<Book> GetAll(IPaginationData param)
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
