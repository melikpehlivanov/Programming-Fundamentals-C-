namespace CountNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
       public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            SortedDictionary<int, int> numbersCount = new SortedDictionary<int, int>();

            foreach (var number in numbers)
            {
                if (!numbersCount.ContainsKey(number))
                {
                    numbersCount.Add(number, 0);
                }

                numbersCount[number]++;
            }

            foreach (var number in numbersCount)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
