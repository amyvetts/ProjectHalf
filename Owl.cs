using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHalf
{
    class Owl : TinyBeast
    {
        string message = "";
        public Owl(string n) : base()
        {
            this.Name = n;
            this.Strength = 3;
            this.Dexterity = 13;
            this.Constitution = 8;
            this.Intelligence = 2;
            this.Wisdom = 12;
            this.Charisma = 7;

            //HP 1d4s-1
            this.HP = Dice.Roll(1, 4, -1);

            this.ArmorClass = 11; //natural armor
            this.Resistances += "Stealth ";
            this.Darkvision = true;
        }
        /* methods */

        /* Talons: 
           Melee Weapon Attack: +3 to hit, reach 5 ft., one creature. 
           Hit: (1d1) slashing damage.
        */
        public string Talon(Creature defender)
        {
            int toHit = Dice.Roll(20, 3);
            if (toHit > defender.ArmorClass || toHit == 20)
            {
                int damage = Dice.Roll(1, 1);
                defender.HP -= damage;
                return "Owl sinks his talons into " + defender.GetType().Name +
                        " for " + damage + " slashing damage!";
            }
            else
            {
                return "Owl fails to reach target " + defender.GetType().Name + "!";
            }
        }
        public override string ToString()
        {
            return base.ToString()
                + "\nAttacks:\n  Talon";
        }

        public override string Attack(Creature c)
        {
            return Talon(c);
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
