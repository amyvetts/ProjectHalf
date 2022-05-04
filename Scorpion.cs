using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHalf
{
    class Scorpion : TinyBeast
    {
        string message = "";
        public Scorpion(string n) : base()
        {
            this.Name = n;
            this.Strength = 2;
            this.Dexterity = 11;
            this.Constitution = 8;
            this.Intelligence = 1;
            this.Wisdom = 8;
            this.Charisma = 2;

            //HP 1d4s-1
            this.HP = Dice.Roll(1, 4, -1);

            this.ArmorClass = 11; //natural armor
            this.Resistances += "Speed ";
        }
        /* methods */

        /* Sting: 
           Melee Weapon Attack: +2 to hit, reach 5 ft., one creature. 
           Hit: (1d1) piercing damage, (1d8) poison damage.
        */
        public string Sting(Creature defender)
        {
            int toHit = Dice.Roll(20, 2);
            if (toHit > defender.ArmorClass || toHit == 20)
            {
                int damage = Dice.Roll(1, 1) + Dice.Roll(1, 8);
                defender.HP -= damage;
                return "Scorpion goes in and stings " + defender.GetType().Name +
                        " for " + damage + " piercing and poison damage!";
            }
            else
            {
                return "Scorpion fails to reach target " + defender.GetType().Name + "!";
            }
        }
        public override string ToString()
        {
            return base.ToString()
                + "\nAttacks:\n  Sting";
        }

        public override string Attack(Creature c)
        {
            return Sting(c);
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
