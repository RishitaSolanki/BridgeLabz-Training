using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ProjectThree.Sorting
{
    //Compare sorting algorithms Bubble Sort (O(N²)), Merge Sort (O(N log N)), and Quick Sort (O(N log N)).
    public class SortingLargeDataAndCompare
    {
        //Main Method
        public static void Main(string[] args)
        {
            int size = 1000;

            int[] original = new int[size];

            Random ran = new Random();

            for (int i = 0; i < size; i++) original[i] = ran.Next(10000);

            int[] bubbleData = (int[])original.Clone();

            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < bubbleData.Length - 1; i++)
            {
                for (int j = 0; j < bubbleData.Length - i - 1; j++)
                {
                    if (bubbleData[j] > bubbleData[j + 1])
                    {
                        int temp = bubbleData[j];
                        bubbleData[j] = bubbleData[j + 1];
                        bubbleData[j + 1] = temp;
                    }
                }
            }

            sw.Stop();

            Console.WriteLine($"Bubble Sort Time: {sw.Elapsed.TotalMilliseconds} ms");

            int[] mergeData = (int[])original.Clone();

            sw.Restart();

            MergeSort(mergeData, 0, mergeData.Length - 1);

            sw.Stop();

            Console.WriteLine($"Merge Sort Time: {sw.Elapsed.TotalMilliseconds} ms");

            int[] quickData = (int[])original.Clone();

            sw.Restart();

            QuickSort(quickData, 0, quickData.Length - 1);

            sw.Stop();

            Console.WriteLine($"Quick Sort Time: {sw.Elapsed.TotalMilliseconds} ms");
        }

        public static void MergeSort(int[] arr, int l, int r)
        {
            //l-left , r-right

            if (l < r)
            {
                int mid = l + (r - l) / 2;

                MergeSort(arr, l, mid);

                MergeSort(arr, mid + 1, r);

                Merge(arr, l, mid, r);
            }
        }

        public static void Merge(int[] arr, int l, int m, int r)
        {
            //l-left , r-right , m-mid 
            int n1 = m - l + 1;

            int n2 = r - m;

            int[] Left = new int[n1];

            int[] Right = new int[n2];

            for (int i = 0; i < n1; ++i) Left[i] = arr[l + i];

            for (int j = 0; j < n2; ++j) Right[j] = arr[m + 1 + j];

            int k = l, x = 0, y = 0;

            while (x < n1 && y < n2)
            {
                if (Left[x] <= Right[y]) arr[k++] = Left[x++];
                else arr[k++] = Right[y++];
            }
            while (x < n1) arr[k++] = Left[x++];
            while (y < n2) arr[k++] = Right[y++];
        }

        public static void QuickSort(int[] arr, int l, int h)
        {
            //l-low , h-high

            if (l < h)
            {
                int pi = Partition(arr, l, h);

                QuickSort(arr, l, pi - 1);

                QuickSort(arr, pi + 1, h);
            }
        }

        public static int Partition(int[] arr, int l, int h)
        {
            //l-low , h-high
            int pivot = arr[h];

            int i = (l - 1);

            for (int j = l; j < h; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    int temp = arr[i];

                    arr[i] = arr[j];

                    arr[j] = temp;
                }
            }
            int temp1 = arr[i + 1];

            arr[i + 1] = arr[h];

            arr[h] = temp1;

            return i + 1;
        }
    }
}
