using System;

namespace _01.Passed
{
    public class Passed
    {
       public static void Main()
        {
            double num = double.Parse(Console.ReadLine());

            if (num>=3.00)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}
