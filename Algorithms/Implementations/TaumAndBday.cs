using System;

namespace TaumAndBday
{
    class Program
    {

        public static long taumBday(int b, int w, int bc, int wc, int z)
        {
            return (long)b * Math.Min(bc, wc + z) + (long)w * Math.Min(wc, bc + z);
        }
        static void Main(string[] args)
        {
            int b = 27984;
            int w = 1402;
            int bc = 619246;
            int wc = 615589;
            int z = 247954;

            long answer = taumBday(b, w, bc, wc, z);
            Console.WriteLine(answer);
            Console.ReadLine();

        }
    }
}
