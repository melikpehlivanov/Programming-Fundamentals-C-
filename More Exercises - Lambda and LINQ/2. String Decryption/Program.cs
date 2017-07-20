using System;
using System.Linq;

namespace _2.String_Decryption
{
    public class Program
    {
        public static void Main()
        {
            int[] numbersWhichMustBeSkippedAndTaken = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int mustBeSkipped = numbersWhichMustBeSkippedAndTaken[0];
            int mustBeTaken = numbersWhichMustBeSkippedAndTaken[1];

            int[] arrayOfIntegers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            arrayOfIntegers = arrayOfIntegers
                .Where(x => x >= 65 && x <= 95)
                .Skip(mustBeSkipped)
                .Take(mustBeTaken).ToArray();

            foreach (var arrayOfInteger in arrayOfIntegers)
            {
                Console.Write((char)arrayOfInteger);
            }
            Console.WriteLine();

        }
    }
}
