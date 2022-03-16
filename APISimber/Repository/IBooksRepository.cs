using APISimber.Entitys;
using System;
using System.Collections.Generic;

namespace APISimber.Repository
{
    public interface IBooksRepository
    {
        void CreateHBook(BooksDto book);
        IEnumerable<BooksDto> GetBook(Guid id);
        IEnumerable<BooksDto> GetBook();
        public void RemoveBook(Guid id);
    }
}