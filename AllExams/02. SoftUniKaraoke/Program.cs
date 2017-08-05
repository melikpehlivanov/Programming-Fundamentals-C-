namespace _02.SoftUniKaraoke
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var participants = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            var availableSongsList = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();

            Dictionary<string, List<string>> dictionary =
                new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "dawn")
            {
                string[] inputTokens = input
                    .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                string name = inputTokens[0];
                string song = inputTokens[1];
                string award = inputTokens[2];

                if (!participants.Any(p => p == name) || !availableSongsList.Any(s => s == song))
                {
                    input = Console.ReadLine();
                    continue;
                }

                if (!dictionary.ContainsKey(name))
                {
                    dictionary.Add(name, new List<string>());

                }
                dictionary[name].Add(award);

                input = Console.ReadLine();


            }
            if (dictionary.Count == 0)
            {
                Console.WriteLine("No áwards");

            }
            foreach (var pair in dictionary
                .OrderByDescending(a => a.Value.Distinct().ToList().Count)
                .ThenBy(n => n.Key))
            {
                List<string> awards = pair.Value.Distinct().ToList();

                Console.WriteLine($"{pair.Key}: {awards.Count} awards");
                foreach (string award in awards.OrderBy(n => n))
                {
                    Console.WriteLine($"--{award}");


                }
            }
        }
    }
}
