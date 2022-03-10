using APISimber.Entitys;
using APISimber.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISimber.Controllers
{/// <summary>
/// 4.	Реализовать контроллер, который отвечает за книгу.
/// </summary>
    [ApiController]
    [Route("Books")]
    public class BooksController : ControllerBase
    {
        private readonly IBooksRepository booksrep;

        public BooksController(IBooksRepository booksrep)
        {
            this.booksrep = booksrep;
        }
        /// <summary>
        ///	Реализовать метод Get возвращающий

        /// </summary>
        /// <param name="Author"></param>
        /// <param name="Genre"></param>
        /// <param name="Title"></param>
        /// <returns></returns>

        [HttpGet]
        public IEnumerable<BooksDto> GetBooks(string Author = null, string Genre = null, string Title = null)
        {
            var books = booksrep.GetBook();
            if (Title != null)
            {
                var findbook = books.Where(x => x.Title.Contains(Title));
                return findbook;
            }
            else if (Genre != null)
            {
                var findbook = books.Where(x => x.Genre.Contains(Genre));
                return findbook;
            }
            else
            {
                return books;
            }
            //else
            //{
            //    //та же ситуация,описанная в InMemBooksRepository
            //    var findbook = books.Where(x=>x.Author.GetHuman())
            //    return findbook;
            //}
        }
        /// <summary>
        /// 4.2.	Реализовать метод POST добавляющий новую книгу.
        /// </summary>
        /// <param name="created"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult<HumanDto> CreateHuman(BooksDto created)
        {
            BooksDto books = new()
            {
                Human_id = Guid.NewGuid(),
                Name = created.Name,
                Surname = created.Surname,
                Patronymic = created.Patronymic,
                Dateofbirth = created.Dateofbirth,
                Book_id = Guid.NewGuid(),
                Title = created.Title,
                Genre = created.Genre,
            };
            booksrep.CreateHBook(books);
            return CreatedAtAction(nameof(GetBooks), new { id = books.Human_id }, books.AsDto());
        }
    }
}
