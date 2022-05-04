using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHalf
{
    class Skeleton : Undead
    {
        string message = "";
        /* Fields */
        /* Properties */
        /* Constructors */
        public Skeleton(string n) : base()
        {
            this.Name = n;
            this.Strength = 10;
            this.Dexterity = 14;
            this.Constitution = 15;
            this.Intelligence = 6;
            this.Wisdom = 8;
            this.Charisma = 5;

            //HP 2d8+4
            this.HP = Dice.Roll(2, 8, 4);

            this.ArmorClass = 13;
        }

        /* Methods */

        /* Shortsword:
           Melee Weapon Attack: +4 to hit, reach 5 ft., one target.
           Hit: (1d6 + 2) piercing damage.
        */
        public string Shortsword(Creature defender)
        {
            int toHit = Dice.Roll(20, 4);
            if (toHit > defender.ArmorClass || toHit == 20)
            {
                int damage = Dice.Roll(1, 6, 2);
                defender.HP -= damage;
                return "Skeleton thrusts his shortsword at " + defender.GetType().Name +
                        " and hits for " + damage + " piercing damage!";
            }
            else
            {
                return "Skeleton thrusts his shortsword at " + defender.GetType().Name + " and misses!";
            }
        }

        /* Longsword:
           Melee Weapon Attack: +4 to hit, reach 5 ft., one target.
           Hit: (1d8) slashing damage.
        */
        public string Longsword(Creature defender)
        {
            int toHit = Dice.Roll(20, 4);
            if (toHit > defender.ArmorClass || toHit == 20)
            {
                int damage = Dice.Roll(1, 8);
                defender.HP -= damage;
                return "Skeleton swings his longsword at " + defender.GetType().Name +
                        " and hits for " + damage + " slashing damage!";
            }
            else
            {
                return "Skeleton swings his longsword at " + defender.GetType().Name + " and misses!";
            }
        }

        public override string ToString()
        {
            return base.ToString()
                + "\nAttacks:\n  Longsword\n  Shortsword";
        }

        public override string Attack(Creature c)
        {
            if (Dice.Roll(2) == 1)
            {
                return Shortsword(c);
            }
            else
            {
                return Longsword(c);
            }

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
