using System;

namespace marsExploration
{
    class Program
    {
        public static int marsExploration(string s)
        {
            int count = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != 'S')
                    count++;
                if (s[i + 1] != 'O')
                    count++;
                if (s[i + 2] != 'S')
                    count++;

                i += 2;
            }
            return count;
        }

        static void Main(string[] args)
        {
            Console.Write("Please enter the sos massage: ");
            string s = Console.ReadLine();
            int result = marsExploration(s);
            Console.WriteLine("\n"+result);
            Console.ReadLine();
        }
    }
}
