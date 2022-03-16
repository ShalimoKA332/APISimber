using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APISimber.Entitys
{/// <summary>
/// 2.	Создать классы-репрезентирующие (постфикс Dto)
/// </summary>
    public class BooksDto: HumanDto
    {
        HumanDto human = new HumanDto();
        public Guid Book_id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Genre { get; set; }
        public virtual HumanDto AuthorBook
        {
            get
            {
                if (human.Author == true)
                {
                    return human;
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