using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Matches.Infrastructure.Services;
using Matches.Infrastructure.DTO;

namespace Matches.Api.Controllers
{
    [Route("api/Gamers")]
    public class GamersController : Controller
    {
        private readonly IGamerService _gamerService;
        public GamersController(IGamerService gamerService)
        {
            _gamerService = gamerService;
        }
        // GET: api/Gamers
        [HttpGet("{nickname}")]
        public GamerDto Get(string nickname)
            => _gamerService.Get(nickname);
    }
}
