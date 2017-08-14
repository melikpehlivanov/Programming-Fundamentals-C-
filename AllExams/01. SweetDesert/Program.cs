namespace _01.SweetDesert
{
    using System;
    public class Program
    {
        public static void Main()
        {
            decimal money = decimal.Parse(Console.ReadLine());
            int guests = int.Parse(Console.ReadLine());
            decimal bananaPrice = decimal.Parse(Console.ReadLine());
            decimal eggsPrice = decimal.Parse(Console.ReadLine());
            decimal berryPrice = decimal.Parse(Console.ReadLine());

            var portions = guests / 6;

            if (guests%6!=0)
            {
                portions++;
            }

            decimal pricePerPortion = 2 * bananaPrice + 4 * eggsPrice + 0.2m * berryPrice;
            decimal totalPrice = pricePerPortion * portions;
            decimal moneyLeft = money - totalPrice;
            if (moneyLeft>=0)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {Math.Abs(moneyLeft):f2}lv more.");
            }
        }
    }
}
