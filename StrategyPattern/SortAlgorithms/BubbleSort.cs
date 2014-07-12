using StrategyPattern.Interface;
using System.Collections.Generic;

namespace StrategyPattern.SortAlgorithms
{
    public class BubbleSort : ISortStrategy
    {
        public List<int> SortNumbers(List<int> NumbersToSort)
        {
            int temp;
            for (int topIndex = 1; topIndex <= NumbersToSort.Count; topIndex++)
                for (int bottomIndex = 0; bottomIndex < NumbersToSort.Count - topIndex; bottomIndex++)
                    if (NumbersToSort[bottomIndex] > NumbersToSort[bottomIndex + 1])
                    {
                        temp = NumbersToSort[bottomIndex];
                        NumbersToSort[bottomIndex] = NumbersToSort[bottomIndex + 1];
                        NumbersToSort[bottomIndex + 1] = temp;
                    }
            return NumbersToSort;
        }
    }
}
