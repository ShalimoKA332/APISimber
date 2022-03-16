using APISimber.Entitys;
using System.Collections.Generic;

namespace APISimber.Repository
{
    public interface IReaderTicketRepository
    {
        void CreateLibrariTicket(LibraryTicket ticket);
         IEnumerable<LibraryTicket> GetReaderTocket();
    }
}