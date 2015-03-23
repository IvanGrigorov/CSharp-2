/* Write a program to calculate n! for each n in the range [1..100].*/



using System;
using System.Numerics;

namespace _10.NFaktoriel
{
    class NFaktoriel
    {
        static void Main(string[] args)
        {
            BigInteger[] memo = new BigInteger[101];
            for (int i = 0; i < 101; i++)
            {
                Console.WriteLine("Faktoriel from {0} is {1} ", i, Faktoriel(i, memo));
            }
        }
        static BigInteger Faktoriel(int n, BigInteger[] memo)
        {
            if (memo[n] != 0) return memo[n]; // With using an array we optimize the program 
            if (n == 0) return 0;             // If we alreadu know Faktoriel from 5 we don't need to 
            if (n == 1) return 1;             // calculate it again just check the array and take the 
            memo[n] = n * Faktoriel(n - 1, memo); // the result from there  
            return memo[n];                       // That saves lot's of time and memory 
        }
    }
}
