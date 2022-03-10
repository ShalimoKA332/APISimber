using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APISimber.Dtos
{
    public class CreatedHumanDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }

        public string Patronymic { get; set; }
        [Required]
        public string Dateofbirth { get; set; }
    }
}
