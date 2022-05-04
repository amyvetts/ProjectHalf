using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHalf
{
    abstract class AntitoxingPotion : Potion
    {
        //Heals from Venom
        public AntitoxingPotion(int InitialUses) : base("Antitoxin Potion", InitialUses)
        {
            this.name = "Antitoxin Potion";
            this.X = 3;
            this.Y = 2;
            this.Facing = Direction.SOUTH;

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
