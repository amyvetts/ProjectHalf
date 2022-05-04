using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHalf
{
    class Crab : TinyBeast
    {
        string message = "";
        public Crab(string n) : base()
        {
            this.Name = n;
            this.Strength = 2;
            this.Dexterity = 11;
            this.Constitution = 10;
            this.Intelligence = 1;
            this.Wisdom = 8;
            this.Charisma = 2;

            //HP 1d4s
            this.HP = Dice.Roll(1, 4);

            this.ArmorClass = 11; //natural armor
            this.Resistances += "Stealth ";
        }
        /* methods */

        /* Claw: 
           Melee Weapon Attack: +0 to hit, reach 5 ft., one creature. 
           Hit: (1d1) bludgeoning damage.
        */
        public string Claw(Creature defender)
        {
            int toHit = Dice.Roll(20, 0);
            if (toHit > defender.ArmorClass || toHit == 20)
            {
                int damage = Dice.Roll(1, 1);
                defender.HP -= damage;
                return "Crab goes in a claws " + defender.GetType().Name +
                        " for " + damage + " bludgeoning damage!";
            }
            else
            {
                return "Crab fails to reach target " + defender.GetType().Name + "!";
            }
        }
        public override string ToString()
        {
            return base.ToString()
                + "\nAttacks:\n  Claw";
        }

        public override string Attack(Creature c)
        {
            return Claw(c);
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
