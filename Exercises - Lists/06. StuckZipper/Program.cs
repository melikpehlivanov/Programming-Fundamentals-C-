namespace _06.StuckZipper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
       public static void Main()
        {
            var firstLine = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            var secondLine = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var bothLinesTogetherConcat = firstLine.Select(el => el).Concat(secondLine);


            var minDigits = Math.Abs(bothLinesTogetherConcat.Min());

            ExtractingBadElements(minDigits, firstLine);
            ExtractingBadElements(minDigits, secondLine);

            var maxLenght = Math.Max(firstLine.Count, secondLine.Count);
            var result = new List<int>();

            for (int i = 0; i < maxLenght; i++)
            {

                if (i <= secondLine.Count - 1)
                {
                    result.Add(secondLine[i]);
                }

                if (i <= firstLine.Count - 1)
                {
                    result.Add(firstLine[i]);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
        public static void ExtractingBadElements(int minDigits, List<int> input)
        {
            for (int i = 0; i < input.Count; i++)
            {
                if (Math.Abs(input[i]).ToString().Length > minDigits.ToString().Length)
                {
                    input.Remove(input[i]);
                    i--;
                }
            }
        }
    }
}
