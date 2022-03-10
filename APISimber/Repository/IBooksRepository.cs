using APISimber.Entitys;
using System.Collections.Generic;

namespace APISimber.Repository
{
    public interface IBooksRepository
    {
        void CreateHBook(BooksDto book);
        IEnumerable<BooksDto> GetBook();
    }
}