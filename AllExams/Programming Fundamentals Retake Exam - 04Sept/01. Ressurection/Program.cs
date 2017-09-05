namespace _01.Ressurection
{
    using System;
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                var totalLenght = long.Parse(Console.ReadLine());
                decimal totalWidthOfTheBody = decimal.Parse(Console.ReadLine());
                long lengthOfOneWing = long.Parse(Console.ReadLine());
                var totalYears = (decimal)Math.Pow(totalLenght, 2) * (totalWidthOfTheBody + 2 * lengthOfOneWing);
                Console.WriteLine($"{totalYears}");
            }
        }
    }
}
