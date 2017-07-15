using System;
using System.Collections.Generic;

namespace _01.Odd_Occurrences
{
    class Program
    {
        static void Main()
        {
            string[] words = Console.ReadLine().ToLower().Split(' ');
            var dictionary = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                if (!dictionary.ContainsKey(words[i]))
                {
                    dictionary.Add(words[i], 0);
                }
                dictionary[words[i]]++;
            }

            var list=new List<string>();

            foreach (var item in dictionary)
            {
                
                if (item.Value % 2 == 1)
                {
                    list.Add(item.Key);
                    
                }
            }
            Console.WriteLine(string.Join(", ", list));
        }
    }
}
