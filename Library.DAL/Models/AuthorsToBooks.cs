using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAL.Models
{
    internal class AuthorsToBooks
    {
        public int Id { get; set; }
        public Author AuthorAuthor { get; set; }
        public Book BookAuthorBook { get; set; }
    }
}
