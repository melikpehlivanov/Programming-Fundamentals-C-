using System;

namespace _02.Vapor_Store
{
   public class Program
    {
        public static void Main()
        {
            decimal money = decimal.Parse(Console.ReadLine());
            decimal outFall4Price = 39.99M;
            decimal csOgPrice = 15.99M;
            decimal zplinterZellPrice = 19.99M;
            decimal honored2Price = 59.99M;
            decimal roverWatchPrice = 29.99M;
            decimal roverWatchOriginsPrice = 39.99M;
            decimal totalSpent = 0.0M;

                while (money > 0)
                {
                    string game = Console.ReadLine().ToLower();
                    if (game == "outfall 4")
                    {
                        if (money < outFall4Price)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            money -= outFall4Price;
                            totalSpent += outFall4Price;
                            Console.WriteLine("Bought OutFall 4");
                        }
                    }
                    else if (game == "cs: og")
                    {
                        if (money < csOgPrice)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            money -= csOgPrice;
                            totalSpent += csOgPrice;
                            Console.WriteLine("Bought CS: OG");
                        }
                    }
                    else if (game == "zplinter zell")
                    {
                        if (money < zplinterZellPrice)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            money -= zplinterZellPrice;
                            totalSpent += zplinterZellPrice;
                            Console.WriteLine("Bought Zplinter Zell");
                        }
                    }
                    else if (game == "honored 2")
                    {
                        if (money < honored2Price)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            money -= honored2Price;
                            totalSpent += honored2Price;
                            Console.WriteLine("Bought Honored 2");
                        }
                    }
                    else if (game == "roverwatch")
                    {
                        if (money < roverWatchPrice)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            money -= roverWatchPrice;
                            totalSpent += roverWatchPrice;
                            Console.WriteLine("Bought RoverWatch");
                        }
                    }
                    else if (game == "roverwatch origins edition")
                    {
                        if (money < roverWatchOriginsPrice)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            money -= roverWatchOriginsPrice;
                            totalSpent += roverWatchOriginsPrice;
                            Console.WriteLine("Bought RoverWatch Origins Edition");
                        }
                    }
                    else if (game == "game time")
                    {
                        Console.WriteLine($"Total spent: ${totalSpent:f2}. Remaining: ${money:f2}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Not Found");
                    }
                }
                if (money <= 0)
                {
                    Console.WriteLine("Out of money!");
                }
            }
        }
    }

 