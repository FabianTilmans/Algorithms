using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting_Algorithms
{
    public static class MergeSort
    {
        public static int[] Sort(int[] arr)
        {
            return Mergesort(arr);
        }

        private static int[] Mergesort(int[] arr)
        {
            //Lists
            int[] l;
            int[] r;
            int[] ret = new int[arr.Length];

            
            //Check if the array has values or is big enough
            if (arr.Length <= 1) return arr;

            //declare array size
            int mid = arr.Length / 2;
            l = new int[mid];

            r = arr.Length%2==0 ? new int[mid] : new int[mid+1];

            //Filling arrays with values
            for (var i = 0; i < mid; i++)
            {
                l[i] = arr[i];
            }

            var x = 0;
            for (var i = mid; i < arr.Length; i++)
            {
                r[x] = arr[i];
                x++;
            }

            l = Mergesort(l);
            r = Mergesort(r);
            return merge(l, r);
        }

        private static int[] merge(int[] l, int[] r)
        {
            int resultLength = l.Length + r.Length;
            int[] ret = new int[resultLength];

            var lIndex = 0;
            var rIndex = 0;
            var resultIndex = 0;

            while (lIndex < l.Length || rIndex < r.Length)
            {
                if (lIndex < l.Length && rIndex < r.Length)
                {
                    if (l[lIndex] <= r[rIndex])
                    {
                        ret[resultIndex] = l[lIndex];
                        lIndex++;
                        resultIndex++;
                    }
                    else
                    {
                        ret[resultIndex] = r[rIndex];
                        rIndex++;
                        resultIndex++;
                    }
                }
                else
                {
                    if (lIndex < l.Length)
                    {
                        ret[resultIndex] = l[lIndex];
                        lIndex++;
                        resultIndex++;
                    }
                    else if(rIndex < r.Length)
                    {
                        ret[resultIndex] = r[rIndex];
                        rIndex++;
                        resultIndex++;
                    }
                }
            }

            return ret;
        }
    }
}
