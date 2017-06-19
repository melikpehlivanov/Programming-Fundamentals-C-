namespace Remove_Negatives_and_Reverse
{
    using System;
    using System.Linq;
    public class ReversedNegatives
    {
        public static void Main()
        {
            var listOfIntegers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            listOfIntegers.RemoveAll(x => x < 0);

            if (listOfIntegers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                listOfIntegers.Reverse();
                Console.WriteLine(string.Join(" ", listOfIntegers));
            }
        }
    }
}
