namespace Phonebook
{
    using System;
    using System.Linq;
        public class Program
    {
        public static void Main()
        {
            string[] numbers = Console.ReadLine().Split(' ').ToArray();
            string[] names = Console.ReadLine().Split(' ').ToArray();
            string input = Console.ReadLine();

            while (input != "done")
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (input == names[i])
                    {
                        Console.WriteLine($"{names[i]} -> {numbers[i]}");
                    }
                }
                input = Console.ReadLine();
            }
        }
    }
}
