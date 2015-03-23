/* Write a program that reads a text file and inserts line numbers in front of each of its lines.
The result should be written to another text file.*/


using System;
using System.IO;


namespace _03.LineNumbers
{
    class LineNumbers
    {
        static void Main(string[] args)
        {
            String fileName = @"..\..\FreeFile.txt";
            String fileSource1 = @"..\..\Test1.txt";
            StreamWriter writer = new StreamWriter(fileName);
            using (writer)
            {
                StreamReader reader = new StreamReader(fileSource1);
                using (reader)
                {
                    int lineNumber = 1;
                    String line = reader.ReadLine();
                    while (line != null)
                    {
                        writer.Write(lineNumber + " ");
                        writer.WriteLine(line);
                        line = reader.ReadLine();
                        lineNumber++;
                    }
                }
            }
            StreamReader reader3 = new StreamReader(fileName);
            using (reader3)
            {
                String line = reader3.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = reader3.ReadLine();
                }
            }
        }
    }
}
