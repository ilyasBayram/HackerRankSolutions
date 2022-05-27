using System;
using System.Collections.Generic;

namespace DiagonalDifference
{
    class Program
    {

        public static int diagonalDifference(List<List<int>> arr)
        {
            int index = 0;
            int secondIndex = arr.Count - 1;
            int firstValue = 0;
            int secondValue = 0;
            int answer;
            for (int i = 0; i < arr.Count; i++)
            {
                firstValue += arr[index][index];
                index++;
            }
            index = 0;
            for (int j = 0; j < arr.Count; j++)
            {
                secondValue += arr[index][secondIndex];
                secondIndex--;
                index++;
            }
            answer = (firstValue - secondValue);
            if (answer < 0)
            {
                answer = answer * -1;
            }
            return answer;
        }

        static void Main(string[] args)
        {
            List<List<int>> arr = new List<List<int>>();
            List<int> subarr = new List<int>();
            int result;
            Console.WriteLine("Please enter the row and colum number");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("Please enter  number of  coulum");
                    subarr.Add(Convert.ToInt32(Console.ReadLine()));
                }
                arr[i]=subarr;
                subarr.Clear();
            }
            result=diagonalDifference(arr);
            Console.WriteLine(result);
            
            Console.ReadLine();
        }
    }
}
