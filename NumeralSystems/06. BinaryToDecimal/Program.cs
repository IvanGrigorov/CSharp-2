/* Write a program to convert binary numbers to hexadecimal numbers (directly).*/



using System;
using System.Collections.Generic;



namespace _06.BinaryToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number. ");
            Console.Write("N = ");
            String N = Console.ReadLine();
            Console.WriteLine(String.Join("", BinaryToDecimal(N)));
        }
        static List<char> BinaryToDecimal(String number)
        {
            List<char> binaryNumber = new List<char>();
            for (int i = 0; i < number.Length; i++)
            {
                binaryNumber.Add(number[i]);
            }
            List<char> result = new List<char>();
            int offset = number.Length % 4;
            if (offset > 0)
            {
                for (int i = 0; i < offset; i++)
                {
                    binaryNumber.Insert(0, '0');
                }
            }
            number = String.Join("", binaryNumber.ToArray());
            for (int i = 0; i < number.Length; i = i + 4)
            {
                string hexNumber = number.Substring(i, 4);
                switch (hexNumber)
                {
                    case "0000":
                        result.Add('0');
                        break;
                    case "0001":
                        result.Add('1');
                        break;
                    case "0010":
                        result.Add('2');
                        break;
                    case "0011":
                        result.Add('3');
                        break;
                    case "0100":
                        result.Add('4');
                        break;
                    case "0101":
                        result.Add('5');
                        break;
                    case "0110":
                        result.Add('6');
                        break;
                    case "0111":
                        result.Add('7');
                        break;
                    case "1000":
                        result.Add('8');
                        break;
                    case "1001":
                        result.Add('9');
                        break;
                    case "1010":
                        result.Add('A');
                        break;
                    case "1011":
                        result.Add('B');
                        break;
                    case "1100":
                        result.Add('C');
                        break;
                    case "1101":
                        result.Add('D');
                        break;
                    case "1110":
                        result.Add('E');
                        break;
                    case "1111":
                        result.Add('F');
                        break;
                }
            }
            return result;
        }
    }
}
