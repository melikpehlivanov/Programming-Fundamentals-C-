using System;
using System.Linq;
namespace _1.Array_Data
{
    public class Program
    {
        public static void Main()
        {
            int[] numbersArray = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            string command = Console.ReadLine();
            double average = numbersArray.Average();
            numbersArray = numbersArray.Where(x => x >= average).ToArray();

            string output;
            if (command == "Min")
            {
                output = numbersArray.Min(x => x).ToString();
            }
            else if (command == "Max")
            {
                output = numbersArray.Max(x => x).ToString();
            }
            else
            {
                output = String.Join(" ", numbersArray.OrderBy(x => x));
            }
            Console.WriteLine(output);

        }
    }
}
