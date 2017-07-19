﻿using System;
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

            double logPrice = Math.Round(data.Average(kvp => kvp.Value), 2);

            double usedLogsPrice = data
                .Where(kvp => kvp.Key == wantedTypeOfTree && kvp.Value >= minimumMetersOfHeight)
                .Sum(kvp => kvp.Value);

            double unusedLogsPrice = data
                .Where(kvp => kvp.Key != wantedTypeOfTree || kvp.Value < minimumMetersOfHeight)
                .Sum(kvp => kvp.Value);

            usedLogsPrice *= logPrice;
            unusedLogsPrice *= logPrice * 0.25;

            usedLogsPrice = Math.Round(usedLogsPrice, 2);
            unusedLogsPrice = Math.Round(unusedLogsPrice, 2);
            double totalPrice = Math.Round(usedLogsPrice + unusedLogsPrice, 2);

            Console.WriteLine("Price per meter: ${0:F2}", logPrice);
            Console.WriteLine("Used logs price: ${0:F2}", usedLogsPrice);
            Console.WriteLine("Unused logs price: ${0:F2}", unusedLogsPrice);
            Console.WriteLine("CottageScraper subtotal: ${0:F2}", totalPrice);
        }
    }
}
