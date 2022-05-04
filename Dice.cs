using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHalf
{
    static class Dice
    {
        /* fields */

        private static Random RNG = new Random();

        /* methods */

        /* Simulates a random single die roll */
        public static int Roll(int sides)
        {
            return RNG.Next(sides) + 1;
        }

        /* Simulates random series of dice rolls 
            Adds an OPTIONAL bonus, example: 
            3D4 + 5
            is 3 three four-sided dice summed with an additional 5 added in.           
        */
        public static int Roll(int numDice, int sides, int bonus = 0)
        {
            int total = 0;
            for (int die = 0; die < numDice; die++)
            {
                total += Roll(sides);
            }
            return total + bonus;
        }
    }

}
