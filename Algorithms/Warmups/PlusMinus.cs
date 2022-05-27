using System;
using System.Collections.Generic;

namespace PlusMinus
{
    class Program
    {

        
        public static void PlusMinus(List<int> arr)
        {
            
            double positiveNumber = 0;
            double negativeNumber = 0;
            double zeroNumber = 0;
            double positiveValue;
            double negativeValue;
            double zeroValue;

            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i]>0)
                {
                    positiveNumber++;
                }
                else if (arr[i] < 0)
                {
                    negativeNumber++;
                }
                else if (arr[i] == 0)
                {
                    zeroNumber++;
                }
            }
            positiveValue = positiveNumber/arr.Count;
            negativeValue = negativeNumber/arr.Count;
            zeroValue = zeroNumber/arr.Count;
            Console.WriteLine("{0:N6}",positiveValue);
            Console.WriteLine("{0:N6}",negativeValue);
            Console.WriteLine("{0:N6}",zeroValue);
        }

        

        static void Main(string[] args)
        {
            List<int> arr = new List<int>();
            Console.WriteLine("Please enter the how many digits the array will be?:");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                arr.Add(Convert.ToInt32(Console.ReadLine()));
            }
            PlusMinus(arr);
        }
    }
}
