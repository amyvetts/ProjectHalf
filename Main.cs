using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHalf
{
    class MainClass
    {

        public Races raceNames;
        public static void Main(string[] args)
        {
            string input = "";
            string name = "";
            int[] priorityArray = new int[6];

            //string [] raceNames = Enum.GetNames(typeof(Races));
            Races r = 0;



            while (input != "x")
            {

                System.Console.WriteLine("Welcome to what exactly, I am not sure of yet.");
                System.Console.WriteLine("Let's make a Player and go from there.");
                System.Console.WriteLine("What would you like to name your character: ");
                name = System.Console.ReadLine();

                Console.WriteLine("Thank you, " + name);
                System.Console.WriteLine("Now choose which type of creature you are: ");
                System.Console.WriteLine("1 - Player");
                System.Console.WriteLine("2 - Skeleton");
                System.Console.WriteLine("3 - Ghost");
                System.Console.WriteLine("4 - Couatl");
                System.Console.WriteLine("5 - Deva");
                System.Console.WriteLine("6 - Crab");
                System.Console.WriteLine("7 - Owl");
                System.Console.WriteLine("8 - Badger");
                System.Console.WriteLine("9 - Flying Snake");
                System.Console.WriteLine("10 - Scorpion");
                System.Console.WriteLine();
                System.Console.WriteLine("x - EXIT");
                input = System.Console.ReadLine();
                Creature creature = null;
                if (input == "1")
                {
                    creature = new PlayerCharacter(name);
                    
                }
                else if (input == "2")
                {
                    creature = new Skeleton(name);
                }
                else if (input == "3")
                {
                    creature = new Ghost(name);
                }
                else if (input == "4")
                {
                    creature = new Couatl(name);
                }
                else if (input == "5")
                {
                    creature = new Deva(name);
                }
                else if (input == "6")
                {
                    creature = new Crab(name);
                }
                else if (input == "7")
                {
                    creature = new Owl(name);
                }
                else if (input == "8")
                {
                    creature = new Badger(name);
                }
                else if (input == "9")
                {
                    creature = new FlyingSnake(name);
                }
                else if (input == "10")
                {
                    creature = new Scorpion(name);
                }

                if (input != "x")
                {
                    System.Console.Clear();
                    System.Console.WriteLine(creature);
                    System.Console.WriteLine("========================");
                    System.Console.WriteLine("\nPress ENTER to continue.");
                    System.Console.ReadLine();
                }
                else
                {
                    System.Console.WriteLine();
                    
                }
                System.Console.WriteLine();
                System.Console.Write("Strength: ");
                priorityArray[0] = Convert.ToInt16(System.Console.ReadLine());
                System.Console.Write("Dexterity: ");
                priorityArray[1] = Convert.ToInt16(System.Console.ReadLine());
                System.Console.Write("Constitution: ");
                priorityArray[2] = Convert.ToInt16(System.Console.ReadLine());
                System.Console.Write("Intelligence: ");
                priorityArray[3] = Convert.ToInt16(System.Console.ReadLine());
                System.Console.Write("Wisdom: ");
                priorityArray[4] = Convert.ToInt16(System.Console.ReadLine());
                System.Console.Write("Charisma: ");
                priorityArray[5] = Convert.ToInt16(System.Console.ReadLine());
                System.Console.WriteLine();
                PlayerCharacter player = new PlayerCharacter(name);
                player.RollStats(name, priorityArray);
                player.ToString();

            }
            
            

        }
        
            


        

    }
}