namespace Interfases.OM
{
    public interface ICustomer
    {
        int Id { get; set; }
        string Code { get; set; }
        string Name { get; set; }
        ICountry Country { get; set; }
    }
}