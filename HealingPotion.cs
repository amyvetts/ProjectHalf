using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHalf
{
    abstract class HealingPotion : Potion
    {
        //Heal ME
        public HealingPotion(int InitialUses) : base("Healing Potion", InitialUses)
        {
            this.name = "Healing Potion";
            this.X = 1;
            this.Y = 1;
            this.Facing = Direction.WEST;

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
