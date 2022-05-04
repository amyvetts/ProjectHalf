using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHalf
{
    abstract class Item : IUsable, ILocatable
    {
        public string name { get; set; }    
        public int X { get; set; }
        public int Y { get; set; }
        public Direction Facing { get; set; }

        public int UsesLeft { get; set; }
        public float UseChance { get; set; }

        public string SuccessMessage { get; }
        public string FailureMessage { get; }

        public bool Used()
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

        public Item(string n, int InitialUses)
        {
            this.name = n;
            this.UsesLeft = InitialUses;
        }

        public override string ToString()
        {
            
            return this.name + "(" + this.UsesLeft + " use(s) left)";
        }




    }
}
