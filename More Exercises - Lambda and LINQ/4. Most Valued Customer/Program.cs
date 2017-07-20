using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.Most_Valued_Customer
{
    public class Program
    {
        public static void Main()
        {
            var productsData =
                new Dictionary<string, double>();

            var customerData =
                new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "Shop is open")
            {
                string[] inputTokens = input.Split(' ');
                string product = inputTokens[0];
                double price = double.Parse(inputTokens[1]);

                productsData[product] = price;

                input = Console.ReadLine();
            }
            input = Console.ReadLine();

            while (input != "Print")
            {
                string[] inputTokens = input
                    .Split(new string[] { ": ", ", " },
                        StringSplitOptions.RemoveEmptyEntries);

                if (inputTokens[0] == "Discount")
                {
                    var discountedProducts = productsData
                        .OrderByDescending(x => x.Value)
                        .Take(3)
                        .Select(x =>
                            new KeyValuePair<string, double>(x.Key, x.Value * 0.9));

                    foreach (var discountedProduct in discountedProducts)
                    {
                        productsData[discountedProduct.Key] = discountedProduct.Value;
                    }
                }
                else
                {
                    string customer = inputTokens[0];
                    if (!customerData.ContainsKey(customer))
                    {
                        customerData.Add(customer, new List<string>());
                    }

                    for (int index = 1; index < inputTokens.Length; index++)
                    {
                        string boughtProduct = inputTokens[index];
                        if (productsData.ContainsKey(boughtProduct))
                        {
                            customerData[customer].Add(boughtProduct);
                        }
                    }
                }

                input = Console.ReadLine();
            }

            var topCustomer = customerData
                .OrderByDescending(x => x.Value.Sum(product => productsData[product]))
                .First();

            string name = topCustomer.Key;
            var productsBought = topCustomer.Value;
            Console.WriteLine($"Biggest spender: {name}");
            Console.WriteLine("^Products bought:");

            double total = productsBought.Sum(pb => productsData[pb]);
            var orderedProducts = productsBought.Distinct().OrderByDescending(pd => productsData[pd]);
            foreach (var product in orderedProducts)
            {
                Console.WriteLine($"^^^{product}: {productsData[product]:f2}");
            }

            Console.WriteLine($"Total: {total:f2}");
        }
    }
}
