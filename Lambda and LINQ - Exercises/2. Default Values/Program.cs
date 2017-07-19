using System;
using System.Collections.Generic;
using System.Linq;
namespace _2.Default_Values
{
    public class Program
    {
       public static void Main()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            var input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split(new string[] {" -> "}, StringSplitOptions.RemoveEmptyEntries);
                var key = tokens[0];
                var value = tokens[1];

                dictionary[key] = value;
                input = Console.ReadLine();

            }
            string defaultValue = Console.ReadLine();

            Dictionary<string, string> unchangedValues = dictionary
                .Where(x => x.Value != "null")
                .OrderByDescending(x => x.Value.Length)
                .ToDictionary(x => x.Key, x => x.Value);

            Dictionary<string, string> changedValues = dictionary
                .Where(x => x.Value == "null")
                .ToDictionary(x => x.Key, x => defaultValue);

            foreach (var unchangedValue in unchangedValues)
            {
                var key = unchangedValue.Key;
                var value = unchangedValue.Value;

                Console.WriteLine($"{key} <-> {value}");
            }
            foreach (var changedValue in changedValues)
            {
                string key = changedValue.Key;
                string value = changedValue.Value;

                Console.WriteLine($"{key} <-> {value}");
            }

        }
    }
}
