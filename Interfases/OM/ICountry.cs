namespace Interfases.OM
{
    public interface ICountry
    {
        int Id { get; set; }
        string Code { get; set; }
        string Name { get; set; }
        ILocation Location { get; set; }
    }
}