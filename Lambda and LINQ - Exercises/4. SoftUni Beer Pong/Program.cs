using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.SoftUni_Beer_Pong
{
    public class Program
    {
       public static void Main()
        {
            Dictionary<string, Dictionary<string, int>> dataBase= new Dictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();

            while (input!="stop the game")
            {
                string[] inputTokens = input
                    .Split('|');
                string player = inputTokens[0];
                string team = inputTokens[1];
                int points = int.Parse(inputTokens[2]);

                if (!dataBase.ContainsKey(team))
                {
                    dataBase.Add(team, new Dictionary<string, int>());
                }
                if (dataBase[team].Count<3)
                {
                    dataBase[team].Add(player, points);
                }
                input = Console.ReadLine();
            }
            var orderedData = dataBase
                .Where(x => x.Value.Count == 3)
                .OrderByDescending(x => x.Value.Sum(r => r.Value))
                .ToDictionary(x => x.Key, x => x.Value);

            int pointsForEachPerson = 1;

            foreach (var data in orderedData)
            {
                string key = data.Key;
                Dictionary<string, int> value = data.Value;
                var orderedPlayers = value
                    .OrderByDescending(x => x.Value);

                Console.WriteLine($"{pointsForEachPerson}. {key}; Players:");
                foreach (var orderedPlayer in orderedPlayers)
                {
                    string keyData = orderedPlayer.Key;
                    int valueData = orderedPlayer.Value;

                    Console.WriteLine("###{0}: {1}", keyData, valueData);
                }
                pointsForEachPerson++;
            }
        }
    }
}
