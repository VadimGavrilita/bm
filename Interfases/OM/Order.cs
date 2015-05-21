using System.Collections.Generic;

namespace Interfases.OM
{
    public class Order
    {
        public int Id { get; set; }
        public Shop Shop { get; set; }
        public Customer Customer { get; set; }
        public IEnumerable<Book> Books { get; set; }
    }
}