using APISimber.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISimber.Repository
{
    /// <summary>
    /// Хранение данных в памяти системы
    /// </summary>
    public class BooksRepository : IBooksRepository
    {
        private readonly IHumanRepository humanRep;
        public BooksRepository(IHumanRepository humanRep)
        {
            this.humanRep = humanRep;
        }
        public static List<BooksDto> bookslist = new()
        {
            new BooksDto { Book_id = Guid.NewGuid(), Title = "Граф Монте-Кристо", Genre = "Приключение", Human_id = Guid.Parse("59b67ff2-a273-402d-ba9b-7eadb4233c57") },
            new BooksDto { Book_id = Guid.NewGuid(), Title = "Клей", Genre = "Социальная драмма", },
            new BooksDto { Book_id = Guid.NewGuid(), Title = "Король Лир", Genre = "Пьеса",},

        };
        public IEnumerable<BooksDto> GetBook()
        {
            return bookslist;
        }
        public void CreateHBook(BooksDto book)
        {
            bookslist.Add(book);
        }
        public IEnumerable<BooksDto> GetBook(Guid id)
        {
            var FindHuman = bookslist.Where(x => x.Human_id == id);
            return FindHuman;
        }
        public void RemoveBook(Guid id)
        {
            var RemoveBook = bookslist.FindIndex(x => x.Book_id == id);
            bookslist.RemoveAt(RemoveBook);
        }
    }
}
