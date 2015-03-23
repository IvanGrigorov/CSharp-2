/* Write a program that concatenates two text files into another text file.*/


using System;
using System.IO;


namespace _02.ConcatenateTextFiles
{
    class ConcatenateTextFiles
    {
        static void Main(string[] args)
        {
            String fileName = @"..\..\FreeFile.txt";
            String fileSource1 = @"..\..\Test1.txt";
            String fileSource2 = @"..\..\Test2.txt";
            StreamWriter writer = new StreamWriter(fileName);
            using (writer)
            {
                StreamReader reader = new StreamReader(fileSource1);
                using (reader)
                {
                    String line = reader.ReadLine();
                    while (line != null)
                    {
                        writer.WriteLine(line);
                        line = reader.ReadLine();
                    }
                }
                StreamReader reader2 = new StreamReader(fileSource2);
                using (reader2)
                {
                    String line = reader2.ReadLine();
                    while (line != null)
                    {
                        writer.WriteLine(line);
                        line = reader2.ReadLine();
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
