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
        public IEnumerable<BooksDto> GetBooks(string Authorid = null, string Genre = null, string Title = null)
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
            else if (Authorid != null)
            {
                var authorbook = books.Where(x =>
                {
                    return x.Human_id.ToString() == Authorid;
                });
                return authorbook;
            }

            return books;

        }
        [HttpGet("sort")]
        public IEnumerable<BooksDto> GetSort(string Author, string Genre = null, string Title = null)
        {
            var books = booksrep.GetBook();
            if (Author != null)
            {
                var Authorsort = books.OrderBy(x => x.Author);
                return Authorsort;
            }
            else if (Genre != null)
            {
                var Genresort = books.OrderBy(x => x.Genre);
                return Genresort;
            }
            else if (Title != null)
            {
                var Titlesort = books.OrderBy(x => x.Title);
                return Titlesort;
            }
            return books;
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
        [HttpDelete]
        public ActionResult<HumanDto> RemoveBooks(Guid id)
        {
            booksrep.RemoveBook(id);
            if (booksrep == null)
            {
                return NoContent();
            }
            return Ok();
        }
    }
}
