using System;
using System.Collections.Generic;
using System.Linq;

namespace ElectronicShop
{
    class Program
    {
        static int getMoneySpent(int[] keyboards, int[] drives, int b)
        {

            int answer = -1;

            for (int i = 0; i < keyboards.Length; i++)
            {
                for (int j = 0; j < drives.Length; j++)
                {
                    int maxNumber = keyboards[i] + drives[j];

                    if (maxNumber > answer && maxNumber <= b)

                    answer = maxNumber;
                } 

            }

            return answer;
        }

        static void Main(string[] args)
        {

            Console.Write("Please enter budget:");

            int b = int.Parse(Console.ReadLine());

            Console.Write("\nPlease enter the number of keyboards: ");

            int n = int.Parse(Console.ReadLine());

            Console.Write("\nPlease enter the number of USB Drives: ");

            int m = int.Parse(Console.ReadLine());

            int[] keyboards = new int[n];

            int[] drives = new int[m];

            for (int i = 0; i < n; i++)
            {
                Console.Write("\nPlease enter the {0}. keyboard price: ", i+1);
                keyboards[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < m; i++)
            {
                Console.Write("\nPlease enter the {0}. drive price: ", i + 1);
                
                drives[i] = int.Parse(Console.ReadLine());
            }

            int result = getMoneySpent(keyboards, drives, b);

            Console.WriteLine("\n"+result);

            Console.ReadLine();
        }
    }
}
