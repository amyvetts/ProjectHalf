using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHalf
{
    abstract class Venom : Item
    {
        public Creature User;
        public int quanity { get; set; }
        public int bonus { get; protected set; }

        public virtual bool Equipped()
        {
            if (quanity <= 1)
            {
                quanity += 1;
                return true;
            } else
            {
                quanity -= 1;
                return false;
            }
        }

        public Venom (string n, int InitialUses) : base(n, InitialUses)
        {

        }
    }
}
