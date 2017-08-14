namespace _03.FootballLeague
{
    using System;
    using System.Text.RegularExpressions;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            Dictionary<string, long> scores = new Dictionary<string, long>();
            Dictionary<string, long> goals = new Dictionary<string, long>();
            string key = Console.ReadLine();
            key = Regex.Escape(key);
            var regex = new Regex($@"{key}(.*?){key}.*?{key}(.*?){key}.+?(\d+):(\d+)");
            string input = Console.ReadLine();
            while (input != "final")
            {
                var match = regex.Match(input);

                var firstTeam = new string(match.Groups[1].Value.ToUpper().Reverse().ToArray());
                var secondTeam = new string(match.Groups[2].Value.ToUpper().Reverse().ToArray());
                var firstTeamGoals = long.Parse(match.Groups[3].Value);
                var secondTeamGoals = long.Parse(match.Groups[4].Value);

                if (!scores.ContainsKey(firstTeam))
                {
                    scores[firstTeam] = 0;
                }
                if (!scores.ContainsKey(secondTeam))
                {
                    scores[secondTeam] = 0;
                }
                if (!goals.ContainsKey(firstTeam))
                {
                    goals[firstTeam] = 0;
                }
                if (!goals.ContainsKey(secondTeam))
                {
                    goals[secondTeam] = 0;
                }
                goals[firstTeam] += firstTeamGoals;
                goals[secondTeam] += secondTeamGoals;

                if (firstTeamGoals>secondTeamGoals)
                {
                    scores[firstTeam] += 3;
                }
                else if (firstTeamGoals<secondTeamGoals)
                {
                    scores[secondTeam] += 3;
                }
                else
                {
                    scores[firstTeam]++;
                    scores[secondTeam]++;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine("League standings:");
            int place = 1;
            foreach (var kvp in scores
                .OrderByDescending(kvp=> kvp.Value)
                .ThenBy(kvp=> kvp.Key))
            {
                Console.WriteLine($"{place}. {kvp.Key} {kvp.Value}");
                place++;
            }
            Console.WriteLine($"Top 3 scored goals:");
            foreach (var kvp in goals
                .OrderByDescending(kvp=> kvp.Value)
                .ThenBy(kvp=> kvp.Key)
                .Take(3))
            {
                Console.WriteLine($"- {kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
