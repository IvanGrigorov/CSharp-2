/* Write a program that fills and prints a matrix of size (n, n) as shown below:
   Example for n=4: 
   7	11	14	16
   4	8	12	15
   2	5	9	13
   1	3	6	10 */



using System;


namespace _01.FillTheMatrixVersion3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the matrix (n) for nxn. ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            for (int j = 0; j < n; j++)
            {
                if (j == 0)
                {
                    matrix[n - 1, j] = 1;
                }
                else
                {
                    matrix[n - 1, j] = matrix[n - 1, j - 1] + j + 1;
                }
            }
            for (int i = n-2; i >= 0; i--)
            {
                matrix[i, n - 1] = matrix[i + 1, n - 1] + (i + 1);
            }
            for (int i = n - 2; i >= 0; i--)
            {
                for (int j = n - 2; j >= 0; j--)
                {
                    matrix[i, j] = matrix[i + 1, j + 1] - 1; 
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
