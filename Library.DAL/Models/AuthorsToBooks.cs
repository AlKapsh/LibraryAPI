using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAL.Models
{
    internal class AuthorsToBooks
    {
        int Id { get; set; }
        Author AuthorAuthor { get; set; }
        Book BookAuthorBook { get; set; }
    }
}
