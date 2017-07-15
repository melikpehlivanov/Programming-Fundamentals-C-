using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.Count_Real_Numbers
{
    class Program
    {
        static void Main()
        {
            var list = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            var sortedDictionary=new SortedDictionary<double, int>();

            for (int i = 0; i < list.Count; i++)
            {
                if (!sortedDictionary.ContainsKey(list[i]))
                {
                    sortedDictionary.Add(list[i], 0);
                }
                sortedDictionary[list[i]]++;
            }

            foreach (var item in sortedDictionary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
