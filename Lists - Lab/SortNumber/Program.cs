namespace SortNumber
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var inputNumbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            inputNumbers.Sort();

            Console.WriteLine(string.Join(" <= ", inputNumbers));
        }
    }
}
