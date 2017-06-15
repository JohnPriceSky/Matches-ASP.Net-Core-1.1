using System;
using System.Collections.Generic;
using System.Text;
using Matches.Core.Models;
using Matches.Core.Repositories;
using System.Linq;

namespace Matches.Infrastructure.Repositories
{
    public class InMemoryGamerRepository : IGamerRepository
    {
        private static ISet<Gamer> _gamers = new HashSet<Gamer>
        {
            new Gamer("Michał", "Sadowski", "IksWodas"),
            new Gamer("Michał1", "Sadowski1", "IksWodas1"),
            new Gamer("Michał2", "Sadowski2", "IksWodas2")
        };
        public void Add(Gamer gamer)
        {
            _gamers.Add(gamer);
        }

        public Gamer Get(Guid id)
            => _gamers.Single(x => x.Id == id);

        public Gamer Get(string nickname)
            => _gamers.Single(x => x.Nickname == nickname.ToLowerInvariant());

        public IEnumerable<Gamer> GetAll()
            => _gamers;

        public void Remove(Guid id)
        {
            var gamer = Get(id);
            _gamers.Remove(gamer);
        }

        public void Update(Guid id)
        {
        }
    }
}
