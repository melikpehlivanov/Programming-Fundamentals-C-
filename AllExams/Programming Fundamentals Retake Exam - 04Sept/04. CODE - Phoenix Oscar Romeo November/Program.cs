namespace _04.CODE___Phoenix_Oscar_Romeo_November
{
    ﻿using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    public class Program
    {
        public static void Main()
        {
            var dict = new Dictionary<string, HashSet<string>>();
        string[] delimiters = { " -> " };
 
        string input;
        while (!(input = Console.ReadLine()).Equals("Blaze it!"))
        {
            var data = input.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            if (!data[0].Equals(data[1]))
            {
                if (!dict.ContainsKey(data[0]))
                {
                    dict.Add(data[0], new HashSet<string>());
                }
                dict[data[0]].Add(data[1]);
            }
        }
 
        var ordered = dict
            .Select(kvp => new { kvp.Key, c = Count(dict, kvp.Key) })
            .OrderByDescending(o => o.c)
            .Select(o=>$"{o.Key} : {o.c}");
 
        Console.WriteLine(string.Join(Environment.NewLine, ordered));
    }
 
    private static int Count(Dictionary<string, HashSet<string>> dict, string key)
    {
        int count = dict[key].Count;
        foreach (var mate in dict[key])
        {
            if (dict.TryGetValue(mate, out var val) && val.Contains(key))
            {
                count--;
            }
        }
        return count;
        }
    }
}
