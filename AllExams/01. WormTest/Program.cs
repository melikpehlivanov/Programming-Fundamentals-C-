namespace _01.WormTest
{
    using System;
    public class Program
    {
        public static void Main()
        {
            uint lengthInCentimeters = uint.Parse(Console.ReadLine()) * 100;
            decimal widthInCentimeters = decimal.Parse(Console.ReadLine());

            var remainder = lengthInCentimeters % widthInCentimeters;

            if (remainder <= 0)
            {
                var calculated = lengthInCentimeters * widthInCentimeters;
                Console.WriteLine($"{calculated:f2}");
            }
            else if (remainder != 0)
            {
                var result = (lengthInCentimeters / widthInCentimeters) * 100;
                Console.WriteLine($"{result:f2}%");
            }
        }
    }
}
