namespace Library.DAL.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FistName { get; set; }
        public string SecondName { get; set; }

        List<AuthorsToBooks> AuthorsToBooks { get; set; } = new();

    }
}
