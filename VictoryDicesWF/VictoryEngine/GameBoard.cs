using System;
using System.Collections.Generic;
using System.Text;

namespace VictoryEngine
{
    class GameBoard
    {
        //public readonly List<int> greenNumbers = new List<int> { 18, 38, 19, 37, 36, 21, 35 };
        public readonly HashSet<int> greenNumbers = new HashSet<int> { 18, 38, 19, 37, 36, 21, 35 };

        public readonly Dictionary<int, int> redNumbers = new Dictionary<int, int>
        {
            { 42, 20 },
            { 15, 15 },
            { 41, 15 },
            { 14, 20 },
            { 9, 100 },
            { 48, 100 },
            { 8, 100 },
            { 47, 100 },
            { 44, 50 },
            { 13, 50 },
            { 43, 50 },
            { 12, 50 },
            { 46, 50 },
            { 11, 30 },
            { 45, 30 },
            { 10, 50 },
            { 16, 10 },
            { 40, 5 },
            { 17, 5 },
            { 39, 5 }
        };
        public readonly List<int> blackNumbers = new List<int>() { 28, 26, 30, 27, 32, 25, 31, 24, 34, 23, 33, 22 };

        public GameBoard()
        {

        }
    }
}
