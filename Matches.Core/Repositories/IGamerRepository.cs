using Matches.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Matches.Core.Repositories
{
    public interface IGamerRepository
    {
        Gamer Get(Guid id);
        Gamer Get(string nickname);
        IEnumerable<Gamer> GetAll();
        void Add(Gamer gamer);
        void Remove(Guid id);
        void Update(Guid id);
    }
}
