namespace _01.CharityMarathon
{
    using System;
    public class Program
    {
        public static void Main()
        {
            decimal lenghtOfTheMarathonInDays = decimal.Parse(Console.ReadLine());
            decimal numberOfRunners = decimal.Parse(Console.ReadLine());
            decimal averageNumberOfLapsEveryRunnerMakes = int.Parse(Console.ReadLine());
            decimal trackLenght = decimal.Parse(Console.ReadLine());
            decimal trackCapacity = decimal.Parse(Console.ReadLine());
            decimal money = decimal.Parse(Console.ReadLine());

            var totalRunners = Math.Min(numberOfRunners, trackCapacity * lenghtOfTheMarathonInDays);
            var totalMeters = totalRunners * averageNumberOfLapsEveryRunnerMakes * trackLenght;
            var totalKm = totalMeters / 1000;
            var moneyRaised = totalKm * money;
            Console.WriteLine($"Money raised: {moneyRaised:f2}");
        }
    }
}
