using System;
using System.Collections.Generic;

namespace _01.Letter_Repetition
{
   public class LetterRepetition
    {
       public static void Main()
        {
            var dictionary=new Dictionary<char, int>();
            var input = Console.ReadLine().ToCharArray();

            for (int i = 0; i < input.Length; i++)
            {
                if (!dictionary.ContainsKey(input[i]))
                {
                    dictionary.Add(input[i],0);
                }
                dictionary[input[i]]++;
            }
            foreach (var element in dictionary)
            {
                Console.WriteLine($"{element.Key} -> {element.Value}");
            }
        }
    }
}
