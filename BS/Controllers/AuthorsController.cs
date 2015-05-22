using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.UI.WebControls;
using Interfases.API;
using Interfases.BL;
using Interfases.OM;
using Interfases.Utils;


namespace BS.Controllers
{
    [Authorize]
    public class AuthorsController : ApiController , ICrudApi<Author>
    {
        private readonly IAuthorManager _authorManager;

        public AuthorsController(IAuthorManager authorManager)
        {
            _authorManager = authorManager;
        }

        public IEnumerable<Author> Get(IPaginationData paginationData)
        {
            throw new NotImplementedException();
        }

        public Author Get(int id)
        {
            throw new NotImplementedException();
        }

        public Author Post([FromBody]Author instance)
        {
            throw new NotImplementedException();
        }

        public void Put(int id, Author instance)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
