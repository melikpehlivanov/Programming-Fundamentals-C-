using System;
using System.Collections.Generic;

namespace _03.Mixed_Phones
{
    public class Program
    {
        public static void Main()
        {
            var sortedDictionary = new SortedDictionary<string, long>();
            var input = Console.ReadLine()
                .Split(new char[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "Over")
            {
                var name = input[0];
                var number = input[1];

                long result;
                if (long.TryParse(name, out result))
                {
                    sortedDictionary[number] = result;
                }
                else
                {
                    if (long.TryParse(number, out result))
                    {
                        sortedDictionary[name] = result;
                    }
                }


                input = Console.ReadLine()
                    .Split(new char[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);
            }
            foreach (var items in sortedDictionary)
            {
                Console.WriteLine($"{items.Key} -> {items.Value}");
            }
        }
    }
}
