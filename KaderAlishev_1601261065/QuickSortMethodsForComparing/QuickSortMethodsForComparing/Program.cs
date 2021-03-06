﻿using System;
using System.Collections.Generic;

namespace ComparingQuickSorts
{
    class Program
    {
        static void Main(int[] arr, int left, int right)
        {
            Console.WriteLine("\n------------ Quick Sort ------------\n");

            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                {
                    Main(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    Main(arr, pivot + 1, right);
                }
            }

        }

        private static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (true)
            {

                while (arr[left] < pivot)
                {
                    left++;
                }

                while (arr[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;

                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;


                }
                else
                {
                    return right;
                }
            }
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 5, -4, 11, 0, 18, };

            Console.WriteLine("Original array : ");
            foreach (var item in arr)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();

            Main(arr, 0, arr.Length - 1);

            Console.WriteLine();
            Console.WriteLine("Sorted array : ");

            foreach (var item in arr)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();
            Console.Read();
        }
    }


}