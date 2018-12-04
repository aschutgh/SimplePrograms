using System;
using System.Numerics;

namespace RecursionExamples
{
    class Program
    {
        static BigInteger fac(BigInteger n)
        {
            if (n == 0) return 1;
            return n * fac(n - 1);
        }

        //static bool palinedrome(string word)
        //{

        //}

        static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine($"{i} : {fac(i)}");
            }
        }
    }
}