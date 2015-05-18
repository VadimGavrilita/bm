namespace Interfases.OM
{
    public interface IBook
    {
        int Id { get; set; }
        string Code { get; set; }
        string Name { get; set; }
        IAuthor Author { get; set; }
        decimal Price { get; set; }
        ICountry Country { get; set; }
    }
}