/* Write a program that sorts an array of integers using the Quick sort algorithm.*/



using System;
using System.Collections.Generic;
using System.Linq;

namespace _14.QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the list. ");
            int length = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Enter an element (integer) of the list. ");
                int number = int.Parse(Console.ReadLine());
                list.Add(number);
            }
            Console.WriteLine();
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("{0}, ",(QuickSort(list))[i]);
            }
               
        }


        public static List<int> QuickSort(List<int> array)
        {
            int lenght = array.Capacity;
            if (array.Capacity <= 1)
            {
                return array;
            }
                int pivot = array[lenght - 1];
                array.RemoveAt(lenght-1);
                List<int> less = new List<int>();
                List<int> greater = new List<int>();
                for (int i = 0; i < lenght - 1; i++)
                {
                    if (array[i] <= pivot)
                    {
                        less.Add(array[i]);

                    }
                    else greater.Add(array[i]);
                }
                
            List<int> newList = new List<int>();
            (QuickSort(less)).ForEach(p => newList.Add(p));
            newList.Add(pivot);
            (QuickSort(greater)).ForEach(p => newList.Add(p));
            return newList;
        }
    }
}
