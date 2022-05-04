using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHalf
{
    class Ghost : Undead, IActionable
    {
        string message = "";
        public Ghost(string n) : base()
        {
            this.Name = n;
            this.Strength = 7;
            this.Dexterity = 13;
            this.Constitution = 10;
            this.Intelligence = 10;
            this.Wisdom = 12;
            this.Charisma = 17;

            //HP 10d8s
            this.HP = Dice.Roll(10, 8);

            this.ArmorClass = 11;
            this.Resistances += "Normal ";
        }

        /* methods */

        /* Withering Touch: 
           Melee Weapon Attack: +5 to hit, reach 5 ft., one target. 
           Hit: (4d6 + 3) necrotic damage.
        */
        public string WitheringTouch(Creature defender)
        {
            int toHit = Dice.Roll(20, 5);
            if (toHit > defender.ArmorClass || toHit == 20)
            {
                int damage = Dice.Roll(4, 6, 3);
                defender.HP -= damage;
                return "Ghost uses Withering Touch against " + defender.GetType().Name +
                        " for " + damage + " necrotic damage!";
            }
            else
            {
                return "Ghost fails to touch " + defender.GetType().Name + "!";
            }
        }

        public override string ToString()
        {
            return base.ToString()
                + "\nAttacks:\n  Withering Touch";
        }

        public override string Attack(Creature c)
        {
            return WitheringTouch(c);
        }
        public override string Defend()
        {
            return message;
        }
        public override string Rest()
        {
            return message;
        }
        public override string Use(IUsable used)
        {
            return message;
        }
        public override string DefendAgainst(Creature attacker)
        {
            return message;
        }

    }
}
