using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Ordered_Banking_System
{
    public class Program
    {
        public static void Main()
        {
            var dataBaseDictionary =
                new Dictionary<string, Dictionary<string, decimal>>();

            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] inputTokens = input
                    .Split(new string[] { " -> " },
                        StringSplitOptions.RemoveEmptyEntries);

                string bank = inputTokens[0];
                string bankAccount = inputTokens[1];
                decimal balance = decimal.Parse(inputTokens[2]);

                if (!dataBaseDictionary.ContainsKey(bank))
                {
                    dataBaseDictionary.Add(bank, new Dictionary<string, decimal>());
                }

                if (!dataBaseDictionary[bank].ContainsKey(bankAccount))
                {
                    dataBaseDictionary[bank].Add(bankAccount, 0);
                }

                dataBaseDictionary[bank][bankAccount] += balance;

                input = Console.ReadLine();
            }

            var orderedData = dataBaseDictionary
                .OrderByDescending(x => x.Value.Sum(bd => bd.Value))
                .ThenByDescending(x => x.Value.Max(bd => bd.Value));

            foreach (var bankData in orderedData)
            {
                string bank = bankData.Key;
                Dictionary<string, decimal> balancesData = bankData.Value;
                var orderedBalancesData = balancesData
                    .OrderByDescending(x => x.Value);

                foreach (var balanceData in orderedBalancesData)
                {
                    string balanceName = balanceData.Key;
                    decimal balance = balanceData.Value;

                    Console.WriteLine($"{balanceName} -> {balance} ({bank})");
                }
            }
        }
    }
}
