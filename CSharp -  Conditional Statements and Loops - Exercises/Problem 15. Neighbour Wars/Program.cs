using System;


namespace Problem_15.Neighbour_Wars
{
   public class Program
    {
       public static void Main()
        {
            int PeshoDamage = int.Parse(Console.ReadLine());
            int GoshoDamage = int.Parse(Console.ReadLine());

            int peshoHealth = 100;
            int goshoHealth = 100;

            int round = 0;

            for (int i = 1; i < 100; i++)
            {
                round++;

                if (i % 2 == 0)
                {
                    peshoHealth -= GoshoDamage;
                    if (peshoHealth <= 0)
                    {

                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealth} health.");
                    }
                }
                if (i % 2 != 0)
                {

                    goshoHealth -= PeshoDamage;
                    if (goshoHealth <= 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth} health.");

                    }
                }

                if (i % 3 == 0)
                {
                    peshoHealth += 10;
                    goshoHealth += 10;
                }
            }
            if (goshoHealth <= 0)
            {
                Console.WriteLine($"Pesho won in {round}th round.");
            }
            else if (peshoHealth <= 0)
            {
                Console.WriteLine($"Gosho won in {round}th round.");
            }
        }
    }
}
