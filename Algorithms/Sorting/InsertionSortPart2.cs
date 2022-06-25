using System;
using System.Collections.Generic;

namespace InsertionSortPart2
{
    class Program
    {

        public static void insertionsort2(int n, List<int> arr)
        {

            int temp;

            for (int i = 0; i < n-1; i++)
            {
                if (arr[i + 1] < arr[i])
                {
                    for (int k = i+1; k > 0; k--)
                    {
                        if (arr[k] < arr[k-1])
                        {
                            temp = arr[k];
                            arr[k] = arr[k - 1];
                            arr[k - 1] = temp;
                        }
                        
                    } 

                }

                for (int j = 0; j < n; j++)
                {
                    Console.Write(arr[j]+" ");
                }

                Console.WriteLine();
            }

        }

        static void Main(string[] args)
        {
            List<int> arr = new List<int>() { 1, 4, 3, 5, 6, 2 };
            int n = 6;

            insertionsort2(n, arr);
            
            Console.ReadLine();
        }
    }
}
