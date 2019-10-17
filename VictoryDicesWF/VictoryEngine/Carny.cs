using System;
using System.Collections.Generic;
using System.Text;

namespace VictoryEngine
{
    class Carny
    {
        public int rollResult;
        public int points;
        public UInt64 price = 1;
        public int prize;

        GameBoard carnyBoard = new GameBoard();

        public Carny()
        {
            
        }

        public void tallyResults()
        {
            if ( rollResult == 29)
            {
                price *= 2;
            }
            prize = 0;
            if (carnyBoard.greenNumbers.Contains(rollResult))
            {
                prize = 1;
            }            
                try
                {
                    points = carnyBoard.redNumbers[rollResult];
                }
                catch (Exception)
                {

                    points = 0;
                }
                //price += 1;

            

            
        }
    }
}
