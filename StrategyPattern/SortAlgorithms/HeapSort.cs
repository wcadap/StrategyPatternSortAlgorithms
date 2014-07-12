using StrategyPattern.Interface;
using System.Collections.Generic;
using System.Linq;

namespace StrategyPattern.SortAlgorithms
{
    public class HeapSort : ISortStrategy
    {
        public List<int> SortNumbers(List<int> NumbersToSort)
        {
 	        int list_size = NumbersToSort.Count();
            int i, temp;
            for (i = (list_size / 2) - 1; i >= 0; i--) siftDown(NumbersToSort, i, list_size-1);                

            for (i = list_size - 1; i >= 1; i--)
                {
                    temp = NumbersToSort[0];
                    NumbersToSort[0] = NumbersToSort[i];
                    NumbersToSort[i] = temp;
                    siftDown(NumbersToSort, 0, i - 1);
                }
            return NumbersToSort;
        }

        private void siftDown(List<int> NumbersToSort, int root, int bottom)
        {
            int done, maxChild, temp;
            done = 0;
            while ((root * 2 <= bottom) && (done == 0))
            {
                if (root * 2 == bottom)
                    maxChild = root * 2;
                else if (NumbersToSort[root * 2] > NumbersToSort[root * 2 + 1])
                    maxChild = root * 2;
                else
                    maxChild = root * 2 + 1;
                if (NumbersToSort[root] < NumbersToSort[maxChild])
                {
                    temp = NumbersToSort[root];
                    NumbersToSort[root] = NumbersToSort[maxChild];
                    NumbersToSort[maxChild] = temp;
                    root = maxChild;
                }
                else
                    done = 1;
            }
        }
    }
        
}
