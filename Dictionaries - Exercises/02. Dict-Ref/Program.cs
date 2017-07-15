using System;
using System.Collections.Generic;

namespace _02.Dict_Ref
{
    public class Program
    {
        public static void Main()
        {
            var dictionary = new Dictionary<string, int>();
            var input = Console.ReadLine()
                .Split(new char[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "end")
            {
                var name = input[0];
                var value = input[1];

                int number;
                if (int.TryParse(value, out number))
                {
                    dictionary[name] = number;
                }
                else
                {
                    if (dictionary.ContainsKey(value))
                    {
                        dictionary[name] = dictionary[value];
                    }
                }

                input = Console.ReadLine()
                    .Split(new char[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries);
            }
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} === {item.Value}");
            }
        }

    }
}
