namespace Interfases.OM
{
    public class Book
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Author Author { get; set; }
        public decimal Price { get; set; }
        public Country Country { get; set; }
    }
}