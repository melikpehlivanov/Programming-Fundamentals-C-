using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace _16.Tricky_Strings
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string delimeter =Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string name = string.Empty;

            for (int i = 0; i < n; i++)
            {
                string words = Console.ReadLine();
                name += words + delimeter;
            }
            string removeLastDelimeter = name.Remove(name.Length - delimeter.Length, delimeter.Length);


                Console.Write($"{removeLastDelimeter}");
            Console.WriteLine();
 
        }
    }
}

