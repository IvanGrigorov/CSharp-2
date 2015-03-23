/* Write a program that fills and prints a matrix of size (n, n) as shown below:
   Example for n=4: 
   1	8	9	16
   2	7	10	15
   3	6	11	14
   4	5	12	13 */


using System;


namespace _01.FillTheMatrixVersion2
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
                    if (j % 2 == 0)
                    {
                        matrix[i, j] = i + 1 + (j * n);
                    }
                    else
                    {
                        matrix[i, j] = (n * j) + n - i;
                    }
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
