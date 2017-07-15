using System;

namespace Problem_2.Rectangle_Area
{
    class CalculatingRectangleArea
    {
        public static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            var calculatedRectangleArea = width * height;
            Console.WriteLine($"{calculatedRectangleArea:f2}");
        }
    }
}
