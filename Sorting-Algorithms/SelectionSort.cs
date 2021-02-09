using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting_Algorithms
{
    public static class SelectionSort
    {
        public static int[] Sort(int[] arr)
        {
            return Selectionsort(arr);
        }

        private static int[] Selectionsort(int[] arr)
        {
            for (int i = 0; i < arr.Length-1; i++)
            {
                var minIndex = i;
                for (var j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }

                var temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
                
            }

            return arr;
        }
    }
}
