using System;
using System.Collections.Generic;
using System.Linq;

namespace MiniMaxSum
{
    class Program
    {
        public static void miniMaxSum(List<int> arr)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("please enter numbers");
              long n = Convert.ToInt64(Console.ReadLine());
                arr.Add((int)n);
            }
            long min = 0, max = 0, sum = 0;
            min = arr[0];
            max = min;
            sum = min;
            for (int i = 1; i < 5; i++)
            {
                sum += arr[i];
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine((sum - max) + " " + (sum - min));

        }

        static void Main(string[] args)
        {
            List<int> arr = new List<int>();
            miniMaxSum(arr);
        }
    }
}
