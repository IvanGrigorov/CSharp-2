/* Write a program that encodes and decodes a string using given encryption key (cipher).
   The key consists of a sequence of characters.
   The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, the second – with the second, etc. 
   When the last key character is reached, the next is the first.*/



using System;
using System.Text;


namespace _07.EncodeDecode
{
    class EncodeDecode
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your string. ");
            Console.Write("String = ");
            String userString = Console.ReadLine();
            Console.WriteLine("Enter your encryption key. ");
            Console.Write("chiper = ");
            String chiper = Console.ReadLine();
            StringBuilder encodedText = new StringBuilder();

            for (int i = 0; i < userString.Length; i++)
            {
                encodedText.Append((char)(userString[i] ^ chiper[i % chiper.Length]));
            }
            Console.WriteLine("The encoded text is {0}. ", encodedText.ToString());

            StringBuilder decodedText = new StringBuilder();

            for (int i = 0; i < userString.Length; i++)
            {
                decodedText.Append((char)(encodedText[i] ^ chiper[i % chiper.Length]));
            }
            Console.WriteLine("The encoded text is {0}. ", decodedText.ToString());
        }
    }
}
