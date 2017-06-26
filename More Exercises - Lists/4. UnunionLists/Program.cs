namespace _4.UnunionLists
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var primalList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            int number = int.Parse(Console.ReadLine());

            for (int cntIndex = 0; cntIndex < number; cntIndex++)
            {
                var sequences = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToList();

                foreach (var numbers in sequences)
                {
                    if (!primalList.Contains(numbers))
                    {
                        primalList.Add(numbers);
                    }
                    else
                    {
                        primalList.RemoveAll(x => x == numbers);
                    }
                }
            }
            primalList.Sort();
            Console.WriteLine(string.Join(" ", primalList));
        }
    }
}
