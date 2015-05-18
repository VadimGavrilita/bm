using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Interfases.BL;
using Interfases.OM;
using Interfases.Utils;

namespace BS.Controllers
{
    public class BooksController : ApiController
    {
        private readonly IBookManager _bookManager;

        public BooksController(IBookManager bookManager)
        {
            _bookManager = bookManager;
        }


        // GET api/values
        public IEnumerable<IBook> Get(IPaginationData paginationData)
        {
            var books = _bookManager.GetAll(paginationData);
            return books;
        }

        // GET api/values/5
        public IBook Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}