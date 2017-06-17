namespace BalisticTraining
{
    using System;
    using System.Linq;
   public class Program
    {
       public static void Main()
        {
            int[] coordinates = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string[] commands = Console.ReadLine().Split(' ').ToArray();
            int[] shooting = new int[2];       

            for (int i = 0; i < commands.Length; i++)
            {
                if (i % 2 == 0 && commands[i] == "up")
                {
                    shooting[1] += int.Parse(commands[i + 1]);
                }
                else if (i % 2 == 0 && commands[i] == "down")
                {
                    shooting[1] -= int.Parse(commands[i + 1]);
                }
                else if (i % 2 == 0 && commands[i] == "left")
                {
                    shooting[0] -= int.Parse(commands[i + 1]);
                }
                else if (i % 2 == 0 && commands[i] == "right")
                {
                    shooting[0] += int.Parse(commands[i + 1]);
                }
            }
            Console.WriteLine($"firing at [{shooting[0]}, {shooting[1]}]");

            if (coordinates[0] == shooting[0] && coordinates[1] == shooting[1])
            {
                Console.WriteLine("got 'em!");
            }
            else
            {
                Console.WriteLine("better luck next time...");
            }
        }
    }
}
