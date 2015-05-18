namespace Interfases.OM
{
    public interface IShop
    {
        int Id { get; set; }
        string Code { get; set; }
        string Name { get; set; }
        ICountry Location { get; set; }
    }
}