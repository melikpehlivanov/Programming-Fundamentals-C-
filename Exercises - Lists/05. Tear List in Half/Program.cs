namespace Tear_List_in_Half
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var list = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var k = list.Count / 2;
            var firstLeftPart = list
                .Take(k)
                .ToList();
            var firstRightPart = list
                .Skip(k)
                .ToList();

            var result = new List<int>();

            for (int i = 0; i < firstLeftPart.Count; i++)
            {
                result.Add(firstRightPart[i] / 10);
                result.Add(firstLeftPart[i]);
                result.Add(firstRightPart[i] % 10);
            }

            Console.WriteLine(string.Join(" ", result));

        }
    }
}
