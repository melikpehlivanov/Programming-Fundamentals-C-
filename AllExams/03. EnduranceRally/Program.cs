namespace _03.EnduranceRally
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string[] racers = Console.ReadLine().Split(' ').ToArray();
            double[] zonesArray = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int[] checkPoints = Console.ReadLine().Split(' ').Select(int.Parse).Select(x => Math.Abs(x)).ToArray();

            foreach (var racer in racers)
            {
                double fuel = racer[0];
                int checkPointsCounter = 0;

                for (int i = 0; i < zonesArray.Length; i++)
                {
                    bool isEqual = false;

                    for (int k = 0; k < checkPoints.Length; k++)
                    {
                        if (i == checkPoints[k])
                        {
                            isEqual = true;
                            break;
                        }
                    }

                    if (isEqual)
                    {
                        fuel += zonesArray[i];
                    }
                    else
                    {
                        fuel -= zonesArray[i];
                    }

                    if (fuel > 0)
                    {
                        checkPointsCounter++;
                    }
                    else
                    {
                        Console.WriteLine($"{racer} - reached {checkPointsCounter}");
                        break;
                    }

                }

                if (fuel > 0)
                {
                    Console.WriteLine($"{racer} - fuel left {fuel:f2}");
                }
            }
        }
    }
}

