using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APISimber
{
    public class HumanDto
    {/// <summary>
     /// 2.	Создать классы-репрезентирующие (постфикс Dto)
     ///1.	Добавьте валидации в ваши сущности: все обязательные поля должны быть NotNull. 
     /// </summary>
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
