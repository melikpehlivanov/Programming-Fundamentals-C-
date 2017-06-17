using System;

namespace Problem_2.Passed_or_Failed
{
    public class PassedOrFailed
    {
       public static void Main()
        {
            double num = double.Parse(Console.ReadLine());

            if (num>=3.00)
            {
                Console.WriteLine("Passed!");
            }
            else
            {
                Console.WriteLine("Failed!");
            }
        }
    }
}
