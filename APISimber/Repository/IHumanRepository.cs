using System;
using System.Collections.Generic;

namespace APISimber.Repository
{
    public interface IHumanRepository
    {
        void CreateHuman(HumanDto human);
        IEnumerable<HumanDto> GetHuman();
        HumanDto GetHuman(Guid id);
        void RemoveHuman(Guid id);
    }
}