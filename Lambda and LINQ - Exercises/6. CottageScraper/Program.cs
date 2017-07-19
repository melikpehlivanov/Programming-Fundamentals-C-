using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.CottageScraper
{
    public class Program
    {
        public static void Main()
        {
            var data = new List<KeyValuePair<string, int>>();
            string input = Console.ReadLine();

            while (input != "chop chop")
            {
                string[] inputTokens = input
                    .Split(new string[] { " -> " },
                        StringSplitOptions.RemoveEmptyEntries);
                string type = inputTokens[0];
                int height = int.Parse(inputTokens[1]);

                data.Add(new KeyValuePair<string, int>(type, height));

                input = Console.ReadLine();
            }
            string wantedTypeOfTree = Console.ReadLine();
            int minimumMetersOfHeight = int.Parse(Console.ReadLine());

            double AveragePrice = Math.Round(data.Average(k => k.Value), 2);

            double usedDataPrice = data
                .Where(x => x.Key == wantedTypeOfTree && x.Value >= minimumMetersOfHeight)
                .Sum(x => x.Value);

            double unusedDataPrice = data
                .Where(x => x.Key != wantedTypeOfTree || x.Value < minimumMetersOfHeight)
                .Sum(x => x.Value);

            usedDataPrice *= AveragePrice;
            unusedDataPrice *= AveragePrice * 0.25;

            usedDataPrice = Math.Round(usedLogsPrice, 2);
            unusedDataPrice = Math.Round(unusedLogsPrice, 2);
            double totalPrice = Math.Round(usedDataPrice + unusedDataPrice, 2);

            Console.WriteLine("Price per meter: ${0:F2}", AveragePrice);
            Console.WriteLine("Used logs price: ${0:F2}", usedDataPrice);
            Console.WriteLine("Unused logs price: ${0:F2}", unusedDataPrice);
            Console.WriteLine("CottageScraper subtotal: ${0:F2}", totalPrice);
        }
    }
}
