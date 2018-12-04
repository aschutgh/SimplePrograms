using System;
using System.Collections.Generic;

namespace ElementaryNumberTheory
{
    class Program
    {

        static bool prime(int n)
        {
            if (n < 2) return false;

            for(int i = 2; i*i <= n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        static int abs(int n)
        {
            //if (n < 0) return -n;
            //if (n >= 0) return n;
            return n < 0 ? -n : n;
        }

        static int gcdeuclid(int a, int b)
        {
            if (b == 0) return a;
            return gcdeuclid(b, a % b);
        }

        //static int gcdfactors(int a, int b)
        //{

        //}

        //static List<int> factors(int n)
        //{

        //}

        //static int max(int a, int b)
        //{
        //    return 0;
        //}

        //static int min(int a, int b)
        //{
        //    return 0;
        //}

        static void Main(string[] args)
        {
            string primeorcom;
            for(int i = 0; i <= 100; i++)
            {
                primeorcom = prime(i) == true ? "prime" : "composite";
                Console.WriteLine($"{i} is {primeorcom}.");
            }
        }
    }
}
