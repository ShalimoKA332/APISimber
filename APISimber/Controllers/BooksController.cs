using APISimber.Entitys;
using APISimber.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISimber.Controllers
{
    [ApiController]
    [Route("Books")]
    public class BooksController : ControllerBase
    {
        private readonly IBooksRepository booksrep;

        public BooksController(IBooksRepository booksrep)
        {
            this.booksrep = booksrep;
        }

        [HttpGet]
        public IEnumerable<BooksDto> GetBooks(string Author=null,string Genre=null,string Title=null)
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
                var findbook = books.
                return findbook;
            }
        }
    }
}
