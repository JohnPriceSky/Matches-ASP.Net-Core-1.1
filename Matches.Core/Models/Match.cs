using System;
using System.Collections.Generic;
using System.Text;

namespace Matches.Core.Models
{
    public class Match
    {
        public Guid Id { get; protected set; }
        public int Lenght { get; set; }
        public Team TeamA { get; set; }
        public Team TeamB { get; set; }
        public Team Winner { get; set; }
    }
}
