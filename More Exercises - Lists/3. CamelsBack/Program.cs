namespace _3.CamelsBack
{
    using System;
    using System.Linq;
   public class Program
    {
       public static void Main()
        {
            var buildings = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            int camelBack = int.Parse(Console.ReadLine());
            int rounds = 0;

            while (buildings.Count>camelBack)
            {
                buildings.RemoveAt(buildings.Count - 1);
                buildings.RemoveAt(0);
                rounds++;
            }
            if (rounds==0)
            {
                Console.WriteLine($"already stable: {string.Join(" ", buildings)}");
            }
            else
            {
                Console.WriteLine($"{rounds} rounds");
                Console.WriteLine($"remaining: {string.Join(" ", buildings)}");
            }
        }
    }
}
