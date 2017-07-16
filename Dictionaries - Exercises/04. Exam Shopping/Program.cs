using System;
using System.Collections.Generic;

namespace _04.Exam_Shopping
{
   public class Program
    {
       public static void Main()
        {
            var dictionary=new Dictionary<string, int>();
            var input = Console.ReadLine()
                .Split(' ');

            while (input[0]!="shopping")
            {
                var name = input[1];
                var quantity = input[2];
                var parsedQuantity = int.Parse(quantity);

                if (!dictionary.ContainsKey(name))
                {
                    dictionary[name] = 0;
                }
                dictionary[name]+=parsedQuantity;
             
                input = Console.ReadLine()
                    .Split(' ');
            }
            input = Console.ReadLine()
                .Split(' ');
            while (input[0]!="exam")
            {
                var name = input[1];
                var quantity = input[2];
                var parsedQuantity = int.Parse(quantity);
                if (!dictionary.ContainsKey(name))
                {
                    Console.WriteLine($"{name} doesn't exist");
                }

                else
                {
                    if (dictionary[name]==0)
                    {
                        Console.WriteLine($"{name} out of stock");
                    }
                    else
                    {
                        dictionary[name] -= parsedQuantity;
                        if (dictionary[name] < 0)
                        {
                            dictionary[name] = 0;
                        }
                        
                    }
                }
                input = Console.ReadLine()
                    .Split(' ');
            }
            foreach (var items in dictionary)
            {
                if (items.Value>0)
                {
                    Console.WriteLine($"{ items.Key} -> { items.Value}");
                }
            }
        }
    }
}
