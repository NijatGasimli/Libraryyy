using System;
using System.Collections.Generic;
using System.Text;

namespace Libraryies.Models
{
   public  class AuthorBook
    {
        public int Id { get; set; }
        public int? BookId { get; set; }
        public Book Book { get; set; }
        public int? AuthorId { get; set; }
        public Author author { get; set; }


       





    }
}
