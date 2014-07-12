using System.Collections.Generic;

namespace StrategyPattern.Interface
{
    public interface ISortStrategy
    {
        List<int> SortNumbers(List<int> NumbersToSort);
    }
}
