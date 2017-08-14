namespace _03.Wormhole
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

            int count = 0;
            int transportAt = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] != 0)
                {
                    transportAt = numbers[i];
                    numbers[i] = 0;
                    i = transportAt;

                }
                count++;
            }
        }
    }
}
