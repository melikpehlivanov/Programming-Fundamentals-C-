using System.Collections.Generic;

namespace _1.Distinct_List
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            var result = new List<int>();

            foreach (var distinctedNumbers in numbers.Distinct())
            {
                result.Add(distinctedNumbers);
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
