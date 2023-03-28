namespace Library.DAL.Models
{
    internal class Book
    {
        int Id { get; set; }
        string Title { get; set; }
        DateOnly ReleaseYear { get; set; }
        int ISBN { get; set; }
        int Quantity { get; set; }
        List<Author> Authors { get; set; } = new();
        Publisher Publisher { get; set; }
    }
}
