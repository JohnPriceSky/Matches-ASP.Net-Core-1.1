using System;
using System.Collections.Generic;
using System.Text;

namespace Matches.Core.Models
{
    public class Stat
    {
        public Guid Id { get; protected set; }
        public int Kills { get; protected set; }
        public int Deaths { get; protected set; }
        public int Assists { get; protected set; }
    }
}
