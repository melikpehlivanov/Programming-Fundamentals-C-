namespace Array_Elements_Equal_to_Their_Index
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == i)
                {
                    Console.Write($"{numbers[i]} ");
                }
            }
            Console.WriteLine();
        }
    }
}

