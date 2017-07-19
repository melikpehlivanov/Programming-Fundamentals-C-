using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.Shopping_Spree
{
    public class Program
    {
        public static void Main()
        {
            Dictionary<string, double> dataBase = new Dictionary<string, double>();
            double peshosBudget = double.Parse(Console.ReadLine());
            var input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split(' ');
                string product = tokens[0];
                double price = double.Parse(tokens[1]);

                if (dataBase.ContainsKey(product))
                {
                    if (dataBase[product]>price)
                    {
                        dataBase[product] = price;
                    }

                }
                else
                {
                    dataBase[product] = price;
                }

                input = Console.ReadLine();
            }
            double totalPrice = dataBase.Sum(x => x.Value);

            if (totalPrice > peshosBudget)
            {
                Console.WriteLine("Need more money... Just buy banichka");
            }
            else
            {
                Dictionary<string, double> peshoHasEnoughMoneyDictionary = dataBase
                    .OrderByDescending(x => x.Value)
                    .ThenBy(x => x.Key.Length)
                    .ToDictionary(x => x.Key, x => x.Value);
                foreach (var data in peshoHasEnoughMoneyDictionary)
                {
                    string key = data.Key;
                    double price = data.Value;

                    Console.WriteLine($"{key} costs {price:f2}");
                }
            }
        }
    }
}
