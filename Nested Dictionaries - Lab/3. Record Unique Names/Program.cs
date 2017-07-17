using System;
using System.Collections.Generic;

namespace _3.Record_Unique_Names
{
   public class Program
    {
       public static void Main()
        {
            var sets= new HashSet<string>();
            var inputNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputNumber; i++)
            {
                var newInput = Console.ReadLine();
                sets.Add(newInput);
            }

            foreach (var set in sets)
            {
                Console.WriteLine(set);
            }
        }
    }
}
