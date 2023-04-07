using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BAL.DataTranferObjects
{
    internal class BookDTO
    {
        public string Title { get; set; }
        public DateTime ReleaseYear { get; set; }
        public int ISBN { get; set; }
    }
}
