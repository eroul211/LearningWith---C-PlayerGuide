using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFinalBattle
{
    internal class TheTrueProgrammer : Character
    {
        public string Name { get; }
        public TheTrueProgrammer(string name) : base(25, true, new Punch())
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return Name == string.Empty ? "Nameless" : Name;
        }

    }
}
