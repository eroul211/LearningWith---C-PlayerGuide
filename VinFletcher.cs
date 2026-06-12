using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFinalBattle
{
    public class VinFletcher : Character
    {
        public VinFletcher() : base(15, true, new QuickShot())
        {

        }
        public override string ToString()
        {
            return "VIN FLETCHER";
        }
    }
}
