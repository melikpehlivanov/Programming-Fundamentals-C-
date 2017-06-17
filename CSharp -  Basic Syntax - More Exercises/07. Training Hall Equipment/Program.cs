using System;

namespace _07.Training_Hall_Equipment
{
    public class Program
    {
       public static void Main()
        {
                double budget = double.Parse(Console.ReadLine());
                double n = double.Parse(Console.ReadLine());
                double money_spent = 0;
                for (int i = 0; i < n; i++)
                {
                    String s = Console.ReadLine();

                    double price = double.Parse(Console.ReadLine());

                    int quantity = int.Parse(Console.ReadLine());

                    money_spent += price * quantity;
                    if (quantity <= 2)
                        Console.WriteLine($"Adding {quantity} {s}s to cart.");
                    else Console.WriteLine($"Adding {quantity} {s}s to cart.");
                }

                if (money_spent <= budget)
                {
                    Console.WriteLine($"Subtotal: ${money_spent:F2}");
                    Console.WriteLine($"Money left: ${Math.Abs(budget - money_spent):F2}");
                }
                else
                {
                    Console.WriteLine($"Subtotal: ${Math.Abs(money_spent):F2}");
                    Console.WriteLine($"Not enough. We need ${money_spent - budget:F2} more.");
                }

            }
        }
    }
