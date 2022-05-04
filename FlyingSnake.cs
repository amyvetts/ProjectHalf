using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHalf
{
    class FlyingSnake : TinyBeast
    {
        string message = "";
        public FlyingSnake(string n) : base()
        {
            this.Name = n;
            this.Strength = 4;
            this.Dexterity = 18;
            this.Constitution = 11;
            this.Intelligence = 2;
            this.Wisdom = 12;
            this.Charisma = 5;

            //HP 2d4s
            this.HP = Dice.Roll(2, 4);

            this.ArmorClass = 14; 
            this.Resistances += "Perception ";
            this.Darkvision = false;
        }
        /* methods */

        /* Bite: 
           Melee Weapon Attack: +6 to hit, reach 5 ft., one creature. 
           Hit: (3d4) poison damage and (1d1) piercing damage
        */
        public string Bite(Creature defender)
        {
            int toHit = Dice.Roll(20, 6);
            if (toHit > defender.ArmorClass || toHit == 20)
            {
                int damage = Dice.Roll(1, 1) + Dice.Roll(3, 4);
                defender.HP -= damage;
                return "Flying Snake goes in and bites " + defender.GetType().Name +
                        " for " + damage + " poison and piercing damage!";
            }
            else
            {
                return "Flying Snake fails to reach target " + defender.GetType().Name + "!";
            }
        }
        public override string ToString()
        {
            return base.ToString()
                + "\nAttacks:\n  bite";
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
