using System;
using System.Collections.Generic;
using System.Text;

namespace VictoryEngine
{
    public class VictoryResult
    {
        /// <summary>
        /// Number of rounds played
        /// </summary>
        public int TotalRounds { get; set; }

        /// <summary>
        /// Total cost for the user
        /// </summary>
        public UInt64 TotalCost { get; set; }

        /// <summary>
        /// Total prizes gained
        /// </summary>
        public int TotalPrize { get; set; }
    }
}
