using System.Collections.ObjectModel;

namespace _01.Remove_Elements_at_Odd_Positions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var initialList = Console.ReadLine()
                .Split(' ')
                .ToList();

            var listWithoutOddPositions = new List<string>();

            for (int i = 0; i < initialList.Count; i++)
            {
                if (i%2!=0)
                {
                    listWithoutOddPositions.Add(initialList[i]);
                }
            }
            Console.WriteLine(string.Join("",listWithoutOddPositions));
        }
    }
}
