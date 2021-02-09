using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting_Algorithms
{
    public static class HeapSort
    {
        public static int[] Sort(int[] arr)
        {
            return Heapsort(arr);
        }

        private static int[] Heapsort(int[] arr)
        {
            for (var i = arr.Length; i > 0; i--)
            {
                heapify(arr,arr.Length, i);
            }

            for (var i = arr.Length - 1; i > 0; i--)
            {
                var temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                heapify(arr, i, 0);
            }

            return arr;
        }

        private static void heapify(int[] arr, int n, int i)
        {
            var largest = i;
            var l = 2 * i + 1;
            var r = 2 * i + 2;

            if (l < n && arr[l] > arr[largest]) largest = l;
            if (r < n && arr[r] > arr[largest]) largest = r;

            if (largest != i)
            {
                var temp = arr[i];
                arr[i] = arr[largest];
                arr[largest] = temp;

                heapify(arr,n, largest);
            }
        }
    }
}
