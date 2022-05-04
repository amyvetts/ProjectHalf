using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHalf
{
    class Deva : MediumCelestial
    {
        string message = "";
        public Deva(string n) : base()
        {
            this.Name = n;
            this.Strength = 18;
            this.Dexterity = 18;
            this.Constitution = 18;
            this.Intelligence = 17;
            this.Wisdom = 20;
            this.Charisma = 20;

            //HP 16d8s+64
            this.HP = Dice.Roll(16, 8, 64);

            this.ArmorClass = 17; //natural armor
            this.Resistances += "Radiant ";
            this.Darkvision = true;
        }

        /* methods */

        /* Mace: 
           Melee Weapon Attack: +8 to hit, reach 5 ft., one creature. 
           Hit: (1d6 + 4) bludgeoning damage.
        */
        public string Mace(Creature defender)
        {
            int toHit = Dice.Roll(20, 8);
            if (toHit > defender.ArmorClass || toHit == 20)
            {
                int damage = Dice.Roll(1, 6, 4) + Dice.Roll(4, 8);
                defender.HP -= damage;
                return "Deva is successful " + defender.GetType().Name +
                        " for " + damage + " bludgeoning damage!";
            }
            else
            {
                return "Deva fails to reach target " + defender.GetType().Name + "!";
            }
        }

        public override string ToString()
        {
            return base.ToString()
                + "\nAttacks:\n  Mace";
        }

        public override string Attack(Creature c)
        {
            return Mace(c);
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
