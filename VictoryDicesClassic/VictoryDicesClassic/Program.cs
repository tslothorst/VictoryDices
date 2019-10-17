using System;
using System.Globalization;

namespace VictoryDicesClassic
{
  class Program
  {
    static void Main(string[] args)
    {
      Random dices = new Random();
      UInt64 totalCost = 0;
      int totalPoints = 0;
      int totalRounds = 0;
            int totalPrize = 1;
      bool verbose = false;
      Dices dazzle = new Dices();
      Carny cheater = new Carny();
      dazzle.dices = dices;

      if (args.Length > 0)
      {
        if (args[0].ToLower() == "-v" | args[0].ToLower() == "--verbose")
        {
          verbose = true;
        }
        if (!(args[0].ToLower() == "-v" | args[0].ToLower() == "--verbose"))
        {
          throw new Exception("ERROR: Expected -v or --verbose as parameter");
        }
      }

      for (int i = 0; totalPoints < 100; i++)
      {
        dazzle.rollDices();
        cheater.rollResult = dazzle.diceResult;
        cheater.tallyResults();
        totalCost += cheater.price;
        totalPoints += cheater.points;
        totalPrize += cheater.prize;
        totalRounds = i;
        if (verbose)
        {
          dazzle.showRolls();
          Console.WriteLine();
          Console.WriteLine("Round: {0}", i + 1);
          Console.WriteLine("Total number of the dice " + dazzle.diceResult);
          Console.WriteLine("The total points so far: " + totalPoints);
          Console.WriteLine("The total cost so far: " + totalCost.ToString("C0", CultureInfo.CurrentUICulture));
          Console.WriteLine();
        }
      }
      Console.WriteLine("You needed {0} rounds to win the game", totalRounds + 1);
      Console.WriteLine("Total cost for this victory was " + totalCost.ToString("C0", CultureInfo.CurrentUICulture));
      Console.WriteLine("You won {0} prizes", totalPrize);
      Console.ReadLine();
    }
  }
}
