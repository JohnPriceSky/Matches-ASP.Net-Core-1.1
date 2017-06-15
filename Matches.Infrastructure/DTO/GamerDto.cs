using System;
using System.Collections.Generic;
using System.Text;

namespace Matches.Infrastructure.DTO
{
    public class GamerDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Nickname { get; set; }
    }
}
