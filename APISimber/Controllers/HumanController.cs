using APISimber.Dtos;
using APISimber.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISimber.Controllers
{/// <summary>
/// 3.	Реализовать контроллер, который отвечает за человека.
/// </summary>
    [ApiController]
    [Route("humans")]
    public class HumanController : ControllerBase
    {
        private readonly IHumanRepository humanRep;
        public HumanController(IHumanRepository rep)
        {
            this.humanRep = rep;
        }
        /// <summary>
        /// 3.1.	Реализовать метод Get 
        /// </summary>
        /// <param name=""="query"></param>
        /// <param name="author"></param>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<HumanDto> GetHumans(string query = null, bool author = false)
        {
            var humans = humanRep.GetHuman();
            //3.1.3.	Поиск людей, в имени, фамилии или отчестве которых содержится поисковая фраза (query).
            if (query != null)
            {
                var findhuman = humans.Where(x => x.Name.Contains(query) | x.Surname.Contains(query) | x.Patronymic.Contains(query));
                return findhuman;
            }
            //3.1.2.	Список людей, которые пишут книги.
            else if (author == true)
            {
                var findauthors = humans.Where(x => x.Author == true);
                return findauthors;
            }
            //3.1.1.Список всех людей.
            return humans;
        }
        /// <summary>
        /// 3.2.	Реализовать метод POST добавляющий нового человека.
        /// </summary>
        /// <param name="created"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult<HumanDto> CreateHuman(CreatedHumanDto created)
        {
            HumanDto human = new()
            {
                Human_id = Guid.NewGuid(),
                Name = created.Name,
                Surname = created.Surname,
                Patronymic = created.Patronymic,
                Dateofbirth = created.Dateofbirth,

            };
            humanRep.CreateHuman(human);
            return CreatedAtAction(nameof(GetHumans), new { id = human.Human_id }, human.AsDto());
        }
        [HttpDelete]
        public ActionResult Delete(Guid id)
        {
            var find = humanRep.GetHuman(id);
            if (find is null) 
            {
                return NotFound();
            }
            humanRep.RemoveHuman(id);
            return NoContent();
        }
    }

}

