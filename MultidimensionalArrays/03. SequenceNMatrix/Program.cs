/* We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
   Write a program that finds the longest sequence of equal strings in the matrix.*/



using System;
using System.Collections;
using System.Collections.Generic;



namespace _03.SequenceNMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the range of the matrix. N= ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("M= ");
            int M = int.Parse(Console.ReadLine());
            String[,] matrix = new String[N, M];
            List<String> tmpList = new List<String>();
            List<String> finalList = new List<String>();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.WriteLine("Enter the matrix[{0}, {1}] = ", i, j);
                    matrix[i, j] = Console.ReadLine();
                }
            }
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {            
                        tmpList.Clear();
                        if ((i == 0 && j != M - 1) || (i != 0 && j != M - 1 && i != N - 1) || (i == N - 1 && j != M - 1))
                        {
                            if (matrix[i, j] == matrix[i, j + 1]) // --->  
                            {                                             // Making the check for a sequence only of neccessery (Optimizing the programm)
                                for (int col = j; col < M; col++)
                                {                   
                                    if (matrix[i, j] == matrix[i, col])
                                    {
                                        tmpList.Add(matrix[i, col]);
                                    }
                                }
                                if (tmpList.Capacity > finalList.Capacity)
                                {
                                    finalList.Clear();
                                    finalList.AddRange(tmpList);
                                }
                            }
                        }
                        tmpList.Clear();
                        if ((i == 0 && j != M - 1) || (i != N-1 && j == M - 1) || (i != 0 && j != M - 1 && i != N - 1))
                        {
                            if (matrix[i, j] == matrix[i + 1, j]) // Making the check for a sequence only of neccessery (Optimizing the programm).
                            {
                                for (int row = i; row < N; row++)          // |
                                {                                          // |  
                                    if (matrix[i, j] == matrix[row, j])    // |
                                    {                                      // \/
                                        tmpList.Add(matrix[row, j]);
                                    }
                                }
                                if (tmpList.Capacity > finalList.Capacity)
                                {
                                    finalList.Clear();
                                    finalList.AddRange(tmpList);
                                }
                            }
                        }
                        tmpList.Clear();
                        if ((i == 0 && j != M - 1) || (i != 0 && j != M - 1 && i != N - 1))
                        {
                            if (matrix[i, j] == matrix[i + 1, j + 1])                          // Making the check for a sequence only of neccessery (Optimizing the programm).
                            {                                                                  // \
                                for (int row = i, col = j; row < N && col < M; row++, col++)   //  \
                                {                                                              //   \
                                    if (matrix[i, j] == matrix[row, col])                      //   \/
                                    {
                                        tmpList.Add(matrix[row, col]);
                                    }
                                }
                                if (tmpList.Capacity > finalList.Capacity)
                                {
                                    finalList.Clear();
                                    finalList.AddRange(tmpList);
                                }
                            }
                        }
                        tmpList.Clear();
                        if ((i != 0 && j != M - 1 && i != N - 1) || (i == N - 1 && j != M - 1))
                        {
                            if (matrix[i, j] == matrix[i - 1, j + 1])                          // Making the check for a sequence only of neccessery (Optimizing the programm).
                            {                                                                  //   /\
                                for (int row = i, col = j; row <= 0 && col < M; row--, col++)  //   /
                                {                                                              //  /
                                    if (matrix[i, j] == matrix[row, col])                      // /
                                    {
                                        tmpList.Add(matrix[row, col]);
                                    }
                                }
                                if (tmpList.Capacity > finalList.Capacity)
                                {
                                    finalList.Clear();
                                    finalList.AddRange(tmpList);
                                }
                            }
                        }  
                }
            }
            foreach (String x in finalList)
            {
            Console.Write("{0} ", x);
            }
        }
    }
}
