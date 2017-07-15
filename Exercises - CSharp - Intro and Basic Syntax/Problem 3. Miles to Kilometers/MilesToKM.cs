using System;

namespace Problem_3.Miles_to_Kilometers
{
    class MilesToKM
    {
        public static void Main()
        {
            double miles = double.Parse(Console.ReadLine());
            var kilometers = miles * 1.60934;
            Console.WriteLine($"{kilometers:f2}");
        }
    }
}
