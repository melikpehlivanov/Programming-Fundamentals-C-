namespace Count_of_Given_Element_in_Array
{
   using System;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var listOfIntegers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            int n = int.Parse(Console.ReadLine());

            var integerCount = listOfIntegers.FindAll(x=>x==n);

            Console.WriteLine(integerCount.Count);
            
        }
    }
}
