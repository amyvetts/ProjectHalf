using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHalf
{
    class Badger : TinyBeast
    {
        string message = "";
        public Badger(string n) : base()
        {
            this.Name = n;
            this.Strength = 4;
            this.Dexterity = 11;
            this.Constitution = 12;
            this.Intelligence = 2;
            this.Wisdom = 12;
            this.Charisma = 5;

            //HP 1d4s+1
            this.HP = Dice.Roll(1, 4, 1);

            this.ArmorClass = 10; 
            this.Resistances += "Perception ";
            this.Darkvision = true;
        }
        /* methods */

        /* Bite: 
           Melee Weapon Attack: +2 to hit, reach 5 ft., one creature. 
           Hit: (1d1) piercing damage.
        */
        public string Bite(Creature defender)
        {
            int toHit = Dice.Roll(20, 2);
            if (toHit > defender.ArmorClass || toHit == 20)
            {
                int damage = Dice.Roll(1, 1);
                defender.HP -= damage;
                return "Badger goes in and bites " + defender.GetType().Name +
                        " for " + damage + " piercing damage!";
            }
            else
            {
                return "Badger fails to reach target " + defender.GetType().Name + "!";
            }
        }
        public override string ToString()
        {
            return base.ToString()
                + "\nAttacks:\n  Bite";
        }

        public override string Attack(Creature c)
        {
            return Bite(c);
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
