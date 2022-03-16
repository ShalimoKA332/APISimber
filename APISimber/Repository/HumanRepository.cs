using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISimber.Repository
{


    public class HumanRepository : IHumanRepository
    {
        public static List<HumanDto> humenlist = new()
        {
            new HumanDto { Human_id = Guid.NewGuid(), Name = "George", Surname = "Philips", Patronymic = "Jack", Dateofbirth = "02.02.2000" },
            new HumanDto { Human_id = Guid.NewGuid(), Name = "Roman", Surname = "Samsung", Patronymic = "Jack", Dateofbirth = "02.02.2000" },
            new HumanDto { Human_id = Guid.NewGuid(), Name = "Walter", Surname = "Vitek", Patronymic = "Jack", Dateofbirth = "02.02.2000", Author = true }

        };
        public IEnumerable<HumanDto> GetHuman()
        {
            return humenlist;
        }
        public void CreateHuman(HumanDto human)
        {
            humenlist.Add(human);
        }
        public HumanDto GetHuman(Guid id)
        {
            return humenlist.Where(humenlist => humenlist.Human_id == id).SingleOrDefault();
        }
        public void RemoveHuman(Guid id)
        {
            var RemoveHuman = humenlist.FindIndex(humenlist => humenlist.Human_id == id);
            humenlist.RemoveAt(RemoveHuman);


        }
    }
}
