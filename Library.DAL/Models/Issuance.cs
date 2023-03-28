namespace Library.DAL.Models
{
    public class Issuance
    {

        public int Id { get; set; }
        public DateTime IssuanceDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public Book Book { get; set; }
        public Reader Reader { get; set; }

    }
}