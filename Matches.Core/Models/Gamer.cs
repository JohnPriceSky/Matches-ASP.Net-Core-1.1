using System;
using System.Collections.Generic;
using System.Text;

namespace Matches.Core.Models
{
    public class Gamer
    {
        public Guid Id { get; protected set; }
        public string Name { get; protected set; }
        public string Surname { get; protected set; }
        public string Nickname { get; protected set; }
        public DateTime Birthday { get; protected set; }
        public Team Team { get; protected set; }
        public IEnumerable<Stat> Stats { get; protected set; }

        protected Gamer()
        {

        }

        public Gamer(string name, string surname, string nickname)
        {
            Id = Guid.NewGuid();
            Name = name;
            Surname = surname;
            Nickname = nickname.ToLowerInvariant();
            Birthday = DateTime.UtcNow;
        }
    }
}
