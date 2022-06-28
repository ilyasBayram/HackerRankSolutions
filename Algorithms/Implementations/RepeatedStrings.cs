using System;

namespace RepeatedString
{
    class Program
    {
        public static long repeatedString(string s, long n)
        {
            long count = 0;

            if (s.Length > 1)
            {
                for (int i = 0; i < s.Length; i++)
                    if (s[i] == 'a')
                        count++;

                count *= n / s.Length;

                for (int j = 0; j < n % s.Length; j++)
                {
                    if (s[j] == 'a')
                        count++;

                }

            }
            else
            {
                if (!s.Contains('a'))
                    count = 0;
                else
                    count = n;
            }

            return count;
        }

        static void Main(string[] args)
        {
            int n = 10;
            string s = "aba";

           long result = repeatedString(s, n);
         

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
