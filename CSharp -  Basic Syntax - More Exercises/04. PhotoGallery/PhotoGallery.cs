using System;

namespace _04.PhotoGallery
{
    public class PhotoGallery
    {
        public static void Main()
        {
            int photoNumber = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            double sizePhoto = double.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());



            Console.WriteLine($"Name: DSC_{photoNumber:D4}.jpg");
            Console.WriteLine($"Date Taken: {day:d2}/{month:D2}/{year} {hours:d2}:{min:D2}");
            if (sizePhoto < 1000)
            {
                Console.WriteLine($"Size: {sizePhoto}B");
            }
            else if (sizePhoto >= 1000 && sizePhoto <= 999999)
            {
                Console.WriteLine($"Size: {sizePhoto / 1000}KB");
            }
            else
            {
                sizePhoto /= 1000000;
                Console.WriteLine($"Size: {sizePhoto}MB");
            }

            if (width > height)
            {
                Console.WriteLine($"Resolution: {width}x{height} (landscape)");
            }
            else if (width == height)
            {
                Console.WriteLine($"Resolution: {width}x{height} (square)");
            }
            else if (width < height)
            {
                Console.WriteLine($"Resolution: {width}x{height} (portrait)");
            }
        }
    }
}
