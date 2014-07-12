using StrategyPattern.Interface;
using System.Collections.Generic;

namespace StrategyPattern.Context
{
    public class SortContext
    {
        public List<int> NumbersToSort { get; set; }

        public ISortStrategy SortAlgorithm { set; get; }

        public List<int> GetSortedNumbers()
        {
            return SortAlgorithm.SortNumbers(this.NumbersToSort);
        }
    }
}
