using APISimber.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISimber.Repository
{
    public class ReaderTicketRepository : IReaderTicketRepository
    {
        public static List<LibraryTicket> ReaderTicket = new List<LibraryTicket>();
        public void CreateLibrariTicket(LibraryTicket ticket)
        {
            ReaderTicket.Add(ticket);
        }
        public IEnumerable<LibraryTicket> GetReaderTocket()
        {
            return ReaderTicket;
        }
    }

}
