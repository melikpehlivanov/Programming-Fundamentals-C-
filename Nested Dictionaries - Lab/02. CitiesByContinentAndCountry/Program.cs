using System;
using System.Collections.Generic;

namespace _02.CitiesByContinentAndCountry
{
    public class Program
    {
       public static void Main()
        {
            var Dictionary=new Dictionary<string, Dictionary<string, List<string>>>();
            var inputNumber = int.Parse(Console.ReadLine());

            for (int countIndex = 0; countIndex < inputNumber; countIndex++)
            {
                string[] inputTokens = Console.ReadLine().Split(' ');
                var continent = inputTokens[0];
                var country = inputTokens[1];
                var cities = inputTokens[2];

                if (!Dictionary.ContainsKey(continent))
                {
                    Dictionary.Add(
                        continent, 
                        new Dictionary<string, List<string>>());
                }

                if (!Dictionary[continent].ContainsKey(country))
                {
                    Dictionary[continent].Add(country, new List<string>());
                }
                Dictionary[continent][country].Add(cities);

            }

            foreach (var items in Dictionary)
            {
                var continent = items.Key;
                var countries = items.Value;
                Console.WriteLine($"{continent}:");

                foreach (var countryItems in countries)
                {
                    var country = countryItems.Key;
                    var cities = countryItems.Value;
                    Console.WriteLine($"{country} -> {string.Join(", ", cities)}");
                }
            }
        }
    }
}
