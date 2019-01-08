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

        static bool palindrome(string word)
        {
            if (word.Length <= 1)
            {
                return true;
            }
            else
            {
                if (word[0] != word[word.Length - 1])
                {
                    return false;
                }
                else
                    return palindrome(word.Substring(1, word.Length - 2));
            }
        }

        static void Main(string[] args)
        {
            for (int i = 0; i <= 20; i++)
            {
                Console.WriteLine($"{i} : {fac(i)}");
            }
            Console.WriteLine("\n\n");

            Console.WriteLine("racecar is a palindrome: {0}", palindrome("racecar"));
            Console.WriteLine("Hello is a palindrome: {0}", palindrome("Hello"));
            Console.WriteLine("The letter A is a palindrome: {0}", palindrome("A"));
            Console.WriteLine("The string cc is a palindrome: {0}", palindrome("cc"));
            Console.WriteLine("The string ada is a palindrome: {0}", palindrome("ada"));
            Console.WriteLine("The string abba is a palindrome: {0}", palindrome("abba"));
            Console.WriteLine("An empty string is a palindrome: {0}", palindrome(""));
            Console.WriteLine("The string radar is a palindrome: {0}", palindrome("radar"));
            Console.WriteLine("The string jupyter is a palindrome: {0}", palindrome("jupyter"));
        }
    }
}