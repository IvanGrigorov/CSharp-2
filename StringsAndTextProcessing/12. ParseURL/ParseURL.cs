/* Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.*/



using System;
using System.Text;


namespace _12.ParseURL
{
    class ParseURL
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your URL. ");
            Console.Write("URL = ");
            String userString = Console.ReadLine();
            StringBuilder protocol = new StringBuilder();
            StringBuilder server = new StringBuilder();
            StringBuilder resource = new StringBuilder();
            int indeks = 0;
            while (userString[indeks] != ':')
            {
                protocol.Append(userString[indeks]);
                indeks++;
            }
            indeks = indeks + 3;
            while (userString[indeks] != '/')
            {
                server.Append(userString[indeks]);
                indeks++;
            }
            indeks++;
            while (indeks < userString.Length)
            {
                resource.Append(userString[indeks]);
                indeks++;
            }
            Console.WriteLine("The protocol is: {0} ", protocol.ToString());
            Console.WriteLine("The server is: {0} ", server.ToString());
            Console.WriteLine("The resource is: {0} ", resource.ToString());
        }
    }
}
