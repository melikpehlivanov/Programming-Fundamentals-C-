namespace SplitByWordCasing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var delimitersCharArray = ",;:.!()\"\'\\/[] ".ToCharArray();

            var input = Console.ReadLine()
                .Split(delimitersCharArray, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var lowerCase = new List<string>();
            var mixedCase = new List<string>();
            var upperCase = new List<string>();

            foreach (var word in input)
            {
                if (word.Any(x => !char.IsLetter(x)))
                {
                    mixedCase.Add(word);
                }
                else if (word.ToLower().Equals(word))
                {
                    lowerCase.Add(word);
                }
                else if (word.ToUpper().Equals(word))
                {
                    upperCase.Add(word);
                }
                else
                {
                    mixedCase.Add(word);
                }
            }
            Console.WriteLine($"Lower-case: {string.Join(", ", lowerCase)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCase)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperCase)}");
        }
    }
}
