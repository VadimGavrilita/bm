using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Web.Http;
using Interfases.BL;
using Interfases.OM;
using Interfases.Utils;

namespace BS.Controllers
{
    [Authorize]
    public class BooksController : ApiController
    {
        private readonly IBookManager _bookManager;

        public BooksController(IBookManager bookManager)
        {
            _bookManager = bookManager;
        }

        // GET api/values
        public IEnumerable<Book> Get(IPaginationData paginationData)
        {
            var books = _bookManager.GetAll(paginationData);
            return books;
        }

        // GET api/values/5
        public Book Get(int id)
        {
            var book = _bookManager.Get(id);
            return book;
        }

        // POST api/values
        public HttpResponseMessage Post([FromBody]Book book)
        {
            book.Id = _bookManager.Insert(book);
            return Request.CreateResponse<Book>(HttpStatusCode.Created, book);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]Book value)
        {
            _bookManager.Update(value);
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            _bookManager.Delete(id);
        }
    }
}