namespace Count_Occurrences_of_Larger_Numbers_in_Array
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var list=Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();

            double p = double.Parse(Console.ReadLine());

            var elementsBiggerThanP = list.FindAll(x => x > p).Count;

            Console.WriteLine(elementsBiggerThanP);
        }
    }
}
