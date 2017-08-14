namespace _01.Softuni_Coffee_Orders
{
    using System;
    using System.Globalization;
    public class CoffeeOrders
    {
        public static void Main()
        {
            //discount formula ((daysInMonth * capsulesCount) * pricePerCapsule)
            int n = int.Parse(Console.ReadLine());

            decimal totalPrice = 0;

            for (int i = 0; i < n; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                DateTime orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                long count = long.Parse(Console.ReadLine());
                int daysInMonth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);
                decimal price = daysInMonth * count * pricePerCapsule;
                totalPrice += price;

                Console.WriteLine($"The price for the coffee is: ${price:f2}");

            }

            Console.WriteLine($"Total: ${totalPrice:f2}");

        }
    }
}
