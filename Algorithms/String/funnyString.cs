using System;
using System.Collections.Generic;
using System.Linq;

namespace FunnyString
{
    class Program
    {
        public static string funnyString(string s)
        {
            if (string.IsNullOrEmpty(s) || s.Length < 3)
                return "Funny";

            List<int> count = new List<int>();

            List<int> countReverse = new List<int>();

            for (int i = 0; i < s.Length; i++)
            {
                count.Add(Convert.ToInt32(s[i]));
                countReverse.Add(Convert.ToInt32(s[s.Length-1-i]));
            }
            

            for (int i = 0; i < count.Count - 1; i++)
            {
                count[i] = (Math.Abs(count[i] - count[i + 1]));
                countReverse[i] = (Math.Abs(countReverse[i] - countReverse[i + 1]));
            }

            count.RemoveAt(count.Count - 1);
            countReverse.RemoveAt(countReverse.Count - 1);

            bool result = count.SequenceEqual(countReverse);


            return  result==true? "Funny" : "Not Funny";
        }
        static void Main(string[] args)
        {
            string s = "bcxz";

            string result = funnyString(s);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
