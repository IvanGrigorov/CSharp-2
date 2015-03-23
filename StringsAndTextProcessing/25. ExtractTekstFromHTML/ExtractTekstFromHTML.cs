/* Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.*/


using System;
using System.Text;


namespace _25.ExtractTekstFromHTML
{
    class ExtractTekstFromHTML
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your string. ");
            Console.Write("String = ");
            String userString = Console.ReadLine();
            String[] HTMLParts = userString.Split(new[] { "<html><head><title>", "</title></head><body>", "</body></html>" }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder body = new StringBuilder();
            if (HTMLParts.Length > 0)
            {
                Console.WriteLine("Title: {0}", HTMLParts[0]);
                for (int i = 0; i < HTMLParts[1].Length; i++)
                {
                    if (HTMLParts[1][i] == '<')
                    {
                        while (HTMLParts[1][i] != '>')
                        {
                            i++;
                        }
                    }
                    else
                    {
                        body.Append(HTMLParts[1][i]);
                    }
                }
                Console.WriteLine("Body: {0}", body.ToString());
            }
            else
            {
                for (int i = 0; i < HTMLParts[0].Length; i++)
                {
                    if (HTMLParts[0][i] == '<')
                    {
                        while (HTMLParts[0][i] != '>')
                        {
                            i++;
                        }
                    }
                    else
                    {
                        body.Append(HTMLParts[0][i]);
                    }
                }
                Console.WriteLine("Body: {0}", body.ToString());
            }
        }
    }
}
