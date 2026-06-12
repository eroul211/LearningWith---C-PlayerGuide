using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFinalBattle
{
    public class Skeleton : Character
    {
        public Skeleton() : base(5, true, new Bone())
        {
        }
        public override string ToString()
        {
            return "SKELETON";
        }

    }
}
