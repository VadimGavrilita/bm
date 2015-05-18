using System.Collections.Generic;

namespace Interfases.OM
{
    public interface IOrder
    {
        int Id { get; set; }
        IShop Shop { get; set; }
        ICustomer Customer { get; set; }
        IEnumerable<IBook> Books { get; set; }
    }
}