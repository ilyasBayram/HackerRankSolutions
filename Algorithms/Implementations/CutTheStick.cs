using System;
using System.Collections.Generic;
using System.Linq;

namespace CutTheSticks
{
    class Program
    {
        public static List<int> cutTheSticks(List<int> arr)
        {
            List<int> count = new List<int>();
            int min;
            for (int i = 0; i <= arr.Count; i++)
            {
                count.Add(arr.Count);
                min = arr.Min();
                for (int j = 0; j < arr.Count; j++)
                {
                    arr[j] = arr[j] - min;
                    if (arr[j] <=0)
                    {
                        arr.RemoveAt(j);
                        j -= 1;
                    }
                }
                i = 0;
            }

            return count;
        }
        static void Main(string[] args)
        {
            List<int> arr = new List<int>();
            Console.Write("Please enter the number of list:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("\nPlease enter the {0}. number of list: ", i+1);
                arr.Add(int.Parse(Console.ReadLine()));
            }

            List<int> result =cutTheSticks(arr);

            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine("\n" + result[i]);
            }
            ;
            Console.ReadLine();
        }
    }
}
