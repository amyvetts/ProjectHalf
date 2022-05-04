using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHalf
{
    abstract class TinyBeast : Creature
    {
        /* Fields */
        /* Properties */
        /* Constructors */

        public TinyBeast() : base()
        {
            this.Darkvision = false;
            this.Resistances += "Blindsight ";
        }
        /* Methods */
    }
}
