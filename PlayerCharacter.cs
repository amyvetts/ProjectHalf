using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHalf
{


     class PlayerCharacter : Creature
    {

        string message = "";

        public Item[] inventory { get; set; }
        public Races raceNames { get; protected set; }

        public PlayerCharacter(string n) : base()
        {
            this.Name = n;
            this.raceNames = Races.Human;
            this.Strength = 16;
            this.Dexterity = 16;
            this.Constitution = 16;
            this.Intelligence = 16;
            this.Wisdom = 13;
            this.Charisma = 13;
            this.X = 6;
            this.Y = 5;
            this.Facing = Direction.NORTH;
            this.inventory = new Item[4];


            //HP 4d6
            this.HP = Dice.Roll(4, 6);
            this.ArmorClass = 11;
            this.Resistances += " ";
            this.Darkvision = true;
            this.inventory = new Item[4];

            
        }
        public void RollStats(string name, int[] priorityArray)
        {
            // Sort stats
            int priority = 0;
            int minPrior = 0;
            int maxPrior = 0;
            int[] statsArray = new int[6];
            int[] sortedArray = new int[6];
            int[] dice = new int[4];
            for (int i = 0; i < statsArray.Length; i++)
            {
                for (int die = 0; die < dice.Length; die++)
                {
                    dice[die] = Dice.Roll(6);
                }
                statsArray[i] = dice.Sum() - dice.Min();
            }
            for (int b = 0; b < sortedArray.Length; b++)
            {
                priority = priority + 1;
                for (int c = 0; c < priorityArray.Length; c++)
                {
                    if (priorityArray[c] == priority)
                    {
                        minPrior = priorityArray[c];
                        priorityArray[c] = 7;
                    }
                }
                for (int d = 0; d < statsArray.Length; d++)
                {
                    if (statsArray[d] >= maxPrior)
                    {
                        maxPrior = statsArray[d];
                    }
                }               

            }
            System.Console.WriteLine();
            this.Strength = sortedArray[1];
            this.Dexterity = sortedArray[2];
            this.Constitution = sortedArray[3];
            this.Intelligence = sortedArray[4];
            this.Wisdom = sortedArray[5];
            this.Charisma = sortedArray[6];
            this.HP = 10 + (this.Constitution - 10) / 2;
            this.ArmorClass = 10 + (this.Dexterity - 10) / 2;
            // Add racial modifiers
            if (raceNames == Races.Dragonborn)
            {
                this.raceNames = Races.Dragonborn;
                this.Strength = this.Strength + 2;
                this.Charisma = this.Charisma + 1;
            }
            else if (raceNames == Races.HillDwarf)
            {
                this.raceNames = Races.HillDwarf;
                this.Constitution = this.Constitution + 2;
                this.Intelligence = this.Intelligence + 1;
            }
            else if (raceNames == Races.MountainDwarf)
            {
                this.raceNames = Races.MountainDwarf;
                this.Constitution = this.Constitution + 2;
                this.Strength = this.Strength + 2;
            }
            else if (raceNames == Races.DarkElf)
            {
                this.raceNames = Races.DarkElf;
                this.Dexterity = this.Dexterity + 2;
                this.Charisma = this.Charisma + 1;
            }
            else if (raceNames == Races.HighElf)
            {
                this.raceNames = Races.HighElf;
                this.Dexterity = this.Dexterity + 2;
                this.Intelligence = this.Intelligence + 1;
            }
            else if (raceNames == Races.WoodElf)
            {
                this.raceNames = Races.WoodElf;
                this.Dexterity = this.Dexterity + 2;
                this.Wisdom = this.Wisdom + 1;
            }
            else if (raceNames == Races.ForestGnome)
            {
                this.raceNames = Races.ForestGnome;
                this.Intelligence = this.Intelligence + 2;
                this.Dexterity = this.Dexterity + 1;
            }
            else if (raceNames == Races.RockGnome)
            {
                this.raceNames = Races.RockGnome;
                this.Intelligence = this.Intelligence + 2;
                this.Constitution = this.Constitution + 1;

            }
            else if (raceNames == Races.HalfElf)
            {
                int statPickOne = 0;
                int statPickSecond = 0;
                this.raceNames = Races.HalfElf;
                this.Charisma = this.Charisma + 2;
                while (statPickOne != null)
                {
                    statPickOne = (System.Console.ReadLine()).ToCharArray()[0];
                }
                if (statPickOne == '1')
                {
                    this.Strength = this.Strength + 1;
                }
                else if (statPickOne == '2')
                {
                    this.Dexterity = this.Dexterity + 1;
                }
                else if (statPickOne == '3')
                {
                    this.Constitution = this.Charisma + 1;
                }
                else if (statPickOne == '4')
                {
                    this.Intelligence = this.Intelligence + 1;
                }
                else
                {
                    this.Wisdom = this.Wisdom + 1; ;
                }
                System.Console.WriteLine();
                System.Console.Write("Choose the SECOND of TWO attritbutes to increase: ");
                while (statPickSecond < '1' || statPickSecond > '5')
                {
                    statPickSecond = (System.Console.ReadLine()).ToCharArray()[0];
                }
                if (statPickSecond == '1')
                {
                    this.Strength = this.Strength + 1;
                }
                else if (statPickSecond == '2')
                {
                    this.Dexterity = this.Dexterity + 1;
                }
                else if (statPickSecond == '3')
                {
                    this.Constitution = this.Charisma + 1;
                }
                else if (statPickSecond == '4')
                {
                    this.Intelligence = this.Intelligence + 1;
                }
                else
                {
                    this.Wisdom = this.Wisdom + 1; ;
                }
            }
            else if (raceNames == Races.HalfOrc)
            {
                this.raceNames = Races.HalfOrc;
                this.Strength = this.Strength + 2;
                this.Constitution = this.Constitution + 1;
            }
            else if (raceNames == Races.LightFoot)
            {
                this.raceNames = Races.LightFoot;
                this.Dexterity = this.Dexterity + 2;
                this.Charisma = this.Charisma + 1;
            }
            else if (raceNames == Races.Stout)
            {
                this.raceNames = Races.Stout;
                this.Dexterity = this.Dexterity + 3;

            }
            else if (raceNames == Races.Human)
            {
                this.raceNames = Races.Human;
                this.Strength = this.Strength + 1;
                this.Dexterity = this.Dexterity + 1;
                this.Constitution = this.Constitution + 1;
                this.Intelligence = this.Intelligence + 1;
                this.Wisdom = this.Wisdom + 1;
                this.Charisma = this.Charisma + 1;

            }
            else if (raceNames == Races.Tiefling)
            {
                this.raceNames = Races.Tiefling;
                this.Charisma = this.Charisma + 2;
                this.Intelligence = this.Intelligence + 1;
            }
            else
            {
                System.Console.WriteLine("ERROR: Invalid Race Type");
                System.Console.WriteLine();
                System.Console.WriteLine("You are now a Wood Elf!");
                System.Console.WriteLine();
                this.raceNames = Races.WoodElf;
                this.Dexterity = this.Dexterity + 2;
                this.Wisdom = this.Wisdom + 1;
            }
            System.Console.WriteLine();
        }
        public Item addToInventory(int addStock)
        {
            Item stock = inventory[addStock + 1];
            inventory[addStock + 1] = null;
            return stock;
        }

        public Item removeFromInventory(int placeHolder)
        {

            Item used = inventory[placeHolder - 1];
            inventory[placeHolder - 1] = null;
            return used;
        }

        public override string ToString()
        {
            string output =
                this.GetType().Name +
                "\n============" +
                "\nSTR: " + this.Strength +
                "\nDEX: " + this.Dexterity +
                "\nCON: " + this.Constitution +
                "\nINT: " + this.Intelligence +
                "\nWIS: " + this.Wisdom +
                "\nCHA: " + this.Charisma +
                "\n============" +
                "\nHP: " + this.HP +
                "\nAC: " + this.ArmorClass +
                "\nResistances: " + this.Resistances +
                "\n============" +
                "\nDarkvision: " + this.Darkvision + "\n";
            return output;
        }

        public override string Attack(Creature defender)
        {
            return ""; // add in attacks
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
