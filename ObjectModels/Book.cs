using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfases.OM;

namespace ObjectModels
{
    public class Book : IBook
    {
        public int Id
        {
            get;
            set;
        }

        public string Code
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public IAuthor Author
        {
            get;
            set;
        }

        public decimal Price
        {
            get;
            set;
        }

        public ICountry Country
        {
            get;
            set;
        }
    }
}
