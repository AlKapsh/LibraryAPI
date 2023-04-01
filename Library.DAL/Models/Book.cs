namespace Library.DAL.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseYear { get; set; }
        public int ISBN { get; set; }
        public int Quantity { get; set; }
        public List<AuthorsToBooks> AuthorsToBooks { get; set; } = new();
        public Publisher Publisher { get; set; }
    }
}
