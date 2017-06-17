using System.Collections.Generic;

namespace _14.ASCII_String
{
    using System;
    public class Program
    {
       public static void Main()
       {
           int n = int.Parse(Console.ReadLine());
           string result = string.Empty;
           for (int i = 0; i < n; i++)
           {
               int numbers = int.Parse(Console.ReadLine());
               var convertedChars = Convert.ToChar(numbers);
               var final = Convert.ToString(convertedChars);
               result += final;
           }
           Console.WriteLine(result);
        }
    }
}
