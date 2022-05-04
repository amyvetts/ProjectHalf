using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHalf
{
    abstract class Undead : Creature
    {
        /* Fields */
        /* Properties */
        /* Constructors */

        public Undead() : base()
        {
            this.Darkvision = true;
            this.Resistances += "Necrotic ";
        }
        /* Methods */
    }
}
