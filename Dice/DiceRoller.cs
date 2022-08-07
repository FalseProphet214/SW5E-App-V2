using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW5E_App.Dice
{
    internal class DiceRoller
    {
        public static DiceRoller Instance { get; } = new DiceRoller();
        public Random die { get; } = new Random();
        public DiceRoller()
        { }

        public int dFour(int amount)
        {
            int Result = 0;

            for (int i = 0; i < amount; i++)
            {
                int roll = die.Next(1, 5);
                Result += roll;
            };

            return Result;
        }

        public int dSix(int amount)
        {
            int Result = 0;

            for (int i = 0; i < amount; i++)
            {
                int roll = die.Next(1, 7);
                Result += roll;
            };

            return Result;
        }

        public int dEight(int amount)
        {
            int Result = 0;

            for (int i = 0; i < amount; i++)
            {
                int roll = die.Next(1, 8);
                Result += roll;
            };

            return Result;
        }

        public int dTen(int amount)
        {
            int Result = 0;

            for (int i = 0; i < amount; i++)
            {
                int roll = die.Next(1, 11);
                Result += roll;
            };

            return Result;
        }

        public int dTwelve(int amount)
        {
            int Result = 0;

            for (int i = 0; i < amount; i++)
            {
                int roll = die.Next(1, 13);
                Result += roll;
            };

            return Result;
        }

        public int dTwenty(int amount)
        {
            int Result = 0;

            for (int i = 0; i < amount; i++)
            {
                int roll = die.Next(1, 21);
                Result += roll;
            };

            return Result;
        }

        public int dOneHundred(int amount)
        {
            int Result = 0;

            for (int i = 0; i < amount; i++)
            {
                int roll = die.Next(1, 101);
                Result += roll;
            };

            return Result;
        }
    }
}
