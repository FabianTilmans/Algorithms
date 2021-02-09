using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting_Algorithms
{
    public static class InsertionSort
    {
        public static int[] Sort(int[] arr)
        {
            return Insertionsort(arr);
        }

        private static int[] Insertionsort(int[] arr)
        {
            for (var i = 1; i < arr.Length; ++i)
            {
                var key = arr[i];
                var j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    --j;
                }

                arr[j + 1] = key;
            }

            return arr;
        }
    }
}
