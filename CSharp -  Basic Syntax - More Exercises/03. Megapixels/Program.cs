using System;

namespace _03.Megapixels
{
    class Program
    {
        static void Main(string[] args)
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            double image = (width * height) / 1000000;
            Console.WriteLine($"{width}x{height} => {Math.Round(image,1)}MP");
        }
    }
}
