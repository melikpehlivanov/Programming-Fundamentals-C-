namespace _4.Flip_List_Sides
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main()
        {
            var inputNumbers = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToList();
            var firstNum = inputNumbers[0];
            var lastNum = inputNumbers[inputNumbers.Count - 1];
            ReverseTheList(inputNumbers, firstNum, lastNum);

        }
        public static void ReverseTheList(List<long> inputNumbers, long firstNum, long lastNum)
        {
            var outputNumbers = new List<long>();

            for (int i = 0; i < inputNumbers.Count; i++)
            {
                outputNumbers.Add(inputNumbers[i]);
            }

            outputNumbers.RemoveAt(0);
            outputNumbers.RemoveAt(outputNumbers.Count - 1);
            outputNumbers.Reverse();

            outputNumbers.Insert(0, firstNum);
            outputNumbers.Add(lastNum);

            Console.WriteLine(string.Join(" ", outputNumbers));
        }
    }
}
