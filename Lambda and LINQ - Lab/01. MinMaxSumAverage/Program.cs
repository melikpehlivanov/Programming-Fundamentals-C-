using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.MinMaxSumAverage
{
    public class Program
    {
        public static void Main()
        { 
            int n =Int32.Parse(Console.ReadLine());
            var list = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int numToAdd = int.Parse(Console.ReadLine());
                list.Add(numToAdd);
            }
            Console.WriteLine($"Sum = {list.Sum()}");
            Console.WriteLine($"Min = {list.Min()}");
            Console.WriteLine($"Max = {list.Max()}");
            Console.WriteLine($"Average = {list.Average()}");
        }
    }
}
