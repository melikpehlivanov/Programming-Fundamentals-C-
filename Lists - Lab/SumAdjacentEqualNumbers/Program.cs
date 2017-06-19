namespace SumAdjacentEqualNumbers
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            char[] delimeterCharArray = " ".ToCharArray();

            var listOfNumbers = Console.ReadLine()
                .Split(delimeterCharArray, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            for (int i = 0; i < listOfNumbers.Count - 1; i++)
            {
                double firstNum = listOfNumbers[i];
                double secondNum = listOfNumbers[i + 1];

                if (firstNum == secondNum)
                {
                    listOfNumbers[i] = listOfNumbers[i] * 2;
                    listOfNumbers.RemoveAt(i + 1);
                    i -= 2;

                    if (i < -1)
                    {
                        i = -1;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", listOfNumbers));
        }
    }
}
