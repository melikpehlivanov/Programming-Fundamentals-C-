namespace _01.SplinterTrip
{
    using System;
    public class Program
    {
        public static void Main()
        {
            double tripDistance = double.Parse(Console.ReadLine());
            double tankCapacity = double.Parse(Console.ReadLine());
            double heavyWindMiles = double.Parse(Console.ReadLine());

            double milesInNonHeavyWinds = tripDistance - heavyWindMiles;
            double nonHeavyWindsConsumption = milesInNonHeavyWinds * 25;
            double fuelConsumptionInHeavyWinds = heavyWindMiles * (25 * 1.5);
            double fuelConsumption = nonHeavyWindsConsumption + fuelConsumptionInHeavyWinds;
            double fuelTolerance = fuelConsumption + (fuelConsumption * 5) / 100.0;
            double remainingFuel = tankCapacity - fuelTolerance;

            if (remainingFuel >= 0)
            {
                Console.WriteLine($"Fuel needed: {fuelTolerance:f2}L");
                Console.WriteLine($"Enough with {remainingFuel:f2}L to spare!");
            }
            else
            {
                var neededFuel = Math.Abs(tankCapacity - fuelTolerance);
                Console.WriteLine($"Fuel needed: {fuelTolerance:f2}L");
                Console.WriteLine($"We need {neededFuel:f2}L more fuel.");
            }
        }
    }
}
