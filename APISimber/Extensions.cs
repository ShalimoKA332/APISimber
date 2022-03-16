using APISimber.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISimber
{
    public static class Extensions
    {

        public static HumanDto AsDto(this HumanDto human)
        {
            return new HumanDto()
            {
                Human_id = human.Human_id,
                Name = human.Name,
                Surname = human.Surname,
                Patronymic = human.Patronymic,
                Dateofbirth = human.Dateofbirth,
                Author = human.Author

            };
        }
        public static BooksDto AsDto(this BooksDto book)
        {
            return new BooksDto()
            {
                Book_id = book.Book_id,
                Title = book.Title,
                Genre = book.Genre,
            };
        }
    }
}