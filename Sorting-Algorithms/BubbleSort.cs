using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting_Algorithms
{
    public static class BubbleSort
    {
        public static int[] Sort(int[] arr)
        {
            for (var i = 0; i < arr.Length; i++)
            {
                for (var j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j + 1] < arr[j])
                    {
                        var temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                    }
                }
            }

            return arr;
        }
    }
}
