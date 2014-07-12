using System;
using System.Collections.Generic;
using StrategyPattern.Context;
using StrategyPattern.SortAlgorithms;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SortContext MasterSorter = new SortContext();

            MasterSorter.SortAlgorithm = new BubbleSort();
            MasterSorter.NumbersToSort = new List<int> {43,434,23,99,33,23,323 };

            List<int> SortedFromBubble = MasterSorter.GetSortedNumbers();

            MasterSorter.SortAlgorithm = new HeapSort();
            MasterSorter.NumbersToSort = new List<int> { 43, 434, 23, 99, 33, 23, 323};

            List<int> SortedFromHeap = MasterSorter.GetSortedNumbers();


            Console.WriteLine("Sorted from Bubble....");
            Console.WriteLine("==============================================");
            foreach (int number in SortedFromBubble)
            {
                Console.Write(string.Format("{0}, ", number));
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Sorted from Heap....");
            Console.WriteLine("==============================================");

            foreach (int number in SortedFromHeap)
            {
                Console.Write(string.Format("{0}, ", number));
            }

            Console.WriteLine("");
            Console.WriteLine("");
        }

    }
}
