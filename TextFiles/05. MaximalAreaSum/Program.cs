/* Write a program that reads a text file containing a square matrix of numbers.
   Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
   The first line in the input file contains the size of matrix N.
   Each of the next N lines contain N numbers separated by space.
   The output should be a single number in a separate text file.*/


using System;
using System.IO;
using System.Text;


namespace _05.MaximalAreaSum
{
    class Program
    {
        static void Main(string[] args)
        {
            String fileName = @"..\..\Matrix.txt";
            String fileResult = @"..\..\FreeFile.txt";
            StreamReader reader = new StreamReader(fileName);
            int sum = int.MinValue;
            using (reader)
            {
                String line = reader.ReadLine();
                int size = int.Parse(line);
                int[,] matrix = new int[size, size];
                int indeks = 0;
                StringBuilder numbersFromMatrix = new StringBuilder();
                for (int i = 0; i < size; i++)
                {
                    numbersFromMatrix.Append(reader.ReadLine());
                }
                for (int row = 0; row < size; row++)
                {
                    for (int col = 0; col < size; col++)
                    {
                        matrix[row, col] = (int)Char.GetNumericValue(numbersFromMatrix[indeks]);
                        indeks++;
                    }
                }
                for (int i = 0; i < size - 1; i++)
                {
                    for (int j = 0; j < size - 1; j++)
                    {
                        int tmp = 0;
                        tmp = matrix[i, j] + matrix[i + 1, j]
                            + matrix[i, j + 1] + matrix[i + 1, j + 1];
                        if (tmp > sum)
                        {
                            sum = tmp;
                        }
                    }
                }
            }
            StreamWriter writer = new StreamWriter(fileResult);
            using (writer)
            {
                writer.WriteLine("The maximum sum is {0} .", sum);
            }
            StreamReader reader2 = new StreamReader(fileResult);
            using (reader2)
            {
                string line = reader2.ReadLine();
                Console.WriteLine(line);
            }
        }
    }
}
