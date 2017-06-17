using System;

namespace Problem_3.Back_in_30_Minutes
{
   public class Program
    {
      public static void Main()
        {
            TimeSpan hour = TimeSpan.FromHours(int.Parse(Console.ReadLine()));
            TimeSpan minute = TimeSpan.FromMinutes(int.Parse(Console.ReadLine()));

            TimeSpan totalTime = hour + minute;
            totalTime = totalTime.Add(TimeSpan.FromMinutes(30));
            Console.WriteLine($"{totalTime.Hours}:{totalTime.Minutes:D2}");
        }
    }
}
