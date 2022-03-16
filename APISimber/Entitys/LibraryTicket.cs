using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISimber.Entitys
{
    public class LibraryTicket
    {
        public Guid id { get; set; }
        public virtual HumanDto Name { get; set; }

        public virtual BooksDto book { get; set; }
        public DateTime date { get; set; }
     }
}
