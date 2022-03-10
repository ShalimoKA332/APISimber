using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APISimber
{
    public class HumanDto
    {
        public Guid Human_id { get; set; }
        [Required]
        public  string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Patronymic { get; set; }
        [Required]
        public string Dateofbirth { get; set; }
        public bool Author { get; set; } = false;
      
    }
}
