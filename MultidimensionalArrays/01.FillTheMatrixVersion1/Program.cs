/* Write a program that fills and prints a matrix of size (n, n) as shown below:
   Example for n=4: 
   1	5	9	13
   2	6	10	14
   3	7	11	15
   4	8	12	16 */

using System;

namespace _01.FillTheMatrixVersion1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the matrix (n) for nxn. ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = i + 1 + (j * n); 
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
