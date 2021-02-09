using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting_Algorithms
{
    public static class QuickSort
    {
        public static int[] Sort(int[] arr)
        {
            return Quicksort(0, arr.Length-1, arr);
        }

        private static int[] Quicksort(int l, int r, int[] arr)
        {
            if(l < r)
            {
                int teiler = Teiler(l, r, arr);
                Quicksort(l, teiler - 1, arr);
                Quicksort(teiler + 1, r, arr);
            }
            return arr;
        }

        private static int Teiler(int l, int r, int[] arr)
        {
            int i = l;
            int j = r - 1;
            int pivot = arr[r];

            while(i < j)
            {
                while(i < r && arr[i] < pivot)
                {
                    i++;
                }
                while(j > l && arr[j] >= pivot)
                {
                    j--;
                }

                if(i < j)
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            if(arr[i] > pivot)
            {
                int temp = arr[i];
                arr[i] = arr[r];
                arr[r] = temp;
            }

            return i;
        }
    }
}
