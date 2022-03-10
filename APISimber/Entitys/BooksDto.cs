using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APISimber.Entitys
{
    public class BooksDto : HumanDto
    {
        HumanDto human = new HumanDto();
        public Guid Book_id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Genre { get; set; }
        public string AuthorBook
        {
            get
            {
                if (human.Author == true)
                {
                    return AuthorBook;
                }
                return null;
            }
            set
            {
                if (human.Author == true)
                {
                    AuthorBook=value;
                }

            }

        }
    }
}