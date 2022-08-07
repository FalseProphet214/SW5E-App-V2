using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW5E_App.Dice
{
    internal class AbilityScoreRoller
    {
        public static AbilityScoreRoller Instance { get; } = new AbilityScoreRoller();
        public Random d6 { get; } = new Random();
        public AbilityScoreRoller()
        { }

        public int AbilityScore()
        {
            int rollSum = 0;
            int lowest = 7;

            for (int i = 0; i < 4; i++)
            {
                int roll = d6.Next(1, 7);
                rollSum += roll;

                if (roll < lowest)
                    lowest = roll;
            }

            int result = rollSum - lowest;
            return result;
        }
    }
}
