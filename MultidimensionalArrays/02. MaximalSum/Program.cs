/* Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.*/


using System;


namespace _02.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the range of the matrix (N and M must be at least equal to 3). N= ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("M= ");
            int M = int.Parse(Console.ReadLine());
            int [,] matrix = new int[N,M];
            int sum = 0;
            int bestSum = int.MinValue;
            int rowStart = -1;
            int colStart = -1;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.WriteLine("Enter the matrix[{0}, {1}] = ", i, j);
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i <= N - 3; i++)
            {
                for (int j = 0; j <= M - 3; j++)
                {
                    sum = 0;
                    for (int k = i; k < i + 3; k++)
                    {
                        for (int l = j; l < j + 3; l++)
                        {
                            sum += matrix[k, l];
                        }
                    }
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        rowStart = i;
                        colStart = j;
                    }
                }
            }
            Console.WriteLine();
            for (int i = rowStart; i < rowStart + 3; i++)
            {
                for (int j = colStart; j < colStart + 3; j++)
                {
                    Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("The best sum is: {0} ", bestSum);
        }
    }
}
