using System;
using System.Collections.Generic;
using System.Text;

namespace Libraryies.Models
{
   public  class Book
    {

        public int Id { get; set; }
        public string Name { get; set; }
       
        public List<AuthorBook> Authorbooks { get; set; }


    }
}
