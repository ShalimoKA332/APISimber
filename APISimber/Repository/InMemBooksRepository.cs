using APISimber.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISimber.Repository
{
    public class InMemBooksRepository : IBooksRepository
    {
        private readonly IInHumanRep humanRep;
        public InMemBooksRepository(IInHumanRep humanRep)
        {
            this.humanRep = humanRep;
        }

        public static List<BooksDto> bookslist = new()
        {
            new BooksDto { Book_id = Guid.NewGuid(), Title = "Граф Монте-Кристо", Genre = "Приключение", },
            new BooksDto { Book_id = Guid.NewGuid(), Title = "Клей", Genre = "Социальная драмма", },
            //Не совсем еще понял как получить объект по его Guid,хочу в интерфейсе Человека сделать метод с параметром Guid,поэтому пока что каждое поле вручную
            //При вызове humanRep.GetHuman() ругается на ан статик(строкой ниже),пока что не понял как это решить
            //a field initializer cannot reference the non-static field, method, or property
            new BooksDto { Book_id = Guid.NewGuid(), Title = "Король Лир", Genre = "Пьеса",Human_id=Guid.Parse("59b67ff2-a273-402d-ba9b-7eadb4233c57") },

        };

       

        public IEnumerable<BooksDto> GetBook()
        {
            return bookslist;
        }
        public void CreateHBook(BooksDto book)
        {
            bookslist.Add(book);
        }
    }
}
