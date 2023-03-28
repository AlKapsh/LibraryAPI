namespace Library.DAL.Models
{
    internal class Issuance
    {

        int Id { get; set; }
        DateOnly IssuanceDate { get; set; }
        DateOnly ReturnDate { get; set; }
        Book Book { get; set; }
        Reader Reader { get; set; }

    }
}