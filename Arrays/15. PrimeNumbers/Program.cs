/* Write a program that finds all prime numbers in the range [1...10 000 000]. 
   Use the Sieve of Eratosthenes algorithm.*/



using System;


namespace _15.PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean[] sieve = new Boolean[10000001];
            for (int i = 0; i <= 10000000; i++)
            {
                sieve[i] = true;
            }
            for (int i = 2; i <= Math.Sqrt(10000000); i++)
            {
                if (sieve[i])
                {
                    for (int j = i * i; j <= 10000000; j += i)
                    {
                        sieve[j] = false;
                    }
                }
            }
            for (int i = 0; i <= 10000000; i++)
            {
                if (sieve[i])
                {
                    Console.WriteLine("{0}, ", i);
                }
            }
        }
    }
}
