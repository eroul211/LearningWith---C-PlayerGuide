using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFinalBattle
{
    public class DoNothing : Action
    {
        public DoNothing() : base("NOTHING", 0)
        {

        }
        public override void Run(Character character, Character enemy)
        {
            Console.WriteLine($"{character} did {SkillName}\n");

        }
    }
}
