using System.Collections.Generic;

namespace APISimber.Repository
{
    public  interface IInHumanRep
    {
        IEnumerable<HumanDto> GetHuman();
        void CreateHuman(HumanDto human);
    }
}