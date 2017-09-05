namespace _02.Icarus
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var planes = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int damage = 1;
            int planeLength = planes.Count; int currentPosition = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            while (command != "Supernova")
            {
                List<string> tokens = command.Split(' ').ToList();
                string directionInWhichThePlaneShouldMove = tokens[0];
                int steps = int.Parse(tokens[1]);
                if (directionInWhichThePlaneShouldMove == "left")
                {
                    if (currentPosition - steps < 0)
                    {
                        int counter = steps;
                        while (currentPosition >= 0)
                        {
                            if (currentPosition == 0)
                            {
                                currentPosition = planeLength;
                                damage++;
                            }
                            currentPosition--;
                            planes[currentPosition] -= damage;
                            counter--;
                            if (currentPosition == 0 && counter > 0)
                            {
                                currentPosition = planeLength;
                                damage++;
                            }
                            if (counter == 0)
                            {
                                break;
                            }
                        }
                    }
                    else
                    {
                        int counter = steps;
                        while (counter > 0)
                        {
                            currentPosition--;
                            planes[currentPosition] -= damage;
                            counter--;
                        }
                    }
                }
                else if (directionInWhichThePlaneShouldMove == "right")
                {
                    if (currentPosition + steps > planeLength - 1)
                    {
                        int counter = steps;
                        while (currentPosition <= planeLength - 1)
                        {
                            if (currentPosition == planeLength - 1)
                            {
                                currentPosition = -1;
                                damage++;
                            }
                            currentPosition++;
                            planes[currentPosition] -= damage;
                            counter--;
                            if (currentPosition == planeLength - 1 && counter > 0)
                            {
                                currentPosition = -1;
                                damage++;
                            }
                            if (counter == 0)
                            {
                                break;
                            }
                        }
                    }
                    else
                    {
                        int counter = steps;
                        while (counter > 0)
                        {
                            currentPosition++;
                            planes[currentPosition] -= damage;
                            counter--;
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", planes));
        }
    }
}
