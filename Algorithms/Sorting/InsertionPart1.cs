using System;
using System.Collections.Generic;

namespace InsertionPart1
{
    class Program
    {

        public static void insertionSort1(int n, List<int> arr)
        {
            int compare = arr[n-1];

            for (int i = n; i - 1  >= 0 ; i--)
            {

                if (arr[0] == arr[1])
                {
                    arr[0] = compare;

                    for (int j = 0; j < arr.Count; j++)
                    {
                        Console.Write(arr[j] + " ");
                    }

                    break;
                }

                if (arr[i-2] < compare)
                {
                    arr[i - 1] = compare;

                    for (int j = 0; j < arr.Count; j++)
                    {
                        Console.Write(arr[j] + " ");
                    }

                    break;
                }

                arr[i-1] = arr[i - 2];


                for (int j = 0; j < arr.Count; j++)
                {
                    Console.Write(arr[j] + " ");
                }

                Console.WriteLine("");
            }


        }

        static void Main(string[] args)
        {
            List<int> arr = new List<int>() { 2,4,6,8,3 };
            int n = 5;
            insertionSort1(n, arr);

            Console.ReadLine();
            
        }
    }
}
