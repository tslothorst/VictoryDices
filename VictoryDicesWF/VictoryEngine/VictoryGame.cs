using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace VictoryEngine
{
    public class VictoryGame
    {
        Random dices = new Random();
        UInt64 totalCost = 0;
        int totalPoints = 0;
        int totalRounds = 0;
        int totalPrize = 1;
        bool verbose = false;

        public VictoryResult PlayGame2()
        {
            Dices dazzle = new Dices();
            Carny cheater = new Carny();
            dazzle.dices = dices;
            string output = "";

            for (int i = 0; totalPoints < 100; i++)
            {
                dazzle.rollDices();
                cheater.rollResult = dazzle.diceResult;
                cheater.tallyResults();
                totalCost += cheater.price;
                totalPoints += cheater.points;
                totalPrize += cheater.prize;
                totalRounds = i;
            }
            return new VictoryResult() { TotalCost = totalCost, TotalPrize = totalPrize, TotalRounds = totalRounds + 1 };
        }

        public void PlayGame()
        {
            VictoryResult v = PlayGame2();
            Console.WriteLine("You needed {0} rounds to win the game", v.TotalRounds);
            Console.WriteLine("Total cost for this victory was " + v.TotalCost.ToString("C0", CultureInfo.CurrentUICulture));
            Console.WriteLine("You won {0} prizes", v.TotalPrize);
            Console.ReadLine();
        }

        //public void PlayGame()
        //{
        //    Dices dazzle = new Dices();
        //    Carny cheater = new Carny();
        //    dazzle.dices = dices;

        //    for (int i = 0; totalPoints < 100; i++)
        //    {
        //        dazzle.rollDices();
        //        cheater.rollResult = dazzle.diceResult;
        //        cheater.tallyResults();
        //        totalCost += cheater.price;
        //        totalPoints += cheater.points;
        //        totalPrize += cheater.prize;
        //        totalRounds = i;
        //        if (verbose)
        //        {
        //            dazzle.showRolls();
        //            Console.WriteLine();
        //            Console.WriteLine("Round: {0}", i + 1);
        //            Console.WriteLine("Total number of the dice " + dazzle.diceResult);
        //            Console.WriteLine("The total points so far: " + totalPoints);
        //            Console.WriteLine("The total cost so far: " + totalCost.ToString("C0", CultureInfo.CurrentUICulture));
        //            Console.WriteLine();
        //        }
        //    }
        //    Console.WriteLine("You needed {0} rounds to win the game", totalRounds + 1);
        //    Console.WriteLine("Total cost for this victory was " + totalCost.ToString("C0", CultureInfo.CurrentUICulture));
        //    Console.WriteLine("You won {0} prizes", totalPrize);
        //    Console.ReadLine();
        //}
    }
}
