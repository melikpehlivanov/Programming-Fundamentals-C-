using System;
using System.Linq;
namespace _02.Largest_3_Numbers
{
    class Program
    {
        static void Main()
        {
            var numsList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            
            Console.WriteLine(string.Join(" ",numsList.OrderByDescending(x => x).Take(3).ToList()));

        }
    }
}
