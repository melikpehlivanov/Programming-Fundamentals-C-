namespace _01.SinoTheWalker
{
    using System;
    using System.Globalization;
    class Program
    {
        static void Main()
        {
            //86400 total seconds in 1 day
            System.Globalization.CultureInfo provider = CultureInfo.InvariantCulture;
            DateTime starttime = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", provider);
            double steps = double.Parse(Console.ReadLine()) % 86400;
            double secsonsperstep = double.Parse(Console.ReadLine()) % 86400;
            double res = steps * secsonsperstep;
            DateTime Arrival = starttime.AddSeconds(res);
            Console.WriteLine("Time Arrival: {0}", Arrival.ToString("HH:mm:ss"));
        }
    }
}
