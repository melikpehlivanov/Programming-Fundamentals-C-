using System;
using System.Collections.Generic;

namespace _06.DNA_Sequences
{
    public class Program
    {
        public static void Main()
        {
            var currentBalance = decimal.Parse(Console.ReadLine());

            var totalMoney = currentBalance;

            var buyingOrder = Console.ReadLine();

            var gamesDictionary = new Dictionary<string, decimal>()
            {
                {"OutFall 4" , 39.99m},
                {"CS: OG" , 15.99m},
                {"Zplinter Zell" , 19.99m},
                {"Honored 2" , 59.99m},
                {"RoverWatch" , 29.99m},
                {"RoverWatch Origins Edition" , 39.99m},
            };

            var isGamePresent = false;

            while (buyingOrder != "Game Time")
            {

                foreach (var game in gamesDictionary)
                {
                    if (game.Key == buyingOrder)
                    {
                        isGamePresent = true;

                        if (currentBalance >= game.Value)
                        {
                            currentBalance -= game.Value;
                            Console.WriteLine($"Bought {game.Key}");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        if (currentBalance == 0)
                        {
                            Console.WriteLine("Out of money!");
                            return;
                        }
                    }
                }

                if (!isGamePresent)
                {
                    Console.WriteLine("Not Found");
                }

                buyingOrder = Console.ReadLine();
                isGamePresent = false;
            }

            var remainingMoney = totalMoney - currentBalance;
            Console.WriteLine($"Total spent: ${remainingMoney:F2}. Remaining: ${currentBalance:F2}");
        }
    }
   }
