using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 1, 0, 7, 9, 87, 20, 90 };

            int tmp = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        tmp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++) Console.Write(arr[i] + " ");
            Console.Read();
        }
    }
}
