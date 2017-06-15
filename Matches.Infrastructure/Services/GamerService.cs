using Matches.Core.Models;
using Matches.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Matches.Infrastructure.DTO;

namespace Matches.Infrastructure.Services
{
    public class GamerService : IGamerService
    {
        private readonly IGamerRepository _gamerRepository;
        public GamerService(IGamerRepository gamerRepository)
        {
            _gamerRepository = gamerRepository;
        }

        public GamerDto Get(string nickname)
        {
            var gamer = _gamerRepository.Get(nickname);
            return new GamerDto
            {
                Id = gamer.Id,
                Name = gamer.Name,
                Surname = gamer.Surname,
                Nickname = gamer.Nickname
            };
        }

        public void Register(string name, string surename, string nickname)
        {
            var gamer = _gamerRepository.Get(nickname);
            if (gamer != null)
                throw new Exception("Gamer exist!");

            gamer = new Gamer(name, surename, nickname);
            _gamerRepository.Add(gamer);
        }
    }
}
