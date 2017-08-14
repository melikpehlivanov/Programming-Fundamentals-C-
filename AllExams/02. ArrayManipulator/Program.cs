namespace _02.ArrayManipulator
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split();
                switch (tokens[0])
                {
                    case "exchange":
                        numbers = Exchange(numbers, int.Parse(tokens[1])); //създава се нова колекция (присвояваме я)
                        break;
                    case "max":
                    case "min":
                        MaxAndMin(numbers, tokens[0], tokens[1]);
                        break;
                    case "first":
                    case "last":
                        FirstAndLast(numbers, tokens[0], int.Parse(tokens[1]), tokens[2]);
                        break;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }

        private static void FirstAndLast(int[] numbers, string command, int count, string evenOrOdd)
        {
            if (count>numbers.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            var filter = FilterEvenOrOdd(numbers, evenOrOdd);

            int[] result;
            if (command=="first")
            {
                result = filter.Take(count).ToArray();
            }
            else
            {
                result = filter.Reverse().Take(count).Reverse().ToArray();
            }
            Console.WriteLine($"[{string.Join(", ", result)}]");

        }

        private static void MaxAndMin(int[] numbers, string comand, string evenOrOdd)
        {
            // ? true
            // : false
            var filter =FilterEvenOrOdd(numbers, evenOrOdd);
            if (!filter.Any())
            {
                Console.WriteLine("No matches");
                return;
            }
            var result = comand == "max" ? filter.Max() : filter.Min();
            Console.WriteLine(Array.LastIndexOf(numbers, result));
        }

        private static int[] Exchange(int[] numbers, int index)
        {
            if (index < 0 || index >= numbers.Length) // проверяваме дали индекса е валиден
            {
                Console.WriteLine("Invalid index");
                return numbers;
            }
            var leftPart = numbers.Take(index + 1);
            var rightPart = numbers.Skip(index + 1);
            return rightPart.Concat(leftPart).ToArray();
        }

        private static int[] FilterEvenOrOdd(int[] numbers, string evenOrOdd)
        {
            return  numbers
                .Where(n => evenOrOdd == "even"
                    ? n % 2 == 0
                    : n % 2 == 1)
                    .ToArray();
        }
    }
}
