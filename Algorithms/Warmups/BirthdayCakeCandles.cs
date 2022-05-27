using System;
using System.Collections.Generic;
using System.Linq;

namespace BirthdayCandle
{
    class Program
    {

        public static int birthdayCakeCandles(List<int> candles)
        {
            Console.WriteLine("Please enter the size of candles");
            int candlescount = Convert.ToInt32(Console.ReadLine());
            int count= 0;

            for (int i = 0; i < candlescount; i++)
            {
               Console.WriteLine("Please enter the numbers");
               candles.Add(Convert.ToInt32(Console.ReadLine()));
            }
            int max = candles.Max();
            for (int i = 0; i < candles.Count; i++)
            {
               if (candles[i] == max)
                   count++;
            }

             return count;
        }

        static void Main(string[] args)
        {
            
            List<int> candles = new List<int>();
            Console.WriteLine(birthdayCakeCandles(candles));
            Console.ReadLine();

            
 
        }
    }
}
