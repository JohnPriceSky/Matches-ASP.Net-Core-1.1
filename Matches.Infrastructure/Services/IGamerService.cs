using Matches.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Matches.Infrastructure.Services
{
    public interface IGamerService
    {
        GamerDto Get(string nickname);
        void Register(string name, string surename, string nickname);
    }
}
