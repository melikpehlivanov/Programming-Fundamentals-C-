namespace SquareNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            var squareNumbers = new List<int>();

            foreach (var number in numbers)
            {
                double currentNum = Math.Sqrt(number);

                if (currentNum == (int)currentNum)
                {
                    squareNumbers.Add(number);
                }
            }

            squareNumbers.Sort((a, b) => b.CompareTo(a));

            Console.WriteLine(string.Join(" ", squareNumbers));
        }
    }
}
