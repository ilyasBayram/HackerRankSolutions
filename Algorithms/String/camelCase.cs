using System;

namespace camelCase
{
    class Program
    {
        public static int camelcase(string s)
        {
            int count = 0;

            foreach(char c in s)
            {
                if (char.IsUpper(c))
                {
                    count++;
                }
            }

            return count + 1;
        }
        static void Main(string[] args)
        {
            Console.Write("Please enter the word: ");
            string s = Console.ReadLine();
            int result = camelcase(s);
            Console.WriteLine("\n"+result);
            Console.ReadLine();

        }
    }
}
