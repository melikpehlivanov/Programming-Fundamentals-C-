using System;

namespace Problem_5.Character_Stats
{
    class CharacterStatistics
    {
        public static void Main()
        {
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maximumHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maximumEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Health: " + '|' + new string('|', currentHealth) + new string('.', maximumHealth-currentHealth)+'|');
            Console.WriteLine("Energy: " + '|' + new string('|', currentEnergy) + new string('.', maximumEnergy - currentEnergy) + '|');
        }
    }
}
