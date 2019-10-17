using System;
using System.Collections.Generic;
using System.Text;

namespace VictoryEngine
{
    class Dices
    {

        //private Random _dices;
        public Random dices;
        private readonly List<int> _diceResults = new List<int>();
        public int diceResult;

        public Dices()
        {
            //_dices = new Random();
        }

        public void rollDices()
        {
            diceResult = 0;
            _diceResults.Clear();
            for (int i = 0; i < 8; i++)
            {                
                _diceResults.Add(dices.Next(1, 7));
            }
            foreach (var item in _diceResults)
            {
                diceResult += item;
            }
        }

        public void showRolls()
        {
            foreach (var item in _diceResults)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("Dice total: " + diceResult);

        }

    }
}
