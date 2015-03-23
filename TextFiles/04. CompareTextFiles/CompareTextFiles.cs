/* Write a program that compares two text files line by line and prints the number of lines
   that are the same and the number of lines that are different.
   Assume the files have equal number of lines.*/


using System;
using System.IO;

namespace _04.CompareTextFiles
{
    class CompareTextFiles
    {
        static void Main(string[] args)
        {
            String fileSource1 = @"..\..\Test1.txt";
            String fileSource2 = @"..\..\Test2.txt";
            StreamReader reader = new StreamReader(fileSource1);
            StreamReader reader2 = new StreamReader(fileSource2);
            int equalLinesCounter = 0;
            int differentLinesCounter = 0;
            using (reader)
            {
                using (reader2)
                {
                    string line = reader.ReadLine();
                    string line2 = reader2.ReadLine();
                    while (line != null)
                    {
                        if (line.CompareTo(line2) == 0)
                        {
                            equalLinesCounter++;
                        }
                        else
                        {
                            differentLinesCounter++;
                        }
                        line = reader.ReadLine();
                        line2 = reader2.ReadLine();
                    }
                }
            }
            Console.WriteLine("The equal lines between the files are {0}", equalLinesCounter);
            Console.WriteLine("The different lines between the files are {0}", differentLinesCounter);
        }
    }
}
