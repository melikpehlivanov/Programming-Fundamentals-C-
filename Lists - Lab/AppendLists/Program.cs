namespace AppendLists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
      public static void Main()
        {
            char[] delimeterCharArray = " ".ToCharArray();

            var input = Console.ReadLine()
                .Split('|')
                .Reverse()
                .ToList();

            var reversedList = new List<string>();

            for (int i = 0; i < input.Count; i++)
            {
                var anotherList = input[i]
                    .Split(delimeterCharArray, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                reversedList.AddRange(anotherList);
            }

            Console.WriteLine(string.Join(" ", reversedList));
        }
    }
}
