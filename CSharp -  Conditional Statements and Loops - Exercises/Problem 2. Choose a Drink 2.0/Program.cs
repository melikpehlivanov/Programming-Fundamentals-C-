using System;

namespace Problem_2.Choose_a_Drink_2._0
{
    class Program
    {
        static void Main()
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            if (profession == "Athlete")
            {
                var price = quantity * 0.70;
                Console.WriteLine($"The Athlete has to pay {price:f2}.");
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                var price = quantity * 1;
                Console.WriteLine($"The {profession} has to pay {price:f2}.");
            }
            else if (profession == "SoftUni Student")
            {
                var price = quantity * 1.70;
                Console.WriteLine($"The SoftUni Student has to pay {price:f2}.");
            }
            else
            {
                var price = quantity * 1.20;
                Console.WriteLine($"The {profession} has to pay {price:f2}.");
            }
        }
    
    }
}
