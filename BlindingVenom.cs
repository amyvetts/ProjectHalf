using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHalf
{
    abstract class BlindingVenom : Venom
    {
        //Sends the opponent into circles
        public BlindingVenom(int InitialUses) : base ("Blinding Venom", InitialUses)
        {
            this.name = "Blinding Venom";
            this.X = 0;
            this.Y = 0;
            this.Facing = Direction.NORTH;

        }
        public override bool Equipped()
        {
            if (UsesLeft > 0)
            {
                UsesLeft = UsesLeft - 1;
                return true;
            } else
            {
                return false;
            }
        }
    }
}
