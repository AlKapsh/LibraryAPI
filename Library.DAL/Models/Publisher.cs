namespace Library.DAL.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string EMail { get; set; }
        public string PhoneNumber { get; set; }

        public List<Book> Books { get; set; }

    }
}
