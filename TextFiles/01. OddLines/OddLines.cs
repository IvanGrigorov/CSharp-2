/* Write a program that reads a text file and prints on the console its odd lines.*/


using System;
using System.IO;


namespace _01.OddLines
{
    class OddLines
    {
        static void Main(string[] args)
        {
            String fileName = @"..\..\Test1.txt";
            StreamReader reader = new StreamReader(fileName);
            using (reader)
            {
                int lineNumber = 0;
                String line = reader.ReadLine();
                while (line != null)
                {
                    lineNumber++;
                    if (lineNumber % 2 != 0)
                    {
                        Console.WriteLine("Line {0}: {1} ", lineNumber, line);
                    }
                    line = reader.ReadLine();
                }
            }
        }
    }
}
