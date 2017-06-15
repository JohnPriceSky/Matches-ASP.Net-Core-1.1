using System;
using System.Collections.Generic;
using System.Text;

namespace Matches.Core.Models
{
    public class Team
    {
        public Guid Id { get; protected set; }
        public string Name { get; protected set; }
        public int Places { get; protected set; }
    }
}
