using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.Camping
{
   public class Program
    {
       public static void Main()
        {
            Dictionary<string, List<string>> campersData = new Dictionary<string, List<string>>();
            Dictionary<string, int> daysData = new Dictionary<string, int>();
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] inputTokens = input.Split(' ');
                string name = inputTokens[0];
                string camperName = inputTokens[1];
                int daysStayed = int.Parse(inputTokens[2]);

                if (!campersData.ContainsKey(name))
                {
                    campersData.Add(name, new List<string>());
                }

                campersData[name].Add(camperName);

              /*else*/  if (!daysData.ContainsKey(name))
                {
                    daysData.Add(name, 0);
                }

                daysData[name] += daysStayed;

                input = Console.ReadLine();
            }

            var orderedCampersData = campersData
                .OrderByDescending(item => item.Value.Count)
                .ThenBy(item => item.Key.Length);

            foreach (var item in orderedCampersData)
            {
                string key = item.Key;
                List<string> campers = item.Value;

                Console.WriteLine($"{key}: {campers.Count}");
                foreach (var camper in campers)
                {
                    Console.WriteLine($"***{camper}");
                }

                Console.WriteLine($"Total stay: {daysData[key]} nights");
            }
        }
    }
}
