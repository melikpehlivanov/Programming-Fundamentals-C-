using System;

namespace Problem_5.Foreign_Languages
{
   public class Program
    {
       public static void Main()
        {
            string countryName = Console.ReadLine();

            if (countryName == "USA")
            {
                Console.WriteLine("English");
            }
            else if (countryName=="England")
            {
                Console.WriteLine("English");
            }
            else if (countryName=="Spain")
            {
                Console.WriteLine("Spanish");
            }
            else if (countryName=="Argentina")
            {
                Console.WriteLine("Spanish");
            }
            else if (countryName=="Mexico")
            {
                Console.WriteLine("Spanish");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
