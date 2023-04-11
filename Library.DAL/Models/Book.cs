namespace Library.DAL.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseYear { get; set; }
        public int ISBN { get; set; }
        public int? IssuanceId { get; set; }
        public Issuance? Issuance { get; set; }
        public List<AuthorToBook> AuthorsToBooks { get; set; }
        public Publisher Publisher { get; set; }
    }
}
