using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHalf
{
    abstract class Paralyzed : Venom
    {
        //Removes opponents ability to move
        public Paralyzed (int InitialUses) : base("Paralyzing Venom", InitialUses)
        {
            this.name = "Paralyzing Venom";
            this.X = 2;
            this.Y = 2;
            this.Facing = Direction.EAST;

        }

        public override bool Equipped()
        {
            if (UsesLeft > 0)
            {
                UsesLeft = UsesLeft - 1;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    
    
}
