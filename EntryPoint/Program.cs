﻿using System;
using Sorting_Algorithms;

namespace EntryPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new []{9,4,3,4,1,5,6,4};

            arr = MergeSort.Sort(arr);
            foreach (int i in arr)
            {
                Console.Write(i +", ");
            }
        }
    }
}
 