using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFinalBattle
{
    public class TheUncodedOne : Character
    {
        public TheUncodedOne() : base(15, true, new UnravelingAttack())
        {
        }
        public override string ToString()
        {
            return "THE.UNCODED.ONE";
        }
    }
}
