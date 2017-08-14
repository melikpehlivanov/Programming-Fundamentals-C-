namespace _04.NSA
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var spyList = new Dictionary<string, Dictionary<string, long>>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "quit")
                {
                    break;
                }

                var tokens = input
                    .Split(new[] {' ', '-', '>'}, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                if (tokens.Count < 3)
                {
                    continue;
                }

                var countryName = tokens[0];
                var spyName = tokens[1];
                var spyScore = long.Parse(tokens[tokens.Count - 1]);

                if (!spyList.ContainsKey(countryName))
                {
                    spyList[countryName] = new Dictionary<string, long>();
                }

                if (!spyList[countryName].ContainsKey(countryName))
                {
                    spyList[countryName][spyName] = 0;
                }

                spyList[countryName][spyName] = spyScore;
            }

            foreach (var country in spyList.OrderByDescending(c => c.Value.Keys.Count()))
            {
                Console.WriteLine($"Country: {country.Key}");

                foreach (var spy in country.Value.OrderByDescending(s => s.Value))
                {
                    Console.WriteLine($"**{spy.Key} : {spy.Value}");
                }
            }
        }
    }
}
