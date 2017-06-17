using System;
using System.Collections.Generic;

namespace _3.Exchange_Variable_Values
{
    public class Program
    {
        public static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            var list = new List<int>();
            list.Add(a);
            list.Add(b);
            list.Reverse();
            foreach (int numbers in list)
            {
                Console.WriteLine(numbers);
            }
        }
    }
}
