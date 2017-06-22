namespace _3.Equal_Sum_After_Extraction
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var firstList = Console.ReadLine()
                .Split(' ')
                .ToList();

            var secondList = Console.ReadLine()
                .Split(' ')
                .ToList();

            foreach (var keyword in firstList)
            {
                secondList.RemoveAll(x => x == keyword);
            }
            var sum = firstList.Sum(x => Convert.ToInt32(x));
            var secondSum= secondList.Sum(x => Convert.ToInt32(x));

            if (sum==secondSum)
            {
                Console.WriteLine($"Yes. Sum: {sum}");
            }
            else
            {
                Console.WriteLine($"No. Diff: {Math.Abs(sum - secondSum)}");
            }
        }
    }
}
